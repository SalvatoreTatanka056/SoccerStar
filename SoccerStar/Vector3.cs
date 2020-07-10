using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical0304
{
    class Vector3
    {
        private double x, y, z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        /// <summary>
        /// default constructor, makes null vector
        /// </summary>
        public Vector3()
        {
            x = 0.0;
            y = 0.0;
            z = 0.0;
        }
        /// <summary>
        /// Constructor  taking values for x, y and z
        /// </summary
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="z1"></param>
        public Vector3(double x1, double y1, double z1)
        {
            x = x1;
            y = y1;
            z = z1;
        }
        /// <summary>
        /// constructor taking a vector as the source
        /// </summary>
        /// <param name="v"></param>
        public Vector3(Vector3 v)
        {
            x = v.x;
            y = v.y;
            z = v.z;
        }
        /// <summary>
        /// override for ToString method outputting brackets, comas and formatting the
        /// values as general 3 digits
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "(" + x.ToString("g3") + "," + y.ToString("g3") + "," + z.ToString("g3") + ")";
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public bool Equal(Vector3 v2)
        {
            if (x == v2.X && y == v2.Y && z == v2.Z) //true if all components in one vector is equal to components in another.
                return true;
            else
                return false;
        }
        public double DotProduct(Vector3 v2)
        {
            return (x * v2.X + y * v2.Y + z * v2.Z);
        }

        public Vector3 CrossProduct(Vector3 v2)
        {
            return new Vector3(y * v2.Z - z * v2.Y, z * v2.X - x * v2.Z, x * v2.Y - y * v2.X);
        }
        public double AngleBetween(Vector3 v2)
        {
            double answer = 0;
            double top = this.DotProduct(v2);
            double under = this.Length() * v2.Length();
            double angle;
            //never divide by zero
            if (under != 0)
                answer = top/under;
            else
                return 0;
            //cosine inverse can't do number bigger than 1
            if (answer > 1) answer = 1;
            if (answer < -1) answer = -1;
            angle = Math.Acos(answer);
            return (angle* 180/Math.PI);
        }
        public Vector3 Unit()
        {
            double length = Math.Sqrt(x * x + y * y + z * z);
            return new Vector3(x / length, y / length, z / length);
        }

        public Vector3 ParralelComponent(Vector3 v2)
        {
            double lengthSquared, dotProduct, scale;
            lengthSquared = Length() * Length();
            dotProduct = DotProduct(v2);
            if (lengthSquared != 0)
                scale = dotProduct / lengthSquared;
            else
                return new Vector3();
            return new Vector3(this.Scale(scale));
        }

        public Vector3 PerpendicularComponent(Vector3 v2)
        {
            //subtract the parallel component from the orginal vecot
            //to get the orthogonal bit

            return new Vector3(v2 - this.ParralelComponent(v2)); // perpendicular component = vectorAnswer - parallel component
        }

        public Vector3 Scale(double scale)
        {
            return new Vector3(scale * x, scale * y, scale * z); //Multiplys by scalar
        }

        public static Vector3 operator *(double k, Vector3 v1)
        {
            return new Vector3(k * v1.x, k * v1.y, k * v1.z);
        }

        public static Vector3 operator *(Vector3 v1, double k)
        {
            return new Vector3(k * v1.x, k * v1.y, k * v1.z);
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z); //adds
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z); //subtracts
        }
    
        public static Vector3 operator -(Vector3 v1)
        {
            return new Vector3(-v1.x, -v1.y, -v1.z);
        }
    }
}
