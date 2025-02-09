
namespace Magic_Maths_Adventure.Forms
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnGame = new System.Windows.Forms.Button();
            this.btnMiniGames = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnLeaderboards = new System.Windows.Forms.Button();
            this.lblLoginPlease = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pxtmusic = new System.Windows.Forms.PictureBox();
            this.lblMEnupnl = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.pxtHelp = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.Red;
            this.btnGame.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGame.Location = new System.Drawing.Point(41, 140);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(191, 155);
            this.btnGame.TabIndex = 40;
            this.btnGame.Tag = "1";
            this.btnGame.Text = "Magic Maths";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnMiniGames
            // 
            this.btnMiniGames.BackColor = System.Drawing.Color.Red;
            this.btnMiniGames.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniGames.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMiniGames.Location = new System.Drawing.Point(260, 140);
            this.btnMiniGames.Name = "btnMiniGames";
            this.btnMiniGames.Size = new System.Drawing.Size(191, 155);
            this.btnMiniGames.TabIndex = 39;
            this.btnMiniGames.Tag = "2";
            this.btnMiniGames.Text = "Mini Games";
            this.btnMiniGames.UseVisualStyleBackColor = false;
            this.btnMiniGames.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.Red;
            this.btnShop.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShop.Location = new System.Drawing.Point(260, 330);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(191, 155);
            this.btnShop.TabIndex = 38;
            this.btnShop.Tag = "5";
            this.btnShop.Text = "Avatar Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Red;
            this.btnAdmin.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmin.Location = new System.Drawing.Point(41, 330);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(191, 155);
            this.btnAdmin.TabIndex = 37;
            this.btnAdmin.Tag = "4";
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnLeaderboards
            // 
            this.btnLeaderboards.BackColor = System.Drawing.Color.Red;
            this.btnLeaderboards.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderboards.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLeaderboards.Location = new System.Drawing.Point(488, 140);
            this.btnLeaderboards.Name = "btnLeaderboards";
            this.btnLeaderboards.Size = new System.Drawing.Size(191, 155);
            this.btnLeaderboards.TabIndex = 36;
            this.btnLeaderboards.Tag = "3";
            this.btnLeaderboards.Text = "Leaderboards";
            this.btnLeaderboards.UseVisualStyleBackColor = false;
            this.btnLeaderboards.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // lblLoginPlease
            // 
            this.lblLoginPlease.AutoSize = true;
            this.lblLoginPlease.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPlease.Location = new System.Drawing.Point(92, 60);
            this.lblLoginPlease.Name = "lblLoginPlease";
            this.lblLoginPlease.Size = new System.Drawing.Size(526, 32);
            this.lblLoginPlease.TabIndex = 35;
            this.lblLoginPlease.Text = "Welcome, Please Choose somewhere to go";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Red;
            this.pnlMenu.Controls.Add(this.pxtmusic);
            this.pnlMenu.Controls.Add(this.lblMEnupnl);
            this.pnlMenu.Controls.Add(this.lblCoins);
            this.pnlMenu.Location = new System.Drawing.Point(-16, 558);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(817, 107);
            this.pnlMenu.TabIndex = 34;
            // 
            // pxtmusic
            // 
            this.pxtmusic.Image = global::Magic_Maths_Adventure.Properties.Resources.MusicOn;
            this.pxtmusic.Location = new System.Drawing.Point(691, 9);
            this.pxtmusic.Name = "pxtmusic";
            this.pxtmusic.Size = new System.Drawing.Size(97, 82);
            this.pxtmusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtmusic.TabIndex = 43;
            this.pxtmusic.TabStop = false;
            this.pxtmusic.Click += new System.EventHandler(this.pxtmusic_Click);
            // 
            // lblMEnupnl
            // 
            this.lblMEnupnl.AutoSize = true;
            this.lblMEnupnl.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMEnupnl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMEnupnl.Location = new System.Drawing.Point(19, 32);
            this.lblMEnupnl.Name = "lblMEnupnl";
            this.lblMEnupnl.Size = new System.Drawing.Size(281, 28);
            this.lblMEnupnl.TabIndex = 5;
            this.lblMEnupnl.Text = "Magic Maths: Main Menu";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoins.Location = new System.Drawing.Point(609, 32);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(25, 28);
            this.lblCoins.TabIndex = 4;
            this.lblCoins.Text = "$";
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.Red;
            this.btnFeedback.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFeedback.Location = new System.Drawing.Point(488, 330);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(191, 155);
            this.btnFeedback.TabIndex = 42;
            this.btnFeedback.Tag = "6";
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // pxtHelp
            // 
            this.pxtHelp.Image = global::Magic_Maths_Adventure.Properties.Resources.HelpWizard;
            this.pxtHelp.Location = new System.Drawing.Point(666, -1);
            this.pxtHelp.Name = "pxtHelp";
            this.pxtHelp.Size = new System.Drawing.Size(117, 126);
            this.pxtHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHelp.TabIndex = 41;
            this.pxtHelp.TabStop = false;
            this.pxtHelp.Click += new System.EventHandler(this.pxtHelp_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.pxtHelp);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnMiniGames);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnLeaderboards);
            this.Controls.Add(this.lblLoginPlease);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome, Please Select an Option!";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pxtHelp;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnMiniGames;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnLeaderboards;
        private System.Windows.Forms.Label lblLoginPlease;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMEnupnl;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.PictureBox pxtmusic;
    }
}