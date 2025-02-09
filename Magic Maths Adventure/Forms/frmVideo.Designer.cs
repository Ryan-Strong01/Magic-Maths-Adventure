
namespace Magic_Maths_Adventure.Forms
{
    partial class frmVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVideo));
            this.WMPtutorial = new AxWMPLib.AxWindowsMediaPlayer();
            this.tmrVideoDone = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WMPtutorial)).BeginInit();
            this.SuspendLayout();
            // 
            // WMPtutorial
            // 
            this.WMPtutorial.Enabled = true;
            this.WMPtutorial.Location = new System.Drawing.Point(-1, 55);
            this.WMPtutorial.Name = "WMPtutorial";
            this.WMPtutorial.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPtutorial.OcxState")));
            this.WMPtutorial.Size = new System.Drawing.Size(786, 606);
            this.WMPtutorial.TabIndex = 0;
            // 
            // tmrVideoDone
            // 
            this.tmrVideoDone.Enabled = true;
            this.tmrVideoDone.Interval = 1000;
            this.tmrVideoDone.Tick += new System.EventHandler(this.tmrVideoDone_Tick);
            // 
            // frmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.WMPtutorial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic Maths Tutorial Video";
            this.Load += new System.EventHandler(this.frmVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMPtutorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMPtutorial;
        private System.Windows.Forms.Timer tmrVideoDone;
    }
}