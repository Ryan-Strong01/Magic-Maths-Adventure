
namespace Magic_Maths_Adventure.Forms
{
    partial class frmLevel2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevel2));
            this.pgrsbrVillain = new System.Windows.Forms.ProgressBar();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.pnlLevel2 = new System.Windows.Forms.Panel();
            this.pxtmusic = new System.Windows.Forms.PictureBox();
            this.pxthome = new System.Windows.Forms.PictureBox();
            this.lblLevel2 = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.pxtHelp = new System.Windows.Forms.PictureBox();
            this.pxtHeart3 = new System.Windows.Forms.PictureBox();
            this.pxtHeart2 = new System.Windows.Forms.PictureBox();
            this.pxtHealth1 = new System.Windows.Forms.PictureBox();
            this.pxtVillain = new System.Windows.Forms.PictureBox();
            this.pxtYourAvatar = new System.Windows.Forms.PictureBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlLevel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtVillain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtYourAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pgrsbrVillain
            // 
            this.pgrsbrVillain.Location = new System.Drawing.Point(537, 238);
            this.pgrsbrVillain.Name = "pgrsbrVillain";
            this.pgrsbrVillain.Size = new System.Drawing.Size(216, 40);
            this.pgrsbrVillain.TabIndex = 40;
            this.pgrsbrVillain.Value = 100;
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.Red;
            this.btnAnswer.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnswer.Location = new System.Drawing.Point(314, 334);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(144, 59);
            this.btnAnswer.TabIndex = 39;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // pnlLevel2
            // 
            this.pnlLevel2.BackColor = System.Drawing.Color.Red;
            this.pnlLevel2.Controls.Add(this.pxtmusic);
            this.pnlLevel2.Controls.Add(this.pxthome);
            this.pnlLevel2.Controls.Add(this.lblLevel2);
            this.pnlLevel2.Controls.Add(this.lblCoins);
            this.pnlLevel2.Location = new System.Drawing.Point(-8, 559);
            this.pnlLevel2.Name = "pnlLevel2";
            this.pnlLevel2.Size = new System.Drawing.Size(800, 107);
            this.pnlLevel2.TabIndex = 36;
            // 
            // pxtmusic
            // 
            this.pxtmusic.Image = global::Magic_Maths_Adventure.Properties.Resources.MusicOn;
            this.pxtmusic.Location = new System.Drawing.Point(682, 8);
            this.pxtmusic.Name = "pxtmusic";
            this.pxtmusic.Size = new System.Drawing.Size(97, 82);
            this.pxtmusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtmusic.TabIndex = 56;
            this.pxtmusic.TabStop = false;
            this.pxtmusic.Click += new System.EventHandler(this.pxtmusic_Click);
            // 
            // pxthome
            // 
            this.pxthome.Image = global::Magic_Maths_Adventure.Properties.Resources.Home;
            this.pxthome.Location = new System.Drawing.Point(578, 0);
            this.pxthome.Name = "pxthome";
            this.pxthome.Size = new System.Drawing.Size(98, 101);
            this.pxthome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxthome.TabIndex = 46;
            this.pxthome.TabStop = false;
            this.pxthome.Click += new System.EventHandler(this.pxthome_Click);
            // 
            // lblLevel2
            // 
            this.lblLevel2.AutoSize = true;
            this.lblLevel2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLevel2.Location = new System.Drawing.Point(20, 31);
            this.lblLevel2.Name = "lblLevel2";
            this.lblLevel2.Size = new System.Drawing.Size(237, 28);
            this.lblLevel2.TabIndex = 5;
            this.lblLevel2.Text = "Magic Maths: Level 2";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoins.Location = new System.Drawing.Point(497, 31);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(25, 28);
            this.lblCoins.TabIndex = 4;
            this.lblCoins.Text = "$";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(318, 148);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(123, 32);
            this.lblQuestion.TabIndex = 35;
            this.lblQuestion.Text = "Question";
            // 
            // txtanswer
            // 
            this.txtanswer.BackColor = System.Drawing.SystemColors.Window;
            this.txtanswer.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanswer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtanswer.Location = new System.Drawing.Point(247, 238);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(284, 36);
            this.txtanswer.TabIndex = 45;
            // 
            // pxtHelp
            // 
            this.pxtHelp.Image = global::Magic_Maths_Adventure.Properties.Resources.HelpWizard;
            this.pxtHelp.Location = new System.Drawing.Point(666, 0);
            this.pxtHelp.Name = "pxtHelp";
            this.pxtHelp.Size = new System.Drawing.Size(117, 126);
            this.pxtHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHelp.TabIndex = 44;
            this.pxtHelp.TabStop = false;
            this.pxtHelp.Click += new System.EventHandler(this.pxtHelp_Click);
            // 
            // pxtHeart3
            // 
            this.pxtHeart3.Image = global::Magic_Maths_Adventure.Properties.Resources.HeartAlive;
            this.pxtHeart3.Location = new System.Drawing.Point(12, 227);
            this.pxtHeart3.Name = "pxtHeart3";
            this.pxtHeart3.Size = new System.Drawing.Size(52, 51);
            this.pxtHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHeart3.TabIndex = 43;
            this.pxtHeart3.TabStop = false;
            // 
            // pxtHeart2
            // 
            this.pxtHeart2.Image = global::Magic_Maths_Adventure.Properties.Resources.HeartAlive;
            this.pxtHeart2.Location = new System.Drawing.Point(90, 227);
            this.pxtHeart2.Name = "pxtHeart2";
            this.pxtHeart2.Size = new System.Drawing.Size(52, 51);
            this.pxtHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHeart2.TabIndex = 42;
            this.pxtHeart2.TabStop = false;
            // 
            // pxtHealth1
            // 
            this.pxtHealth1.Image = global::Magic_Maths_Adventure.Properties.Resources.HeartAlive;
            this.pxtHealth1.Location = new System.Drawing.Point(176, 227);
            this.pxtHealth1.Name = "pxtHealth1";
            this.pxtHealth1.Size = new System.Drawing.Size(52, 51);
            this.pxtHealth1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHealth1.TabIndex = 41;
            this.pxtHealth1.TabStop = false;
            // 
            // pxtVillain
            // 
            this.pxtVillain.Image = global::Magic_Maths_Adventure.Properties.Resources.EvilDwarf;
            this.pxtVillain.Location = new System.Drawing.Point(537, 302);
            this.pxtVillain.Name = "pxtVillain";
            this.pxtVillain.Size = new System.Drawing.Size(216, 251);
            this.pxtVillain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtVillain.TabIndex = 38;
            this.pxtVillain.TabStop = false;
            // 
            // pxtYourAvatar
            // 
            this.pxtYourAvatar.Location = new System.Drawing.Point(12, 284);
            this.pxtYourAvatar.Name = "pxtYourAvatar";
            this.pxtYourAvatar.Size = new System.Drawing.Size(216, 269);
            this.pxtYourAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtYourAvatar.TabIndex = 37;
            this.pxtYourAvatar.TabStop = false;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbltime.Location = new System.Drawing.Point(370, 43);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(30, 32);
            this.lbltime.TabIndex = 55;
            this.lbltime.Text = "0";
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // frmLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.pxtHelp);
            this.Controls.Add(this.pxtHeart3);
            this.Controls.Add(this.pxtHeart2);
            this.Controls.Add(this.pxtHealth1);
            this.Controls.Add(this.pgrsbrVillain);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.pxtVillain);
            this.Controls.Add(this.pxtYourAvatar);
            this.Controls.Add(this.pnlLevel2);
            this.Controls.Add(this.lblQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLevel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level 2: Battle the Dwarf Gimli!";
            this.Load += new System.EventHandler(this.frmLevel2_Load);
            this.pnlLevel2.ResumeLayout(false);
            this.pnlLevel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtVillain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtYourAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pxtHelp;
        private System.Windows.Forms.PictureBox pxtHeart3;
        private System.Windows.Forms.PictureBox pxtHeart2;
        private System.Windows.Forms.PictureBox pxtHealth1;
        private System.Windows.Forms.ProgressBar pgrsbrVillain;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.PictureBox pxtVillain;
        private System.Windows.Forms.PictureBox pxtYourAvatar;
        private System.Windows.Forms.Panel pnlLevel2;
        private System.Windows.Forms.Label lblLevel2;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.PictureBox pxthome;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.PictureBox pxtmusic;
    }
}