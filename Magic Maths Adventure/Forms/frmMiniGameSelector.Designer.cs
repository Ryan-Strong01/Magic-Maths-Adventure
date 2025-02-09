namespace Magic_Maths_Adventure.Forms
{
    partial class frmMiniGameSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMiniGameSelector));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pxtmusic = new System.Windows.Forms.PictureBox();
            this.pxthome = new System.Windows.Forms.PictureBox();
            this.lblMEnupnl = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblTrollBattle = new System.Windows.Forms.Label();
            this.lblPotionMaker = new System.Windows.Forms.Label();
            this.pxtPromoteOgre = new System.Windows.Forms.PictureBox();
            this.pxtHelp = new System.Windows.Forms.PictureBox();
            this.pxtPotion = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtPromoteOgre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtPotion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Red;
            this.pnlMenu.Controls.Add(this.pxtmusic);
            this.pnlMenu.Controls.Add(this.pxthome);
            this.pnlMenu.Controls.Add(this.lblMEnupnl);
            this.pnlMenu.Controls.Add(this.lblCoins);
            this.pnlMenu.Location = new System.Drawing.Point(-5, 553);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(823, 107);
            this.pnlMenu.TabIndex = 36;
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
            this.lblMEnupnl.Size = new System.Drawing.Size(368, 28);
            this.lblMEnupnl.TabIndex = 5;
            this.lblMEnupnl.Text = "Magic Maths: MiniGame Selector";
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
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(123, 25);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(453, 32);
            this.lblSelect.TabIndex = 47;
            this.lblSelect.Text = "Welcome, Please Select a Mini Game";
            // 
            // lblTrollBattle
            // 
            this.lblTrollBattle.AutoSize = true;
            this.lblTrollBattle.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrollBattle.Location = new System.Drawing.Point(123, 381);
            this.lblTrollBattle.Name = "lblTrollBattle";
            this.lblTrollBattle.Size = new System.Drawing.Size(154, 32);
            this.lblTrollBattle.TabIndex = 48;
            this.lblTrollBattle.Text = "Ogre Battle";
            this.lblTrollBattle.Click += new System.EventHandler(this.lblTrollBattle_Click);
            // 
            // lblPotionMaker
            // 
            this.lblPotionMaker.AutoSize = true;
            this.lblPotionMaker.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotionMaker.Location = new System.Drawing.Point(472, 381);
            this.lblPotionMaker.Name = "lblPotionMaker";
            this.lblPotionMaker.Size = new System.Drawing.Size(180, 32);
            this.lblPotionMaker.TabIndex = 49;
            this.lblPotionMaker.Text = "Potion Maker";
            this.lblPotionMaker.Click += new System.EventHandler(this.lblPotionMaker_Click);
            // 
            // pxtPromoteOgre
            // 
            this.pxtPromoteOgre.Image = global::Magic_Maths_Adventure.Properties.Resources.PromotionalPhotoOgre;
            this.pxtPromoteOgre.Location = new System.Drawing.Point(85, 179);
            this.pxtPromoteOgre.Name = "pxtPromoteOgre";
            this.pxtPromoteOgre.Size = new System.Drawing.Size(251, 199);
            this.pxtPromoteOgre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtPromoteOgre.TabIndex = 50;
            this.pxtPromoteOgre.TabStop = false;
            // 
            // pxtHelp
            // 
            this.pxtHelp.Image = global::Magic_Maths_Adventure.Properties.Resources.HelpWizard;
            this.pxtHelp.Location = new System.Drawing.Point(669, -2);
            this.pxtHelp.Name = "pxtHelp";
            this.pxtHelp.Size = new System.Drawing.Size(117, 126);
            this.pxtHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHelp.TabIndex = 46;
            this.pxtHelp.TabStop = false;
            this.pxtHelp.Click += new System.EventHandler(this.pxtHelp_Click);
            // 
            // pxtPotion
            // 
            this.pxtPotion.Image = ((System.Drawing.Image)(resources.GetObject("pxtPotion.Image")));
            this.pxtPotion.Location = new System.Drawing.Point(450, 179);
            this.pxtPotion.Name = "pxtPotion";
            this.pxtPotion.Size = new System.Drawing.Size(251, 199);
            this.pxtPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtPotion.TabIndex = 51;
            this.pxtPotion.TabStop = false;
            // 
            // frmMiniGameSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.pxtPotion);
            this.Controls.Add(this.pxtPromoteOgre);
            this.Controls.Add(this.lblPotionMaker);
            this.Controls.Add(this.lblTrollBattle);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.pxtHelp);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMiniGameSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please Select a Minigame";
            this.Load += new System.EventHandler(this.frmMiniGameSelector_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtPromoteOgre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtPotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pxthome;
        private System.Windows.Forms.Label lblMEnupnl;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox pxtHelp;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblTrollBattle;
        private System.Windows.Forms.PictureBox pxtmusic;
        private System.Windows.Forms.Label lblPotionMaker;
        private System.Windows.Forms.PictureBox pxtPromoteOgre;
        private System.Windows.Forms.PictureBox pxtPotion;
    }
}