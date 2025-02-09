
namespace Magic_Maths_Adventure.Forms
{
    partial class frmTrollBattle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrollBattle));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pxtmusic = new System.Windows.Forms.PictureBox();
            this.pxthome = new System.Windows.Forms.PictureBox();
            this.lblMEnupnl = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lbl100s = new System.Windows.Forms.Label();
            this.lbl10s = new System.Windows.Forms.Label();
            this.lbl1s = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblQ = new System.Windows.Forms.Label();
            this.pxtogre = new System.Windows.Forms.PictureBox();
            this.pxtav = new System.Windows.Forms.PictureBox();
            this.mskedtxt100s = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxt1s = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxt10s = new System.Windows.Forms.MaskedTextBox();
            this.pgrsbrWizard = new System.Windows.Forms.ProgressBar();
            this.pgrsbrAv = new System.Windows.Forms.ProgressBar();
            this.pxtHelp = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtogre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Red;
            this.pnlMenu.Controls.Add(this.pxtmusic);
            this.pnlMenu.Controls.Add(this.pxthome);
            this.pnlMenu.Controls.Add(this.lblMEnupnl);
            this.pnlMenu.Controls.Add(this.lblCoins);
            this.pnlMenu.Location = new System.Drawing.Point(-9, 563);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(834, 107);
            this.pnlMenu.TabIndex = 37;
            // 
            // pxtmusic
            // 
            this.pxtmusic.Image = global::Magic_Maths_Adventure.Properties.Resources.MusicOn;
            this.pxtmusic.Location = new System.Drawing.Point(680, 14);
            this.pxtmusic.Name = "pxtmusic";
            this.pxtmusic.Size = new System.Drawing.Size(97, 82);
            this.pxtmusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtmusic.TabIndex = 49;
            this.pxtmusic.TabStop = false;
            this.pxtmusic.Click += new System.EventHandler(this.pxtmusic_Click);
            // 
            // pxthome
            // 
            this.pxthome.Image = global::Magic_Maths_Adventure.Properties.Resources.Home;
            this.pxthome.Location = new System.Drawing.Point(559, 3);
            this.pxthome.Name = "pxthome";
            this.pxthome.Size = new System.Drawing.Size(98, 101);
            this.pxthome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxthome.TabIndex = 45;
            this.pxthome.TabStop = false;
            this.pxthome.Click += new System.EventHandler(this.pxthome_Click);
            // 
            // lblMEnupnl
            // 
            this.lblMEnupnl.AutoSize = true;
            this.lblMEnupnl.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMEnupnl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMEnupnl.Location = new System.Drawing.Point(19, 32);
            this.lblMEnupnl.Name = "lblMEnupnl";
            this.lblMEnupnl.Size = new System.Drawing.Size(293, 28);
            this.lblMEnupnl.TabIndex = 5;
            this.lblMEnupnl.Text = "Magic Maths: Ogre Battle!";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoins.Location = new System.Drawing.Point(500, 32);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(25, 28);
            this.lblCoins.TabIndex = 4;
            this.lblCoins.Text = "$";
            // 
            // lbl100s
            // 
            this.lbl100s.AutoSize = true;
            this.lbl100s.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl100s.Location = new System.Drawing.Point(56, 138);
            this.lbl100s.Name = "lbl100s";
            this.lbl100s.Size = new System.Drawing.Size(153, 22);
            this.lbl100s.TabIndex = 48;
            this.lbl100s.Text = "How Many 100s?";
            // 
            // lbl10s
            // 
            this.lbl10s.AutoSize = true;
            this.lbl10s.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10s.Location = new System.Drawing.Point(296, 138);
            this.lbl10s.Name = "lbl10s";
            this.lbl10s.Size = new System.Drawing.Size(142, 22);
            this.lbl10s.TabIndex = 50;
            this.lbl10s.Text = "How Many 10s?";
            // 
            // lbl1s
            // 
            this.lbl1s.AutoSize = true;
            this.lbl1s.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1s.Location = new System.Drawing.Point(546, 138);
            this.lbl1s.Name = "lbl1s";
            this.lbl1s.Size = new System.Drawing.Size(131, 22);
            this.lbl1s.TabIndex = 52;
            this.lbl1s.Text = "How Many 1s?";
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.Red;
            this.btnAnswer.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnswer.Location = new System.Drawing.Point(294, 340);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(144, 59);
            this.btnAnswer.TabIndex = 55;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(346, 74);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(54, 22);
            this.lblQ.TabIndex = 56;
            this.lblQ.Text = "0000";
            // 
            // pxtogre
            // 
            this.pxtogre.Image = global::Magic_Maths_Adventure.Properties.Resources.Ogre;
            this.pxtogre.Location = new System.Drawing.Point(540, 270);
            this.pxtogre.Name = "pxtogre";
            this.pxtogre.Size = new System.Drawing.Size(198, 290);
            this.pxtogre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxtogre.TabIndex = 54;
            this.pxtogre.TabStop = false;
            // 
            // pxtav
            // 
            this.pxtav.Location = new System.Drawing.Point(30, 340);
            this.pxtav.Name = "pxtav";
            this.pxtav.Size = new System.Drawing.Size(133, 217);
            this.pxtav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtav.TabIndex = 53;
            this.pxtav.TabStop = false;
            // 
            // mskedtxt100s
            // 
            this.mskedtxt100s.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskedtxt100s.Location = new System.Drawing.Point(60, 163);
            this.mskedtxt100s.Mask = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "000000000000000000000000";
            this.mskedtxt100s.Name = "mskedtxt100s";
            this.mskedtxt100s.Size = new System.Drawing.Size(149, 36);
            this.mskedtxt100s.TabIndex = 57;
            // 
            // mskdtxt1s
            // 
            this.mskdtxt1s.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdtxt1s.Location = new System.Drawing.Point(540, 163);
            this.mskdtxt1s.Mask = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "000000000000000000000000";
            this.mskdtxt1s.Name = "mskdtxt1s";
            this.mskdtxt1s.Size = new System.Drawing.Size(149, 36);
            this.mskdtxt1s.TabIndex = 58;
            // 
            // mskdtxt10s
            // 
            this.mskdtxt10s.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdtxt10s.Location = new System.Drawing.Point(294, 163);
            this.mskdtxt10s.Mask = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "000000000000000000000000";
            this.mskdtxt10s.Name = "mskdtxt10s";
            this.mskdtxt10s.Size = new System.Drawing.Size(149, 36);
            this.mskdtxt10s.TabIndex = 59;
            // 
            // pgrsbrWizard
            // 
            this.pgrsbrWizard.Location = new System.Drawing.Point(540, 224);
            this.pgrsbrWizard.Name = "pgrsbrWizard";
            this.pgrsbrWizard.Size = new System.Drawing.Size(198, 40);
            this.pgrsbrWizard.TabIndex = 60;
            this.pgrsbrWizard.Value = 100;
            // 
            // pgrsbrAv
            // 
            this.pgrsbrAv.Location = new System.Drawing.Point(30, 221);
            this.pgrsbrAv.Name = "pgrsbrAv";
            this.pgrsbrAv.Size = new System.Drawing.Size(198, 40);
            this.pgrsbrAv.TabIndex = 61;
            this.pgrsbrAv.Value = 100;
            // 
            // pxtHelp
            // 
            this.pxtHelp.Image = global::Magic_Maths_Adventure.Properties.Resources.HelpWizard;
            this.pxtHelp.Location = new System.Drawing.Point(671, 0);
            this.pxtHelp.Name = "pxtHelp";
            this.pxtHelp.Size = new System.Drawing.Size(117, 126);
            this.pxtHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHelp.TabIndex = 62;
            this.pxtHelp.TabStop = false;
            this.pxtHelp.Click += new System.EventHandler(this.pxtHelp_Click);
            // 
            // frmTrollBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.pxtHelp);
            this.Controls.Add(this.pgrsbrAv);
            this.Controls.Add(this.pgrsbrWizard);
            this.Controls.Add(this.mskdtxt10s);
            this.Controls.Add(this.mskdtxt1s);
            this.Controls.Add(this.mskedtxt100s);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.pxtogre);
            this.Controls.Add(this.pxtav);
            this.Controls.Add(this.lbl1s);
            this.Controls.Add(this.lbl10s);
            this.Controls.Add(this.lbl100s);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTrollBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle the Ogre!";
            this.Load += new System.EventHandler(this.frmTrollBattle_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtogre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pxtmusic;
        private System.Windows.Forms.PictureBox pxthome;
        private System.Windows.Forms.Label lblMEnupnl;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label lbl100s;
        private System.Windows.Forms.Label lbl10s;
        private System.Windows.Forms.Label lbl1s;
        private System.Windows.Forms.PictureBox pxtav;
        private System.Windows.Forms.PictureBox pxtogre;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.MaskedTextBox mskedtxt100s;
        private System.Windows.Forms.MaskedTextBox mskdtxt1s;
        private System.Windows.Forms.MaskedTextBox mskdtxt10s;
        private System.Windows.Forms.ProgressBar pgrsbrWizard;
        private System.Windows.Forms.ProgressBar pgrsbrAv;
        private System.Windows.Forms.PictureBox pxtHelp;
    }
}