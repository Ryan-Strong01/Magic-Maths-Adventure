
namespace Magic_Maths_Adventure.Forms
{
    partial class frmLevel1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevel1));
            this.lblOption1 = new System.Windows.Forms.Label();
            this.lblOption2 = new System.Windows.Forms.Label();
            this.lblOption3 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pgrsbrWizard = new System.Windows.Forms.ProgressBar();
            this.pnlLevel1 = new System.Windows.Forms.Panel();
            this.pxtmusic = new System.Windows.Forms.PictureBox();
            this.pxthome = new System.Windows.Forms.PictureBox();
            this.pxtHint = new System.Windows.Forms.PictureBox();
            this.lblLevel1 = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.pxtHelp = new System.Windows.Forms.PictureBox();
            this.pxtAnswerDrop = new System.Windows.Forms.PictureBox();
            this.pxtHealth3 = new System.Windows.Forms.PictureBox();
            this.pxtHealth2 = new System.Windows.Forms.PictureBox();
            this.pxtHealth1 = new System.Windows.Forms.PictureBox();
            this.pxtVillain = new System.Windows.Forms.PictureBox();
            this.pxtYourAvatar = new System.Windows.Forms.PictureBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlLevel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtAnswerDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHealth3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtVillain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtYourAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOption1
            // 
            this.lblOption1.AutoSize = true;
            this.lblOption1.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption1.Location = new System.Drawing.Point(182, 160);
            this.lblOption1.Name = "lblOption1";
            this.lblOption1.Size = new System.Drawing.Size(118, 32);
            this.lblOption1.TabIndex = 48;
            this.lblOption1.Text = "Option 1";
            this.lblOption1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblOption1_MouseDown);
            // 
            // lblOption2
            // 
            this.lblOption2.AutoSize = true;
            this.lblOption2.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption2.Location = new System.Drawing.Point(339, 160);
            this.lblOption2.Name = "lblOption2";
            this.lblOption2.Size = new System.Drawing.Size(118, 32);
            this.lblOption2.TabIndex = 47;
            this.lblOption2.Text = "Option 2";
            this.lblOption2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblOption1_MouseDown);
            // 
            // lblOption3
            // 
            this.lblOption3.AutoSize = true;
            this.lblOption3.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption3.Location = new System.Drawing.Point(486, 160);
            this.lblOption3.Name = "lblOption3";
            this.lblOption3.Size = new System.Drawing.Size(118, 32);
            this.lblOption3.TabIndex = 46;
            this.lblOption3.Text = "Option 3";
            this.lblOption3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblOption1_MouseDown);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(326, 79);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(123, 32);
            this.lblQuestion.TabIndex = 45;
            this.lblQuestion.Text = "Question";
            // 
            // pgrsbrWizard
            // 
            this.pgrsbrWizard.Location = new System.Drawing.Point(563, 257);
            this.pgrsbrWizard.Name = "pgrsbrWizard";
            this.pgrsbrWizard.Size = new System.Drawing.Size(216, 40);
            this.pgrsbrWizard.TabIndex = 41;
            this.pgrsbrWizard.Value = 100;
            // 
            // pnlLevel1
            // 
            this.pnlLevel1.BackColor = System.Drawing.Color.Red;
            this.pnlLevel1.Controls.Add(this.pxtmusic);
            this.pnlLevel1.Controls.Add(this.pxthome);
            this.pnlLevel1.Controls.Add(this.pxtHint);
            this.pnlLevel1.Controls.Add(this.lblLevel1);
            this.pnlLevel1.Controls.Add(this.lblCoins);
            this.pnlLevel1.Location = new System.Drawing.Point(-14, 560);
            this.pnlLevel1.Name = "pnlLevel1";
            this.pnlLevel1.Size = new System.Drawing.Size(813, 107);
            this.pnlLevel1.TabIndex = 39;
            // 
            // pxtmusic
            // 
            this.pxtmusic.Image = global::Magic_Maths_Adventure.Properties.Resources.MusicOn;
            this.pxtmusic.Location = new System.Drawing.Point(689, 7);
            this.pxtmusic.Name = "pxtmusic";
            this.pxtmusic.Size = new System.Drawing.Size(97, 82);
            this.pxtmusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtmusic.TabIndex = 55;
            this.pxtmusic.TabStop = false;
            this.pxtmusic.Click += new System.EventHandler(this.pxtmusic_Click);
            // 
            // pxthome
            // 
            this.pxthome.Image = global::Magic_Maths_Adventure.Properties.Resources.Home;
            this.pxthome.Location = new System.Drawing.Point(447, 0);
            this.pxthome.Name = "pxthome";
            this.pxthome.Size = new System.Drawing.Size(98, 101);
            this.pxthome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxthome.TabIndex = 54;
            this.pxthome.TabStop = false;
            this.pxthome.Click += new System.EventHandler(this.pxthome_Click);
            // 
            // pxtHint
            // 
            this.pxtHint.Image = global::Magic_Maths_Adventure.Properties.Resources.HintButton;
            this.pxtHint.Location = new System.Drawing.Point(567, 3);
            this.pxtHint.Name = "pxtHint";
            this.pxtHint.Size = new System.Drawing.Size(100, 93);
            this.pxtHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHint.TabIndex = 2;
            this.pxtHint.TabStop = false;
            this.pxtHint.Click += new System.EventHandler(this.pxtHint_Click);
            // 
            // lblLevel1
            // 
            this.lblLevel1.AutoSize = true;
            this.lblLevel1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLevel1.Location = new System.Drawing.Point(23, 32);
            this.lblLevel1.Name = "lblLevel1";
            this.lblLevel1.Size = new System.Drawing.Size(237, 28);
            this.lblLevel1.TabIndex = 5;
            this.lblLevel1.Text = "Magic Maths: Level 1";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoins.Location = new System.Drawing.Point(364, 32);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(25, 28);
            this.lblCoins.TabIndex = 4;
            this.lblCoins.Text = "$";
            // 
            // pxtHelp
            // 
            this.pxtHelp.Image = global::Magic_Maths_Adventure.Properties.Resources.HelpWizard;
            this.pxtHelp.Location = new System.Drawing.Point(662, -6);
            this.pxtHelp.Name = "pxtHelp";
            this.pxtHelp.Size = new System.Drawing.Size(117, 126);
            this.pxtHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHelp.TabIndex = 50;
            this.pxtHelp.TabStop = false;
            this.pxtHelp.Click += new System.EventHandler(this.pxtHelp_Click);
            // 
            // pxtAnswerDrop
            // 
            this.pxtAnswerDrop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pxtAnswerDrop.Location = new System.Drawing.Point(265, 246);
            this.pxtAnswerDrop.Name = "pxtAnswerDrop";
            this.pxtAnswerDrop.Size = new System.Drawing.Size(245, 97);
            this.pxtAnswerDrop.TabIndex = 49;
            this.pxtAnswerDrop.TabStop = false;
            this.pxtAnswerDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pxtAnswerDrop_DragDrop);
            this.pxtAnswerDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pxtAnswerDrop_DragEnter);
            // 
            // pxtHealth3
            // 
            this.pxtHealth3.Image = global::Magic_Maths_Adventure.Properties.Resources.HeartAlive;
            this.pxtHealth3.Location = new System.Drawing.Point(9, 246);
            this.pxtHealth3.Name = "pxtHealth3";
            this.pxtHealth3.Size = new System.Drawing.Size(52, 51);
            this.pxtHealth3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHealth3.TabIndex = 44;
            this.pxtHealth3.TabStop = false;
            // 
            // pxtHealth2
            // 
            this.pxtHealth2.Image = global::Magic_Maths_Adventure.Properties.Resources.HeartAlive;
            this.pxtHealth2.Location = new System.Drawing.Point(78, 246);
            this.pxtHealth2.Name = "pxtHealth2";
            this.pxtHealth2.Size = new System.Drawing.Size(52, 51);
            this.pxtHealth2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHealth2.TabIndex = 43;
            this.pxtHealth2.TabStop = false;
            // 
            // pxtHealth1
            // 
            this.pxtHealth1.Image = global::Magic_Maths_Adventure.Properties.Resources.HeartAlive;
            this.pxtHealth1.Location = new System.Drawing.Point(136, 246);
            this.pxtHealth1.Name = "pxtHealth1";
            this.pxtHealth1.Size = new System.Drawing.Size(52, 51);
            this.pxtHealth1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHealth1.TabIndex = 42;
            this.pxtHealth1.TabStop = false;
            // 
            // pxtVillain
            // 
            this.pxtVillain.Image = global::Magic_Maths_Adventure.Properties.Resources.GorlockAlive;
            this.pxtVillain.Location = new System.Drawing.Point(563, 303);
            this.pxtVillain.Name = "pxtVillain";
            this.pxtVillain.Size = new System.Drawing.Size(216, 251);
            this.pxtVillain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtVillain.TabIndex = 40;
            this.pxtVillain.TabStop = false;
            // 
            // pxtYourAvatar
            // 
            this.pxtYourAvatar.Location = new System.Drawing.Point(9, 303);
            this.pxtYourAvatar.Name = "pxtYourAvatar";
            this.pxtYourAvatar.Size = new System.Drawing.Size(179, 253);
            this.pxtYourAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtYourAvatar.TabIndex = 38;
            this.pxtYourAvatar.TabStop = false;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbltime.Location = new System.Drawing.Point(373, 32);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(30, 32);
            this.lbltime.TabIndex = 54;
            this.lbltime.Text = "0";
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // frmLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.pxtHelp);
            this.Controls.Add(this.pxtAnswerDrop);
            this.Controls.Add(this.lblOption1);
            this.Controls.Add(this.lblOption2);
            this.Controls.Add(this.lblOption3);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pxtHealth3);
            this.Controls.Add(this.pxtHealth2);
            this.Controls.Add(this.pxtHealth1);
            this.Controls.Add(this.pgrsbrWizard);
            this.Controls.Add(this.pxtVillain);
            this.Controls.Add(this.pnlLevel1);
            this.Controls.Add(this.pxtYourAvatar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLevel1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defeat the Evil Troll Gorlock!";
            this.Load += new System.EventHandler(this.frmLevel1_Load);
            this.pnlLevel1.ResumeLayout(false);
            this.pnlLevel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtAnswerDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHealth3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtVillain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtYourAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pxtHelp;
        private System.Windows.Forms.PictureBox pxtAnswerDrop;
        private System.Windows.Forms.Label lblOption1;
        private System.Windows.Forms.Label lblOption2;
        private System.Windows.Forms.Label lblOption3;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox pxtHealth3;
        private System.Windows.Forms.PictureBox pxtHealth2;
        private System.Windows.Forms.PictureBox pxtHealth1;
        private System.Windows.Forms.ProgressBar pgrsbrWizard;
        private System.Windows.Forms.PictureBox pxtVillain;
        private System.Windows.Forms.Panel pnlLevel1;
        private System.Windows.Forms.PictureBox pxtHint;
        private System.Windows.Forms.Label lblLevel1;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox pxtYourAvatar;
        private System.Windows.Forms.PictureBox pxthome;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.PictureBox pxtmusic;
    }
}