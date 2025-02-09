
namespace Magic_Maths_Adventure.Forms
{
    partial class frmFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeedback));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pxtmusic = new System.Windows.Forms.PictureBox();
            this.pxthome = new System.Windows.Forms.PictureBox();
            this.lblMEnupnl = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lstbxTips = new System.Windows.Forms.ListBox();
            this.lblLvl1Score = new System.Windows.Forms.Label();
            this.lblLvl3Score = new System.Windows.Forms.Label();
            this.lblLvl2Score = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblTips = new System.Windows.Forms.Label();
            this.pxtHelp = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).BeginInit();
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
            this.pnlMenu.Location = new System.Drawing.Point(0, 560);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(817, 107);
            this.pnlMenu.TabIndex = 35;
            // 
            // pxtmusic
            // 
            this.pxtmusic.Image = global::Magic_Maths_Adventure.Properties.Resources.MusicOn;
            this.pxtmusic.Location = new System.Drawing.Point(687, 3);
            this.pxtmusic.Name = "pxtmusic";
            this.pxtmusic.Size = new System.Drawing.Size(97, 82);
            this.pxtmusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtmusic.TabIndex = 46;
            this.pxtmusic.TabStop = false;
            this.pxtmusic.Click += new System.EventHandler(this.pxtmusic_Click);
            // 
            // pxthome
            // 
            this.pxthome.Image = global::Magic_Maths_Adventure.Properties.Resources.Home;
            this.pxthome.Location = new System.Drawing.Point(587, 0);
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
            this.lblMEnupnl.Size = new System.Drawing.Size(264, 28);
            this.lblMEnupnl.TabIndex = 5;
            this.lblMEnupnl.Text = "Magic Maths: Feedback";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoins.Location = new System.Drawing.Point(536, 32);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(25, 28);
            this.lblCoins.TabIndex = 4;
            this.lblCoins.Text = "$";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(245, 56);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(287, 32);
            this.lblFeedback.TabIndex = 36;
            this.lblFeedback.Text = "Here\'s Your Feedback!";
            // 
            // lstbxTips
            // 
            this.lstbxTips.BackColor = System.Drawing.Color.Blue;
            this.lstbxTips.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxTips.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstbxTips.FormattingEnabled = true;
            this.lstbxTips.ItemHeight = 19;
            this.lstbxTips.Location = new System.Drawing.Point(0, 378);
            this.lstbxTips.Name = "lstbxTips";
            this.lstbxTips.Size = new System.Drawing.Size(784, 137);
            this.lstbxTips.TabIndex = 37;
            // 
            // lblLvl1Score
            // 
            this.lblLvl1Score.AutoSize = true;
            this.lblLvl1Score.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvl1Score.Location = new System.Drawing.Point(18, 135);
            this.lblLvl1Score.Name = "lblLvl1Score";
            this.lblLvl1Score.Size = new System.Drawing.Size(246, 32);
            this.lblLvl1Score.TabIndex = 38;
            this.lblLvl1Score.Text = "Your Level 1 Score:";
            // 
            // lblLvl3Score
            // 
            this.lblLvl3Score.AutoSize = true;
            this.lblLvl3Score.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvl3Score.Location = new System.Drawing.Point(18, 321);
            this.lblLvl3Score.Name = "lblLvl3Score";
            this.lblLvl3Score.Size = new System.Drawing.Size(246, 32);
            this.lblLvl3Score.TabIndex = 39;
            this.lblLvl3Score.Text = "Your Level 3 Score:";
            // 
            // lblLvl2Score
            // 
            this.lblLvl2Score.AutoSize = true;
            this.lblLvl2Score.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvl2Score.Location = new System.Drawing.Point(18, 230);
            this.lblLvl2Score.Name = "lblLvl2Score";
            this.lblLvl2Score.Size = new System.Drawing.Size(246, 32);
            this.lblLvl2Score.TabIndex = 40;
            this.lblLvl2Score.Text = "Your Level 2 Score:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(259, 143);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 22);
            this.lbl1.TabIndex = 41;
            this.lbl1.Text = "0000";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(259, 329);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(54, 22);
            this.lbl3.TabIndex = 42;
            this.lbl3.Text = "0000";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(259, 238);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(54, 22);
            this.lbl2.TabIndex = 43;
            this.lbl2.Text = "0000";
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTips.Location = new System.Drawing.Point(12, 353);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(268, 22);
            this.lblTips.TabIndex = 44;
            this.lblTips.Text = "Tips to Improve in the Future:";
            // 
            // pxtHelp
            // 
            this.pxtHelp.Image = global::Magic_Maths_Adventure.Properties.Resources.HelpWizard;
            this.pxtHelp.Location = new System.Drawing.Point(667, 1);
            this.pxtHelp.Name = "pxtHelp";
            this.pxtHelp.Size = new System.Drawing.Size(117, 126);
            this.pxtHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHelp.TabIndex = 45;
            this.pxtHelp.TabStop = false;
            this.pxtHelp.Click += new System.EventHandler(this.pxtHelp_Click);
            // 
            // frmFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.pxtHelp);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblLvl2Score);
            this.Controls.Add(this.lblLvl3Score);
            this.Controls.Add(this.lblLvl1Score);
            this.Controls.Add(this.lstbxTips);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the Feedback Form";
            this.Load += new System.EventHandler(this.frmFeedback_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMEnupnl;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.ListBox lstbxTips;
        private System.Windows.Forms.Label lblLvl1Score;
        private System.Windows.Forms.Label lblLvl3Score;
        private System.Windows.Forms.Label lblLvl2Score;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.PictureBox pxthome;
        private System.Windows.Forms.PictureBox pxtHelp;
        private System.Windows.Forms.PictureBox pxtmusic;
    }
}