
namespace Magic_Maths_Adventure.Forms
{
    partial class frmPotionMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPotionMaker));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pxtmusic = new System.Windows.Forms.PictureBox();
            this.pxthome = new System.Windows.Forms.PictureBox();
            this.lblMEnupnl = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblOption3 = new System.Windows.Forms.Label();
            this.lblOption2 = new System.Windows.Forms.Label();
            this.lblOption1 = new System.Windows.Forms.Label();
            this.pgrsbrGoal = new System.Windows.Forms.ProgressBar();
            this.pxtcauldronEmpty = new System.Windows.Forms.PictureBox();
            this.pxtPotion = new System.Windows.Forms.PictureBox();
            this.pxtav = new System.Windows.Forms.PictureBox();
            this.pxtHelp = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtcauldronEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtPotion)).BeginInit();
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
            this.pnlMenu.Location = new System.Drawing.Point(0, 561);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(834, 107);
            this.pnlMenu.TabIndex = 38;
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
            this.lblMEnupnl.Size = new System.Drawing.Size(317, 28);
            this.lblMEnupnl.TabIndex = 5;
            this.lblMEnupnl.Text = "Magic Maths: Potion Maker!";
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
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(312, 94);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(123, 32);
            this.lblQuestion.TabIndex = 46;
            this.lblQuestion.Text = "Question";
            // 
            // lblOption3
            // 
            this.lblOption3.AutoSize = true;
            this.lblOption3.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption3.Location = new System.Drawing.Point(553, 160);
            this.lblOption3.Name = "lblOption3";
            this.lblOption3.Size = new System.Drawing.Size(143, 32);
            this.lblOption3.TabIndex = 47;
            this.lblOption3.Text = "lblOption1";
            this.lblOption3.Click += new System.EventHandler(this.lblOption1_Click);
            // 
            // lblOption2
            // 
            this.lblOption2.AutoSize = true;
            this.lblOption2.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption2.Location = new System.Drawing.Point(312, 160);
            this.lblOption2.Name = "lblOption2";
            this.lblOption2.Size = new System.Drawing.Size(143, 32);
            this.lblOption2.TabIndex = 48;
            this.lblOption2.Text = "lblOption2";
            this.lblOption2.Click += new System.EventHandler(this.lblOption1_Click);
            // 
            // lblOption1
            // 
            this.lblOption1.AutoSize = true;
            this.lblOption1.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption1.Location = new System.Drawing.Point(98, 160);
            this.lblOption1.Name = "lblOption1";
            this.lblOption1.Size = new System.Drawing.Size(123, 32);
            this.lblOption1.TabIndex = 49;
            this.lblOption1.Text = "Question";
            this.lblOption1.Click += new System.EventHandler(this.lblOption1_Click);
            // 
            // pgrsbrGoal
            // 
            this.pgrsbrGoal.Location = new System.Drawing.Point(231, 27);
            this.pgrsbrGoal.Name = "pgrsbrGoal";
            this.pgrsbrGoal.Size = new System.Drawing.Size(294, 50);
            this.pgrsbrGoal.TabIndex = 50;
            // 
            // pxtcauldronEmpty
            // 
            this.pxtcauldronEmpty.Image = global::Magic_Maths_Adventure.Properties.Resources.EmptyCauldron;
            this.pxtcauldronEmpty.Location = new System.Drawing.Point(272, 297);
            this.pxtcauldronEmpty.Name = "pxtcauldronEmpty";
            this.pxtcauldronEmpty.Size = new System.Drawing.Size(271, 258);
            this.pxtcauldronEmpty.TabIndex = 51;
            this.pxtcauldronEmpty.TabStop = false;
            // 
            // pxtPotion
            // 
            this.pxtPotion.Image = global::Magic_Maths_Adventure.Properties.Resources.VerticalPotion;
            this.pxtPotion.Location = new System.Drawing.Point(559, 217);
            this.pxtPotion.Name = "pxtPotion";
            this.pxtPotion.Size = new System.Drawing.Size(193, 144);
            this.pxtPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtPotion.TabIndex = 52;
            this.pxtPotion.TabStop = false;
            // 
            // pxtav
            // 
            this.pxtav.Location = new System.Drawing.Point(15, 306);
            this.pxtav.Name = "pxtav";
            this.pxtav.Size = new System.Drawing.Size(167, 248);
            this.pxtav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtav.TabIndex = 53;
            this.pxtav.TabStop = false;
            // 
            // pxtHelp
            // 
            this.pxtHelp.Image = global::Magic_Maths_Adventure.Properties.Resources.HelpWizard;
            this.pxtHelp.Location = new System.Drawing.Point(660, 0);
            this.pxtHelp.Name = "pxtHelp";
            this.pxtHelp.Size = new System.Drawing.Size(117, 126);
            this.pxtHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHelp.TabIndex = 54;
            this.pxtHelp.TabStop = false;
            this.pxtHelp.Click += new System.EventHandler(this.pxtHelp_Click);
            // 
            // frmPotionMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.pxtHelp);
            this.Controls.Add(this.pxtav);
            this.Controls.Add(this.pxtPotion);
            this.Controls.Add(this.pxtcauldronEmpty);
            this.Controls.Add(this.pgrsbrGoal);
            this.Controls.Add(this.lblOption1);
            this.Controls.Add(this.lblOption2);
            this.Controls.Add(this.lblOption3);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPotionMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make the Potions to Win!";
            this.Load += new System.EventHandler(this.frmPotionMaker_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtcauldronEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtPotion)).EndInit();
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
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblOption3;
        private System.Windows.Forms.Label lblOption2;
        private System.Windows.Forms.Label lblOption1;
        private System.Windows.Forms.ProgressBar pgrsbrGoal;
        private System.Windows.Forms.PictureBox pxtcauldronEmpty;
        private System.Windows.Forms.PictureBox pxtPotion;
        private System.Windows.Forms.PictureBox pxtav;
        private System.Windows.Forms.PictureBox pxtHelp;
    }
}