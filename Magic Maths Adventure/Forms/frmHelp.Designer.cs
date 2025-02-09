namespace Magic_Maths_Adventure.Forms
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.lblAnswer = new System.Windows.Forms.Label();
            this.pnlAnswer = new System.Windows.Forms.Panel();
            this.lblComboxanswers = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.lblMEnupnl = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.cmbxIssues = new System.Windows.Forms.ComboBox();
            this.pnlAnswer.SuspendLayout();
            this.pnlHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(9, 3);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(137, 32);
            this.lblAnswer.TabIndex = 9;
            this.lblAnswer.Text = "lblAnswer";
            // 
            // pnlAnswer
            // 
            this.pnlAnswer.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlAnswer.Controls.Add(this.lblComboxanswers);
            this.pnlAnswer.Controls.Add(this.lblResults);
            this.pnlAnswer.Location = new System.Drawing.Point(6, 345);
            this.pnlAnswer.Name = "pnlAnswer";
            this.pnlAnswer.Size = new System.Drawing.Size(772, 220);
            this.pnlAnswer.TabIndex = 8;
            // 
            // lblComboxanswers
            // 
            this.lblComboxanswers.AutoSize = true;
            this.lblComboxanswers.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboxanswers.ForeColor = System.Drawing.Color.White;
            this.lblComboxanswers.Location = new System.Drawing.Point(3, 25);
            this.lblComboxanswers.Name = "lblComboxanswers";
            this.lblComboxanswers.Size = new System.Drawing.Size(95, 25);
            this.lblComboxanswers.TabIndex = 5;
            this.lblComboxanswers.Text = "ANSWER";
            this.lblComboxanswers.Visible = false;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.White;
            this.lblResults.Location = new System.Drawing.Point(3, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(85, 25);
            this.lblResults.TabIndex = 4;
            this.lblResults.Text = "Results:";
            // 
            // pnlHelp
            // 
            this.pnlHelp.AutoScroll = true;
            this.pnlHelp.BackColor = System.Drawing.Color.Red;
            this.pnlHelp.Controls.Add(this.lblMEnupnl);
            this.pnlHelp.Location = new System.Drawing.Point(-4, 571);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(792, 87);
            this.pnlHelp.TabIndex = 7;
            // 
            // lblMEnupnl
            // 
            this.lblMEnupnl.AutoSize = true;
            this.lblMEnupnl.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMEnupnl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMEnupnl.Location = new System.Drawing.Point(13, 22);
            this.lblMEnupnl.Name = "lblMEnupnl";
            this.lblMEnupnl.Size = new System.Drawing.Size(290, 28);
            this.lblMEnupnl.TabIndex = 10;
            this.lblMEnupnl.Text = "Magic Maths: Help Screen";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.Location = new System.Drawing.Point(1, 296);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(220, 25);
            this.lblOther.TabIndex = 6;
            this.lblOther.Text = "Other Common Issues:";
            // 
            // cmbxIssues
            // 
            this.cmbxIssues.BackColor = System.Drawing.Color.Red;
            this.cmbxIssues.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxIssues.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbxIssues.FormattingEnabled = true;
            this.cmbxIssues.Location = new System.Drawing.Point(226, 296);
            this.cmbxIssues.Name = "cmbxIssues";
            this.cmbxIssues.Size = new System.Drawing.Size(552, 33);
            this.cmbxIssues.TabIndex = 5;
            this.cmbxIssues.SelectedIndexChanged += new System.EventHandler(this.cmbxIssues_SelectedIndexChanged);
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.pnlAnswer);
            this.Controls.Add(this.pnlHelp);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.cmbxIssues);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the Help Form";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.pnlAnswer.ResumeLayout(false);
            this.pnlAnswer.PerformLayout();
            this.pnlHelp.ResumeLayout(false);
            this.pnlHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Panel pnlAnswer;
        private System.Windows.Forms.Label lblComboxanswers;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.ComboBox cmbxIssues;
        private System.Windows.Forms.Label lblMEnupnl;
    }
}