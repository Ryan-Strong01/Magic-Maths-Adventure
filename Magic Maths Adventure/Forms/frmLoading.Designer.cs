
namespace Magic_Maths_Adventure.Forms
{
    partial class frmLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            this.pnlSplash = new System.Windows.Forms.Panel();
            this.pxtWizard = new System.Windows.Forms.PictureBox();
            this.pxtstar = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProducedby = new System.Windows.Forms.Label();
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.tmrElse = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pxtWizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtstar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSplash
            // 
            this.pnlSplash.AutoScroll = true;
            this.pnlSplash.BackColor = System.Drawing.Color.Red;
            this.pnlSplash.Location = new System.Drawing.Point(1, 578);
            this.pnlSplash.Name = "pnlSplash";
            this.pnlSplash.Size = new System.Drawing.Size(785, 87);
            this.pnlSplash.TabIndex = 5;
            // 
            // pxtWizard
            // 
            this.pxtWizard.BackColor = System.Drawing.Color.Transparent;
            this.pxtWizard.Image = global::Magic_Maths_Adventure.Properties.Resources.GoodWizard1;
            this.pxtWizard.Location = new System.Drawing.Point(1, 113);
            this.pxtWizard.Name = "pxtWizard";
            this.pxtWizard.Size = new System.Drawing.Size(342, 459);
            this.pxtWizard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxtWizard.TabIndex = 6;
            this.pxtWizard.TabStop = false;
            // 
            // pxtstar
            // 
            this.pxtstar.Image = global::Magic_Maths_Adventure.Properties.Resources.star;
            this.pxtstar.Location = new System.Drawing.Point(349, 99);
            this.pxtstar.Name = "pxtstar";
            this.pxtstar.Size = new System.Drawing.Size(74, 60);
            this.pxtstar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtstar.TabIndex = 7;
            this.pxtstar.TabStop = false;
            this.pxtstar.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(423, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 57);
            this.lblTitle.TabIndex = 8;
            // 
            // lblProducedby
            // 
            this.lblProducedby.AutoSize = true;
            this.lblProducedby.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducedby.Location = new System.Drawing.Point(423, 99);
            this.lblProducedby.Name = "lblProducedby";
            this.lblProducedby.Size = new System.Drawing.Size(0, 22);
            this.lblProducedby.TabIndex = 9;
            // 
            // tmrLoad
            // 
            this.tmrLoad.Enabled = true;
            this.tmrLoad.Interval = 1000;
            this.tmrLoad.Tick += new System.EventHandler(this.tmrLoad_Tick);
            // 
            // tmrElse
            // 
            this.tmrElse.Enabled = true;
            this.tmrElse.Interval = 50;
            this.tmrElse.Tick += new System.EventHandler(this.tmrElse_Tick);
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lblProducedby);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pxtstar);
            this.Controls.Add(this.pxtWizard);
            this.Controls.Add(this.pnlSplash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.Load += new System.EventHandler(this.frmLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxtWizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtstar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSplash;
        private System.Windows.Forms.PictureBox pxtWizard;
        private System.Windows.Forms.PictureBox pxtstar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProducedby;
        private System.Windows.Forms.Timer tmrLoad;
        private System.Windows.Forms.Timer tmrElse;
    }
}