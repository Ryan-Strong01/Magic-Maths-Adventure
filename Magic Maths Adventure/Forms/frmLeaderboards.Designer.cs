
namespace Magic_Maths_Adventure.Forms
{
    partial class frmLeaderboards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaderboards));
            this.cmbxLevel = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lstbxTimes = new System.Windows.Forms.ListBox();
            this.pnlBoards = new System.Windows.Forms.Panel();
            this.pxtmusic = new System.Windows.Forms.PictureBox();
            this.pxthome = new System.Windows.Forms.PictureBox();
            this.lblLeader = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblNO1 = new System.Windows.Forms.Label();
            this.pxtChamp = new System.Windows.Forms.PictureBox();
            this.pxtHelp = new System.Windows.Forms.PictureBox();
            this.pnlBoards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtChamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxLevel
            // 
            this.cmbxLevel.BackColor = System.Drawing.Color.White;
            this.cmbxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLevel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbxLevel.FormattingEnabled = true;
            this.cmbxLevel.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3"});
            this.cmbxLevel.Location = new System.Drawing.Point(102, 66);
            this.cmbxLevel.Name = "cmbxLevel";
            this.cmbxLevel.Size = new System.Drawing.Size(386, 33);
            this.cmbxLevel.TabIndex = 2;
            this.cmbxLevel.SelectedIndexChanged += new System.EventHandler(this.cmbxLevel_SelectedIndexChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(12, 66);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(84, 32);
            this.lblLevel.TabIndex = 16;
            this.lblLevel.Text = "Level:";
            // 
            // lstbxTimes
            // 
            this.lstbxTimes.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxTimes.FormattingEnabled = true;
            this.lstbxTimes.ItemHeight = 14;
            this.lstbxTimes.Location = new System.Drawing.Point(254, 186);
            this.lstbxTimes.Name = "lstbxTimes";
            this.lstbxTimes.Size = new System.Drawing.Size(281, 382);
            this.lstbxTimes.TabIndex = 17;
            // 
            // pnlBoards
            // 
            this.pnlBoards.BackColor = System.Drawing.Color.Red;
            this.pnlBoards.Controls.Add(this.pxtmusic);
            this.pnlBoards.Controls.Add(this.pxthome);
            this.pnlBoards.Controls.Add(this.lblLeader);
            this.pnlBoards.Controls.Add(this.lblCoins);
            this.pnlBoards.Location = new System.Drawing.Point(-11, 564);
            this.pnlBoards.Name = "pnlBoards";
            this.pnlBoards.Size = new System.Drawing.Size(830, 107);
            this.pnlBoards.TabIndex = 35;
            // 
            // pxtmusic
            // 
            this.pxtmusic.Image = global::Magic_Maths_Adventure.Properties.Resources.MusicOn;
            this.pxtmusic.Location = new System.Drawing.Point(700, 3);
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
            this.pxthome.Location = new System.Drawing.Point(596, 0);
            this.pxthome.Name = "pxthome";
            this.pxthome.Size = new System.Drawing.Size(98, 101);
            this.pxthome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxthome.TabIndex = 55;
            this.pxthome.TabStop = false;
            this.pxthome.Click += new System.EventHandler(this.pxthome_Click);
            // 
            // lblLeader
            // 
            this.lblLeader.AutoSize = true;
            this.lblLeader.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLeader.Location = new System.Drawing.Point(23, 32);
            this.lblLeader.Name = "lblLeader";
            this.lblLeader.Size = new System.Drawing.Size(314, 28);
            this.lblLeader.TabIndex = 5;
            this.lblLeader.Text = "Magic Maths: Leaderboards";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoins.Location = new System.Drawing.Point(535, 32);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(25, 28);
            this.lblCoins.TabIndex = 4;
            this.lblCoins.Text = "$";
            // 
            // lblNO1
            // 
            this.lblNO1.AutoSize = true;
            this.lblNO1.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNO1.Location = new System.Drawing.Point(11, 131);
            this.lblNO1.Name = "lblNO1";
            this.lblNO1.Size = new System.Drawing.Size(269, 32);
            this.lblNO1.TabIndex = 36;
            this.lblNO1.Text = "Number 1 Champion:";
            // 
            // pxtChamp
            // 
            this.pxtChamp.Image = global::Magic_Maths_Adventure.Properties.Resources.Crown;
            this.pxtChamp.Location = new System.Drawing.Point(655, 133);
            this.pxtChamp.Name = "pxtChamp";
            this.pxtChamp.Size = new System.Drawing.Size(97, 77);
            this.pxtChamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtChamp.TabIndex = 37;
            this.pxtChamp.TabStop = false;
            // 
            // pxtHelp
            // 
            this.pxtHelp.Image = global::Magic_Maths_Adventure.Properties.Resources.HelpWizard;
            this.pxtHelp.Location = new System.Drawing.Point(669, 1);
            this.pxtHelp.Name = "pxtHelp";
            this.pxtHelp.Size = new System.Drawing.Size(117, 126);
            this.pxtHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHelp.TabIndex = 50;
            this.pxtHelp.TabStop = false;
            this.pxtHelp.Click += new System.EventHandler(this.pxtHelp_Click);
            // 
            // frmLeaderboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.pxtHelp);
            this.Controls.Add(this.pxtChamp);
            this.Controls.Add(this.lblNO1);
            this.Controls.Add(this.pnlBoards);
            this.Controls.Add(this.lstbxTimes);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.cmbxLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLeaderboards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the Leaderboards";
            this.Load += new System.EventHandler(this.frmLeaderboards_Load);
            this.pnlBoards.ResumeLayout(false);
            this.pnlBoards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtChamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ListBox lstbxTimes;
        private System.Windows.Forms.Panel pnlBoards;
        private System.Windows.Forms.Label lblLeader;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label lblNO1;
        private System.Windows.Forms.PictureBox pxtChamp;
        private System.Windows.Forms.PictureBox pxtHelp;
        private System.Windows.Forms.PictureBox pxthome;
        private System.Windows.Forms.PictureBox pxtmusic;
    }
}