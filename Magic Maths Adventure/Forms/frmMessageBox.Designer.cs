
namespace Magic_Maths_Adventure.Forms
{
    partial class frmMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBox));
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlError = new System.Windows.Forms.Panel();
            this.lblMessengerSystem = new System.Windows.Forms.Label();
            this.pxtclose = new System.Windows.Forms.PictureBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.pnlError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtclose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 80);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(48, 14);
            this.lblMessage.TabIndex = 39;
            this.lblMessage.Text = "WORDS";
            // 
            // pnlError
            // 
            this.pnlError.BackColor = System.Drawing.Color.Red;
            this.pnlError.Controls.Add(this.lblMessengerSystem);
            this.pnlError.Location = new System.Drawing.Point(0, 168);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(405, 58);
            this.pnlError.TabIndex = 40;
            // 
            // lblMessengerSystem
            // 
            this.lblMessengerSystem.AutoSize = true;
            this.lblMessengerSystem.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessengerSystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMessengerSystem.Location = new System.Drawing.Point(3, 10);
            this.lblMessengerSystem.Name = "lblMessengerSystem";
            this.lblMessengerSystem.Size = new System.Drawing.Size(283, 22);
            this.lblMessengerSystem.TabIndex = 41;
            this.lblMessengerSystem.Text = "Magic Maths: Messenger System";
            // 
            // pxtclose
            // 
            this.pxtclose.Image = global::Magic_Maths_Adventure.Properties.Resources.CloseButton;
            this.pxtclose.Location = new System.Drawing.Point(333, 0);
            this.pxtclose.Name = "pxtclose";
            this.pxtclose.Size = new System.Drawing.Size(72, 38);
            this.pxtclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtclose.TabIndex = 41;
            this.pxtclose.TabStop = false;
            this.pxtclose.Click += new System.EventHandler(this.pxtclose_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Red;
            this.btnYes.Enabled = false;
            this.btnYes.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYes.Location = new System.Drawing.Point(42, 119);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(106, 43);
            this.btnYes.TabIndex = 42;
            this.btnYes.Tag = "";
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Red;
            this.btnNo.Enabled = false;
            this.btnNo.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNo.Location = new System.Drawing.Point(259, 119);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(106, 43);
            this.btnNo.TabIndex = 43;
            this.btnNo.Tag = "";
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(400, 219);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.pxtclose);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.lblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessageBox";
            this.Load += new System.EventHandler(this.frmMessageBox_Load);
            this.pnlError.ResumeLayout(false);
            this.pnlError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lblMessengerSystem;
        private System.Windows.Forms.PictureBox pxtclose;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}