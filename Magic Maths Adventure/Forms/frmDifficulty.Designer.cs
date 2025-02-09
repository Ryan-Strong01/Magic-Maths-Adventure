
namespace Magic_Maths_Adventure.Forms
{
    partial class frmDifficulty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDifficulty));
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.pnlDifficultyDesign = new System.Windows.Forms.Panel();
            this.pxtmusic = new System.Windows.Forms.PictureBox();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblMAGIC = new System.Windows.Forms.Label();
            this.pxthome = new System.Windows.Forms.PictureBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.pxtHelp = new System.Windows.Forms.PictureBox();
            this.cmbxMode = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.pnlDifficultyDesign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Red;
            this.btnHard.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHard.Location = new System.Drawing.Point(527, 168);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(202, 159);
            this.btnHard.TabIndex = 35;
            this.btnHard.Tag = "HARD";
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.Red;
            this.btnMedium.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMedium.Location = new System.Drawing.Point(274, 168);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(202, 159);
            this.btnMedium.TabIndex = 34;
            this.btnMedium.Tag = "MEDIUM";
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.Red;
            this.btnEasy.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEasy.Location = new System.Drawing.Point(21, 168);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(202, 159);
            this.btnEasy.TabIndex = 32;
            this.btnEasy.Tag = "EASY";
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // pnlDifficultyDesign
            // 
            this.pnlDifficultyDesign.BackColor = System.Drawing.Color.Red;
            this.pnlDifficultyDesign.Controls.Add(this.pxtmusic);
            this.pnlDifficultyDesign.Controls.Add(this.lblCoins);
            this.pnlDifficultyDesign.Controls.Add(this.lblMAGIC);
            this.pnlDifficultyDesign.Controls.Add(this.pxthome);
            this.pnlDifficultyDesign.Location = new System.Drawing.Point(-8, 555);
            this.pnlDifficultyDesign.Name = "pnlDifficultyDesign";
            this.pnlDifficultyDesign.Size = new System.Drawing.Size(800, 107);
            this.pnlDifficultyDesign.TabIndex = 31;
            // 
            // pxtmusic
            // 
            this.pxtmusic.Image = global::Magic_Maths_Adventure.Properties.Resources.MusicOn;
            this.pxtmusic.Location = new System.Drawing.Point(683, 12);
            this.pxtmusic.Name = "pxtmusic";
            this.pxtmusic.Size = new System.Drawing.Size(97, 82);
            this.pxtmusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtmusic.TabIndex = 47;
            this.pxtmusic.TabStop = false;
            this.pxtmusic.Click += new System.EventHandler(this.pxtmusic_Click);
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoins.Location = new System.Drawing.Point(501, 42);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(25, 28);
            this.lblCoins.TabIndex = 46;
            this.lblCoins.Text = "$";
            // 
            // lblMAGIC
            // 
            this.lblMAGIC.AutoSize = true;
            this.lblMAGIC.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAGIC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMAGIC.Location = new System.Drawing.Point(24, 42);
            this.lblMAGIC.Name = "lblMAGIC";
            this.lblMAGIC.Size = new System.Drawing.Size(358, 28);
            this.lblMAGIC.TabIndex = 46;
            this.lblMAGIC.Text = "Magic Maths: Difficulty Selector";
            // 
            // pxthome
            // 
            this.pxthome.Image = global::Magic_Maths_Adventure.Properties.Resources.Home;
            this.pxthome.Location = new System.Drawing.Point(575, 3);
            this.pxthome.Name = "pxthome";
            this.pxthome.Size = new System.Drawing.Size(98, 101);
            this.pxthome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxthome.TabIndex = 38;
            this.pxthome.TabStop = false;
            this.pxthome.Click += new System.EventHandler(this.pxthome_Click);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(56, 39);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(595, 32);
            this.lblDifficulty.TabIndex = 33;
            this.lblDifficulty.Text = "Welcome, Please Select a Difficulty and a Mode";
            // 
            // pxtHelp
            // 
            this.pxtHelp.Image = global::Magic_Maths_Adventure.Properties.Resources.HelpWizard;
            this.pxtHelp.Location = new System.Drawing.Point(675, 1);
            this.pxtHelp.Name = "pxtHelp";
            this.pxtHelp.Size = new System.Drawing.Size(117, 126);
            this.pxtHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHelp.TabIndex = 36;
            this.pxtHelp.TabStop = false;
            this.pxtHelp.Click += new System.EventHandler(this.pxtHelp_Click);
            // 
            // cmbxMode
            // 
            this.cmbxMode.BackColor = System.Drawing.SystemColors.Window;
            this.cmbxMode.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbxMode.FormattingEnabled = true;
            this.cmbxMode.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division"});
            this.cmbxMode.Location = new System.Drawing.Point(21, 398);
            this.cmbxMode.Name = "cmbxMode";
            this.cmbxMode.Size = new System.Drawing.Size(708, 33);
            this.cmbxMode.TabIndex = 37;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(17, 373);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(140, 22);
            this.lblType.TabIndex = 45;
            this.lblType.Text = "Question Type:";
            // 
            // frmDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbxMode);
            this.Controls.Add(this.pxtHelp);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.pnlDifficultyDesign);
            this.Controls.Add(this.lblDifficulty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDifficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please Select a Difficulty and a Mode";
            this.Load += new System.EventHandler(this.frmDifficulty_Load);
            this.pnlDifficultyDesign.ResumeLayout(false);
            this.pnlDifficultyDesign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pxtHelp;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Panel pnlDifficultyDesign;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ComboBox cmbxMode;
        private System.Windows.Forms.PictureBox pxthome;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMAGIC;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox pxtmusic;
    }
}