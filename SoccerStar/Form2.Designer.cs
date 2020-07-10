namespace Practical0304
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbTipoContratto = new System.Windows.Forms.ComboBox();
            this.lblTipoContratto = new System.Windows.Forms.Label();
            this.lblCSPId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbCSPName = new System.Windows.Forms.ComboBox();
            this.lblCSPName = new System.Windows.Forms.Label();
            this.lblIDProvider = new System.Windows.Forms.Label();
            this.txtIDProvider = new System.Windows.Forms.TextBox();
            this.cmbTipoOperazione = new System.Windows.Forms.ComboBox();
            this.lblTipoOperazione = new System.Windows.Forms.Label();
            this.lblDescrServizio = new System.Windows.Forms.Label();
            this.txtDescrizioneServizio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRMEmittente = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblEmittente = new System.Windows.Forms.Label();
            this.lblCodiceAGESP = new System.Windows.Forms.Label();
            this.txtCodiceAGESP = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDataInizioS = new System.Windows.Forms.Label();
            this.dtpDIS = new System.Windows.Forms.DateTimePicker();
            this.dtpDFS = new System.Windows.Forms.DateTimePicker();
            this.lblDataFineSperimentazione = new System.Windows.Forms.Label();
            this.cmbStato = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKit = new System.Windows.Forms.ComboBox();
            this.lblKit = new System.Windows.Forms.Label();
            this.cmbKit2 = new System.Windows.Forms.ComboBox();
            this.lblRequisito = new System.Windows.Forms.Label();
            this.txtRequisito = new System.Windows.Forms.TextBox();
            this.lblRierimento = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblVersione = new System.Windows.Forms.Label();
            this.txtVersione = new System.Windows.Forms.TextBox();
            this.lblNoteVersione = new System.Windows.Forms.Label();
            this.txtNoteVersione = new System.Windows.Forms.TextBox();
            this.lblDataInserimento = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblDataModifica = new System.Windows.Forms.Label();
            this.txtDataModifica = new System.Windows.Forms.TextBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eseguiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.Controls.Add(this.tabPage1);
            this.tblMain.Controls.Add(this.tabPage2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblMain.Location = new System.Drawing.Point(0, 28);
            this.tblMain.Name = "tblMain";
            this.tblMain.SelectedIndex = 0;
            this.tblMain.Size = new System.Drawing.Size(1365, 803);
            this.tblMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDataModifica);
            this.tabPage1.Controls.Add(this.txtDataModifica);
            this.tabPage1.Controls.Add(this.lblDataInserimento);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.lblNoteVersione);
            this.tabPage1.Controls.Add(this.txtNoteVersione);
            this.tabPage1.Controls.Add(this.lblVersione);
            this.tabPage1.Controls.Add(this.txtVersione);
            this.tabPage1.Controls.Add(this.lblRierimento);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.lblRequisito);
            this.tabPage1.Controls.Add(this.txtRequisito);
            this.tabPage1.Controls.Add(this.cmbKit2);
            this.tabPage1.Controls.Add(this.cmbKit);
            this.tabPage1.Controls.Add(this.lblKit);
            this.tabPage1.Controls.Add(this.cmbStato);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtpDFS);
            this.tabPage1.Controls.Add(this.lblDataFineSperimentazione);
            this.tabPage1.Controls.Add(this.dtpDIS);
            this.tabPage1.Controls.Add(this.lblDataInizioS);
            this.tabPage1.Controls.Add(this.cmbTipoContratto);
            this.tabPage1.Controls.Add(this.lblTipoContratto);
            this.tabPage1.Controls.Add(this.lblCSPId);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.cmbCSPName);
            this.tabPage1.Controls.Add(this.lblCSPName);
            this.tabPage1.Controls.Add(this.lblIDProvider);
            this.tabPage1.Controls.Add(this.txtIDProvider);
            this.tabPage1.Controls.Add(this.cmbTipoOperazione);
            this.tabPage1.Controls.Add(this.lblTipoOperazione);
            this.tabPage1.Controls.Add(this.lblDescrServizio);
            this.tabPage1.Controls.Add(this.txtDescrizioneServizio);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtRMEmittente);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.lblEmittente);
            this.tabPage1.Controls.Add(this.lblCodiceAGESP);
            this.tabPage1.Controls.Add(this.txtCodiceAGESP);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1357, 774);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modello LA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbTipoContratto
            // 
            this.cmbTipoContratto.FormattingEnabled = true;
            this.cmbTipoContratto.Location = new System.Drawing.Point(240, 416);
            this.cmbTipoContratto.Name = "cmbTipoContratto";
            this.cmbTipoContratto.Size = new System.Drawing.Size(248, 24);
            this.cmbTipoContratto.TabIndex = 18;
            // 
            // lblTipoContratto
            // 
            this.lblTipoContratto.AutoSize = true;
            this.lblTipoContratto.Location = new System.Drawing.Point(43, 416);
            this.lblTipoContratto.Name = "lblTipoContratto";
            this.lblTipoContratto.Size = new System.Drawing.Size(98, 17);
            this.lblTipoContratto.TabIndex = 17;
            this.lblTipoContratto.Text = "Tipo Contratto";
            // 
            // lblCSPId
            // 
            this.lblCSPId.AutoSize = true;
            this.lblCSPId.Location = new System.Drawing.Point(43, 367);
            this.lblCSPId.Name = "lblCSPId";
            this.lblCSPId.Size = new System.Drawing.Size(52, 17);
            this.lblCSPId.TabIndex = 16;
            this.lblCSPId.Text = "CSP ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 15;
            // 
            // cmbCSPName
            // 
            this.cmbCSPName.FormattingEnabled = true;
            this.cmbCSPName.Location = new System.Drawing.Point(240, 315);
            this.cmbCSPName.Name = "cmbCSPName";
            this.cmbCSPName.Size = new System.Drawing.Size(248, 24);
            this.cmbCSPName.TabIndex = 14;
            // 
            // lblCSPName
            // 
            this.lblCSPName.AutoSize = true;
            this.lblCSPName.Location = new System.Drawing.Point(43, 317);
            this.lblCSPName.Name = "lblCSPName";
            this.lblCSPName.Size = new System.Drawing.Size(76, 17);
            this.lblCSPName.TabIndex = 13;
            this.lblCSPName.Text = "CSP Name";
            // 
            // lblIDProvider
            // 
            this.lblIDProvider.AutoSize = true;
            this.lblIDProvider.Location = new System.Drawing.Point(43, 272);
            this.lblIDProvider.Name = "lblIDProvider";
            this.lblIDProvider.Size = new System.Drawing.Size(78, 17);
            this.lblIDProvider.TabIndex = 12;
            this.lblIDProvider.Text = "ID Provider";
            // 
            // txtIDProvider
            // 
            this.txtIDProvider.Location = new System.Drawing.Point(240, 270);
            this.txtIDProvider.Name = "txtIDProvider";
            this.txtIDProvider.Size = new System.Drawing.Size(248, 22);
            this.txtIDProvider.TabIndex = 11;
            // 
            // cmbTipoOperazione
            // 
            this.cmbTipoOperazione.FormattingEnabled = true;
            this.cmbTipoOperazione.Location = new System.Drawing.Point(240, 221);
            this.cmbTipoOperazione.Name = "cmbTipoOperazione";
            this.cmbTipoOperazione.Size = new System.Drawing.Size(248, 24);
            this.cmbTipoOperazione.TabIndex = 10;
            // 
            // lblTipoOperazione
            // 
            this.lblTipoOperazione.AutoSize = true;
            this.lblTipoOperazione.Location = new System.Drawing.Point(43, 223);
            this.lblTipoOperazione.Name = "lblTipoOperazione";
            this.lblTipoOperazione.Size = new System.Drawing.Size(114, 17);
            this.lblTipoOperazione.TabIndex = 9;
            this.lblTipoOperazione.Text = "Tipo Operazione";
            // 
            // lblDescrServizio
            // 
            this.lblDescrServizio.AutoSize = true;
            this.lblDescrServizio.Location = new System.Drawing.Point(43, 177);
            this.lblDescrServizio.Name = "lblDescrServizio";
            this.lblDescrServizio.Size = new System.Drawing.Size(136, 17);
            this.lblDescrServizio.TabIndex = 8;
            this.lblDescrServizio.Text = "Descrizione Servizio";
            // 
            // txtDescrizioneServizio
            // 
            this.txtDescrizioneServizio.Location = new System.Drawing.Point(240, 175);
            this.txtDescrizioneServizio.Name = "txtDescrizioneServizio";
            this.txtDescrizioneServizio.Size = new System.Drawing.Size(423, 22);
            this.txtDescrizioneServizio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "RM Emittente";
            // 
            // txtRMEmittente
            // 
            this.txtRMEmittente.Location = new System.Drawing.Point(240, 128);
            this.txtRMEmittente.Name = "txtRMEmittente";
            this.txtRMEmittente.Size = new System.Drawing.Size(248, 22);
            this.txtRMEmittente.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // lblEmittente
            // 
            this.lblEmittente.AutoSize = true;
            this.lblEmittente.Location = new System.Drawing.Point(43, 82);
            this.lblEmittente.Name = "lblEmittente";
            this.lblEmittente.Size = new System.Drawing.Size(67, 17);
            this.lblEmittente.TabIndex = 3;
            this.lblEmittente.Text = "Emittente";
            // 
            // lblCodiceAGESP
            // 
            this.lblCodiceAGESP.AutoSize = true;
            this.lblCodiceAGESP.Location = new System.Drawing.Point(43, 40);
            this.lblCodiceAGESP.Name = "lblCodiceAGESP";
            this.lblCodiceAGESP.Size = new System.Drawing.Size(102, 17);
            this.lblCodiceAGESP.TabIndex = 1;
            this.lblCodiceAGESP.Text = "Codice AGESP";
            // 
            // txtCodiceAGESP
            // 
            this.txtCodiceAGESP.Location = new System.Drawing.Point(240, 35);
            this.txtCodiceAGESP.Name = "txtCodiceAGESP";
            this.txtCodiceAGESP.Size = new System.Drawing.Size(248, 22);
            this.txtCodiceAGESP.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1357, 774);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista LA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblDataInizioS
            // 
            this.lblDataInizioS.AutoSize = true;
            this.lblDataInizioS.Location = new System.Drawing.Point(43, 466);
            this.lblDataInizioS.Name = "lblDataInizioS";
            this.lblDataInizioS.Size = new System.Drawing.Size(184, 17);
            this.lblDataInizioS.TabIndex = 19;
            this.lblDataInizioS.Text = "Data Inizio Sperimentazione";
            // 
            // dtpDIS
            // 
            this.dtpDIS.Location = new System.Drawing.Point(240, 466);
            this.dtpDIS.Name = "dtpDIS";
            this.dtpDIS.Size = new System.Drawing.Size(248, 22);
            this.dtpDIS.TabIndex = 20;
            // 
            // dtpDFS
            // 
            this.dtpDFS.Location = new System.Drawing.Point(240, 514);
            this.dtpDFS.Name = "dtpDFS";
            this.dtpDFS.Size = new System.Drawing.Size(248, 22);
            this.dtpDFS.TabIndex = 22;
            // 
            // lblDataFineSperimentazione
            // 
            this.lblDataFineSperimentazione.AutoSize = true;
            this.lblDataFineSperimentazione.Location = new System.Drawing.Point(43, 514);
            this.lblDataFineSperimentazione.Name = "lblDataFineSperimentazione";
            this.lblDataFineSperimentazione.Size = new System.Drawing.Size(184, 17);
            this.lblDataFineSperimentazione.TabIndex = 21;
            this.lblDataFineSperimentazione.Text = "Data Inizio Sperimentazione";
            // 
            // cmbStato
            // 
            this.cmbStato.FormattingEnabled = true;
            this.cmbStato.Location = new System.Drawing.Point(240, 562);
            this.cmbStato.Name = "cmbStato";
            this.cmbStato.Size = new System.Drawing.Size(248, 24);
            this.cmbStato.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Stato";
            // 
            // cmbKit
            // 
            this.cmbKit.FormattingEnabled = true;
            this.cmbKit.Location = new System.Drawing.Point(240, 614);
            this.cmbKit.Name = "cmbKit";
            this.cmbKit.Size = new System.Drawing.Size(248, 24);
            this.cmbKit.TabIndex = 26;
            // 
            // lblKit
            // 
            this.lblKit.AutoSize = true;
            this.lblKit.Location = new System.Drawing.Point(43, 614);
            this.lblKit.Name = "lblKit";
            this.lblKit.Size = new System.Drawing.Size(24, 17);
            this.lblKit.TabIndex = 25;
            this.lblKit.Text = "Kit";
            // 
            // cmbKit2
            // 
            this.cmbKit2.FormattingEnabled = true;
            this.cmbKit2.Location = new System.Drawing.Point(511, 614);
            this.cmbKit2.Name = "cmbKit2";
            this.cmbKit2.Size = new System.Drawing.Size(248, 24);
            this.cmbKit2.TabIndex = 27;
            // 
            // lblRequisito
            // 
            this.lblRequisito.AutoSize = true;
            this.lblRequisito.Location = new System.Drawing.Point(43, 666);
            this.lblRequisito.Name = "lblRequisito";
            this.lblRequisito.Size = new System.Drawing.Size(67, 17);
            this.lblRequisito.TabIndex = 29;
            this.lblRequisito.Text = "Requisito";
            // 
            // txtRequisito
            // 
            this.txtRequisito.Location = new System.Drawing.Point(240, 664);
            this.txtRequisito.Name = "txtRequisito";
            this.txtRequisito.Size = new System.Drawing.Size(151, 22);
            this.txtRequisito.TabIndex = 28;
            // 
            // lblRierimento
            // 
            this.lblRierimento.AutoSize = true;
            this.lblRierimento.Location = new System.Drawing.Point(43, 713);
            this.lblRierimento.Name = "lblRierimento";
            this.lblRierimento.Size = new System.Drawing.Size(80, 17);
            this.lblRierimento.TabIndex = 31;
            this.lblRierimento.Text = "Riferimento";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 711);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 22);
            this.textBox2.TabIndex = 30;
            // 
            // lblVersione
            // 
            this.lblVersione.AutoSize = true;
            this.lblVersione.Location = new System.Drawing.Point(692, 42);
            this.lblVersione.Name = "lblVersione";
            this.lblVersione.Size = new System.Drawing.Size(64, 17);
            this.lblVersione.TabIndex = 33;
            this.lblVersione.Text = "Versione";
            // 
            // txtVersione
            // 
            this.txtVersione.Location = new System.Drawing.Point(889, 40);
            this.txtVersione.Name = "txtVersione";
            this.txtVersione.Size = new System.Drawing.Size(151, 22);
            this.txtVersione.TabIndex = 32;
            // 
            // lblNoteVersione
            // 
            this.lblNoteVersione.AutoSize = true;
            this.lblNoteVersione.Location = new System.Drawing.Point(692, 82);
            this.lblNoteVersione.Name = "lblNoteVersione";
            this.lblNoteVersione.Size = new System.Drawing.Size(98, 17);
            this.lblNoteVersione.TabIndex = 35;
            this.lblNoteVersione.Text = "Note Versione";
            // 
            // txtNoteVersione
            // 
            this.txtNoteVersione.Location = new System.Drawing.Point(889, 80);
            this.txtNoteVersione.Name = "txtNoteVersione";
            this.txtNoteVersione.Size = new System.Drawing.Size(151, 22);
            this.txtNoteVersione.TabIndex = 34;
            // 
            // lblDataInserimento
            // 
            this.lblDataInserimento.AutoSize = true;
            this.lblDataInserimento.Location = new System.Drawing.Point(692, 125);
            this.lblDataInserimento.Name = "lblDataInserimento";
            this.lblDataInserimento.Size = new System.Drawing.Size(115, 17);
            this.lblDataInserimento.TabIndex = 37;
            this.lblDataInserimento.Text = "Data Inserimento";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(889, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 22);
            this.textBox3.TabIndex = 36;
            // 
            // lblDataModifica
            // 
            this.lblDataModifica.AutoSize = true;
            this.lblDataModifica.Location = new System.Drawing.Point(692, 172);
            this.lblDataModifica.Name = "lblDataModifica";
            this.lblDataModifica.Size = new System.Drawing.Size(94, 17);
            this.lblDataModifica.TabIndex = 39;
            this.lblDataModifica.Text = "Data Modifica";
            // 
            // txtDataModifica
            // 
            this.txtDataModifica.Location = new System.Drawing.Point(889, 167);
            this.txtDataModifica.Name = "txtDataModifica";
            this.txtDataModifica.Size = new System.Drawing.Size(248, 22);
            this.txtDataModifica.TabIndex = 38;
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(24, 834);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(103, 42);
            this.btnMain.TabIndex = 2;
            this.btnMain.Text = "&Nuovo";
            this.btnMain.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 834);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Rimuovi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(380, 834);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(103, 42);
            this.btnEsci.TabIndex = 4;
            this.btnEsci.Text = "&Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eseguiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1365, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eseguiToolStripMenuItem
            // 
            this.eseguiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUovoToolStripMenuItem});
            this.eseguiToolStripMenuItem.Name = "eseguiToolStripMenuItem";
            this.eseguiToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.eseguiToolStripMenuItem.Text = "&File";
            // 
            // nUovoToolStripMenuItem
            // 
            this.nUovoToolStripMenuItem.Name = "nUovoToolStripMenuItem";
            this.nUovoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nUovoToolStripMenuItem.Text = "&Esporta Massiva LA";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 906);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.tblMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tblMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbTipoContratto;
        private System.Windows.Forms.Label lblTipoContratto;
        private System.Windows.Forms.Label lblCSPId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbCSPName;
        private System.Windows.Forms.Label lblCSPName;
        private System.Windows.Forms.Label lblIDProvider;
        private System.Windows.Forms.TextBox txtIDProvider;
        private System.Windows.Forms.ComboBox cmbTipoOperazione;
        private System.Windows.Forms.Label lblTipoOperazione;
        private System.Windows.Forms.Label lblDescrServizio;
        private System.Windows.Forms.TextBox txtDescrizioneServizio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRMEmittente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblEmittente;
        private System.Windows.Forms.Label lblCodiceAGESP;
        private System.Windows.Forms.TextBox txtCodiceAGESP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtpDIS;
        private System.Windows.Forms.Label lblDataInizioS;
        private System.Windows.Forms.DateTimePicker dtpDFS;
        private System.Windows.Forms.Label lblDataFineSperimentazione;
        private System.Windows.Forms.ComboBox cmbKit;
        private System.Windows.Forms.Label lblKit;
        private System.Windows.Forms.ComboBox cmbStato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKit2;
        private System.Windows.Forms.Label lblVersione;
        private System.Windows.Forms.TextBox txtVersione;
        private System.Windows.Forms.Label lblRierimento;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblRequisito;
        private System.Windows.Forms.TextBox txtRequisito;
        private System.Windows.Forms.Label lblNoteVersione;
        private System.Windows.Forms.TextBox txtNoteVersione;
        private System.Windows.Forms.Label lblDataInserimento;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblDataModifica;
        private System.Windows.Forms.TextBox txtDataModifica;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eseguiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUovoToolStripMenuItem;
    }
}