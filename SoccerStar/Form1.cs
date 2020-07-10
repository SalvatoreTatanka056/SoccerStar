using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Practical0304
{
    public partial class Form1 : Form
    {
        Vector3 mouseLocation = new Vector3();
        Vector3 ballCentre = new Vector3(300, 350, 0);
        Vector3 velocity = new Vector3(), radius;
        Vector3 redVelocity = new Vector3(0, 0, 0), redBallCentre = new Vector3(300, 350, 0);
        Vector3 yellowVelocity = new Vector3(0, 0, 0), yellowBallCentre = new Vector3(500, 350, 0);
        float width = 1000;
        float height = 700;

        float topLeftX = 35; 
        float topLeftY = 43;
        int rightBorder = 59, bottomBorder = 135;

        float diameter = 30;
        bool drawWhiteDirLine; 
        bool drawYellowDirLine;
        bool moveWhiteBall; 
        bool moveYellowBall;
        bool moveRedBall;
        float whiteSpeed;  
        float redSpeed;
        float yellowSpeed;
        float PortaCentreX = 20;
        float PortaCentreY = 260;
        float Porta2CentreX = 870;
        float Porta2CentreY = 260;
        bool bGoal = false;
        float sizeFont = 40.5F;
        readonly Image table = Image.FromFile("Images/table_1.png");
        Image scoreboard = Image.FromFile("Images/scoreboard.png");
        Image Giorcatore1 = Image.FromFile("Images/g1.png");
        Image Giorcatore2 = Image.FromFile("Images/g2.png");
        Image Pallone = Image.FromFile("Images/pallone.png");
        //Image PortaSx = Image.FromFile("Images/porta.png");
        //Image PortaDx = Image.FromFile("Images/porta.png");


        const int White = 1, Yellow = 2;
        int turn;
        public Form1()
        {
            InitializeComponent();
            width = this.Width - 30;
            height = this.Height - 50;
            radius = new Vector3(diameter / 2, diameter / 2, 0);
            ballCentre.X = 100;
            ballCentre.Y = 190;
            redBallCentre.X = 300;
            redBallCentre.Y = 190;
            yellowBallCentre.X = 500;
            yellowBallCentre.Y = 190;
            drawWhiteDirLine = false;
            drawYellowDirLine = false;
            moveWhiteBall = false;
            moveYellowBall = true;
            moveRedBall = true;
            turn = White;
          
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Pen blackPen = new Pen(Color.Black, 4f);
            e.Graphics.DrawImage(scoreboard, 0, this.ClientRectangle.Height , this.ClientRectangle.Width,60);
            e.Graphics.DrawImage(table, 0, 0, this.ClientRectangle.Width - 60 , this.ClientRectangle.Height - 60 );
          
            if (drawWhiteDirLine)
            {
                e.Graphics.DrawLine(blackPen, (int)mouseLocation.X, (int)mouseLocation.Y, (int)ballCentre.X, (int)ballCentre.Y);
            }
            else if (drawYellowDirLine)
            {
                e.Graphics.DrawLine(blackPen, (int)mouseLocation.X, (int)mouseLocation.Y, (int)yellowBallCentre.X, (int)yellowBallCentre.Y);
            }
            DrawBall(e);
        }
       
        private void DrawBall(PaintEventArgs e)
        {

            Pen blackPen = new Pen(Color.Black, 3);

            //disegnare porte 

            float positionX = (float)ballCentre.X - diameter / 2;
            float positionY = (float)ballCentre.Y - diameter / 2; 
            /*RectangleF outerRect = new RectangleF(positionX, positionY, diameter, diameter);
            e.Graphics.DrawEllipse(blackPen, outerRect);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            e.Graphics.FillEllipse(whiteBrush, outerRect);*/

            float redPositionX = (float)redBallCentre.X - diameter / 2;
            float redPositionY = (float)redBallCentre.Y - diameter / 2;       
            /*RectangleF outerRectRed = new RectangleF(redPositionX, redPositionY, diameter, diameter);
            e.Graphics.DrawEllipse(blackPen, outerRectRed);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            e.Graphics.FillEllipse(redBrush, outerRectRed);*/

            float yellowPositionX = (float)yellowBallCentre.X - diameter / 2;
            float yellowPositionY = (float)yellowBallCentre.Y - diameter / 2;
            /*RectangleF outerRectYellow = new RectangleF(yellowPositionX, yellowPositionY, diameter, diameter);
            e.Graphics.DrawEllipse(blackPen, outerRectYellow);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            e.Graphics.FillEllipse(yellowBrush, outerRectYellow);*/

            e.Graphics.DrawImage(Giorcatore1, positionX, positionY, diameter, diameter);
            e.Graphics.DrawImage(Giorcatore2, yellowPositionX, yellowPositionY, diameter , diameter );
            e.Graphics.DrawImage(Pallone, redPositionX, redPositionY, diameter, diameter);
            //e.Graphics.DrawImage(PortaSx, PortaCentreX, PortaCentreY, 30, 60);
            //e.Graphics.DrawImage(PortaDx, Porta2CentreX, Porta2CentreY, 30, 60);
      
            Font fnt = new Font("Arial", sizeFont, Font.Style, Font.Unit);
            TextRenderer.DrawText(e.Graphics, "Goooal", fnt, new Point(400, 300), SystemColors.ControlText);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation.X = e.X;
            mouseLocation.Y = e.Y;
           
            if (turn == White)
            {
                drawWhiteDirLine = true;
            }
            else if (turn == Yellow)
            {
                drawYellowDirLine = true;
            }
            moveWhiteBall = false; 
            moveYellowBall = false;
            moveRedBall = false;
        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            mouseLocation.X = e.X;
            mouseLocation.Y = e.Y;       
        }
     
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (turn == White)
            {
                drawWhiteDirLine = false;
                turn = Yellow;
                velocity.X = ballCentre.X - mouseLocation.X;
                velocity.Y = ballCentre.Y - mouseLocation.Y;
                float length = (float)velocity.Length();
                if (length > 40)
                    length = 40;
                whiteSpeed = length / 10; 
                
                if (length != 0)
                {
                    velocity.X /= length; 
                    velocity.Y /= length;
                }
                //lblStatus.Text = "Turno per il Giallo";
            }
            else if (turn == Yellow)
            {
                drawYellowDirLine = false;
                turn = White;
                yellowVelocity.X = yellowBallCentre.X - mouseLocation.X;
                yellowVelocity.Y = yellowBallCentre.Y - mouseLocation.Y;
                float length = (float)yellowVelocity.Length();
                if (length > 40)
                    length = 40;
                yellowSpeed = length / 10; 
                
                if (length != 0) 
                {
                    yellowVelocity.X /= length;  
                    yellowVelocity.Y /= length;
                }
                //lblStatus.Text = "Turno per il Bianco"; 
            }

            moveWhiteBall = true;
            moveRedBall = true;
            moveYellowBall = true;
            
        }
      
        internal void UpdateWorld()
        {
            MoveBall(velocity, ballCentre, whiteSpeed, moveWhiteBall); 
            MoveBall(redVelocity, redBallCentre, redSpeed, moveRedBall); 
            MoveBall(yellowVelocity, yellowBallCentre, yellowSpeed, moveYellowBall);
            CheckCollisions(); 

        }
       
        private void MoveBall(Vector3 velocity, Vector3 ballCentre, float speed, bool moveBall)
        {
            if (moveBall == true)
            {
                ballCentre.X += velocity.X * speed;
                ballCentre.Y += velocity.Y * speed;

                velocity.X *= 0.97; 
                velocity.Y *= 0.97;
                if ((velocity.X < 0.01 && velocity.X > -0.01) && (velocity.Y < 0.01 && velocity.Y > -0.01))
                {
                    velocity.X = 0;
                    velocity.Y = 0;
                }

                if (ballCentre.X <= topLeftX + diameter / 2)
                { 
                    velocity.X = -velocity.X;
                    ballCentre.X = topLeftX + diameter / 2;
                }
                if (ballCentre.X >= topLeftX + width - rightBorder - diameter / 2)
                {  
                    velocity.X = -velocity.X;
                    ballCentre.X = topLeftX + width - rightBorder - diameter / 2;
                }
                if (ballCentre.Y <= topLeftY + diameter / 2)
                {
                    velocity.Y = -velocity.Y;
                    ballCentre.Y = topLeftY + diameter / 2;
                }
                if (ballCentre.Y >= topLeftY + height - bottomBorder - diameter / 2)
                {
                    velocity.Y = -velocity.Y;
                    ballCentre.Y = topLeftY + height - bottomBorder - diameter / 2;
                }
            }
        }

        private bool DetectCollision(Vector3 ballOneCentre, Vector3 ballTwoCentre)
        {
            Vector3 distanceBallOneBallTwo = ballTwoCentre - ballOneCentre; 
            float distance = (float)distanceBallOneBallTwo.Length(); 
            if (distance < diameter + 2)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        private void CheckCollisions()
        {
            Vector3 tempVelocity = new Vector3();
            bool collisionWhiteRed = DetectCollision(ballCentre, redBallCentre);
            bool collisionWhiteYellow = DetectCollision(ballCentre, yellowBallCentre);
            bool collisionRedYellow = DetectCollision(redBallCentre, yellowBallCentre);
            Vector3 PortaSx = new Vector3(Porta2CentreX, Porta2CentreY, 0);
            bool collisionPortaSxRed = DetectCollision(redBallCentre, PortaSx);

            if (collisionPortaSxRed)
            {
                sizeFont = 40.5F;
                
            }
            else
            {
                sizeFont = 1.0F;
                bGoal = false;
            }

            if (collisionWhiteRed)  
            {   
                tempVelocity = ChangeVelocities(velocity, ballCentre, redVelocity, redBallCentre); //Store the new velocity for the first velocity in a temp vector
                redVelocity = ChangeVelocities(redVelocity, redBallCentre, velocity, ballCentre); 
                velocity = tempVelocity;
                redSpeed = whiteSpeed;
            }
            if (collisionWhiteYellow)
            {
                tempVelocity = ChangeVelocities(velocity, ballCentre, yellowVelocity, yellowBallCentre);
                yellowVelocity = ChangeVelocities(yellowVelocity, yellowBallCentre, velocity, ballCentre);
                velocity = tempVelocity;
                float tempSpeed = whiteSpeed;
                whiteSpeed = yellowSpeed;
                yellowSpeed = tempSpeed;
            }
            if (collisionRedYellow)
            {
                tempVelocity = ChangeVelocities(redVelocity, redBallCentre, yellowVelocity, yellowBallCentre);
                yellowVelocity = ChangeVelocities(yellowVelocity, yellowBallCentre, redVelocity, redBallCentre);
                redVelocity = tempVelocity;
                redSpeed = yellowSpeed;
            }
        }

        private Vector3 ChangeVelocities(Vector3 velocityOne, Vector3 ballCentreOne, Vector3 velocityTwo, Vector3 ballCentreTwo)
      
        {
            Vector3 centresVector = ballCentreTwo - ballCentreOne;
            Vector3 ballOnePerpendicular = centresVector.PerpendicularComponent(velocityOne);
            Vector3 ballTwoPerpendicular = centresVector.PerpendicularComponent(velocityTwo);
            Vector3 ballTwoPara = centresVector.ParralelComponent(velocityTwo);

            Vector3 ballOneNewVelocity = ballTwoPara + ballOnePerpendicular; 


            return ballOneNewVelocity; 
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            width = this.Width - 30;
            height = this.Height - 50;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
