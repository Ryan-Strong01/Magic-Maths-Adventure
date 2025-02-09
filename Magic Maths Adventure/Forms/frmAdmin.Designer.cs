namespace Magic_Maths_Adventure.Forms
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.pnlEnterCode = new System.Windows.Forms.Panel();
            this.pxtHelpCode = new System.Windows.Forms.PictureBox();
            this.mskedtxtCode = new System.Windows.Forms.MaskedTextBox();
            this.btnTry = new System.Windows.Forms.Button();
            this.lblEnterCode = new System.Windows.Forms.Label();
            this.pnlCodeDesign = new System.Windows.Forms.Panel();
            this.pxtmusic1 = new System.Windows.Forms.PictureBox();
            this.lbladmincode = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.pxthome = new System.Windows.Forms.PictureBox();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mskdtxtansw3 = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtansw2 = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtansw1 = new System.Windows.Forms.MaskedTextBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cmbxTopics = new System.Windows.Forms.ComboBox();
            this.txthint = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lstbxQs = new System.Windows.Forms.ListBox();
            this.cmbxDiff = new System.Windows.Forms.ComboBox();
            this.cmbxLevel = new System.Windows.Forms.ComboBox();
            this.pnlAdminDesign = new System.Windows.Forms.Panel();
            this.pxtmusic2 = new System.Windows.Forms.PictureBox();
            this.lbladmin = new System.Windows.Forms.Label();
            this.lblcoins1 = new System.Windows.Forms.Label();
            this.pxtHome1 = new System.Windows.Forms.PictureBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWrong1 = new System.Windows.Forms.Label();
            this.lblWrong2 = new System.Windows.Forms.Label();
            this.pnlEnterCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelpCode)).BeginInit();
            this.pnlCodeDesign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAdminDesign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHome1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEnterCode
            // 
            this.pnlEnterCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlEnterCode.Controls.Add(this.pxtHelpCode);
            this.pnlEnterCode.Controls.Add(this.mskedtxtCode);
            this.pnlEnterCode.Controls.Add(this.btnTry);
            this.pnlEnterCode.Controls.Add(this.lblEnterCode);
            this.pnlEnterCode.Controls.Add(this.pnlCodeDesign);
            this.pnlEnterCode.Location = new System.Drawing.Point(2, 5);
            this.pnlEnterCode.Name = "pnlEnterCode";
            this.pnlEnterCode.Size = new System.Drawing.Size(771, 668);
            this.pnlEnterCode.TabIndex = 3;
            // 
            // pxtHelpCode
            // 
            this.pxtHelpCode.Image = global::Magic_Maths_Adventure.Properties.Resources.HelpWizard;
            this.pxtHelpCode.Location = new System.Drawing.Point(651, 3);
            this.pxtHelpCode.Name = "pxtHelpCode";
            this.pxtHelpCode.Size = new System.Drawing.Size(117, 126);
            this.pxtHelpCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHelpCode.TabIndex = 51;
            this.pxtHelpCode.TabStop = false;
            this.pxtHelpCode.Click += new System.EventHandler(this.pxtHelpCode_Click);
            // 
            // mskedtxtCode
            // 
            this.mskedtxtCode.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskedtxtCode.Location = new System.Drawing.Point(241, 221);
            this.mskedtxtCode.Mask = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "000000000000000000000000";
            this.mskedtxtCode.Name = "mskedtxtCode";
            this.mskedtxtCode.PasswordChar = '●';
            this.mskedtxtCode.Size = new System.Drawing.Size(289, 36);
            this.mskedtxtCode.TabIndex = 25;
            // 
            // btnTry
            // 
            this.btnTry.BackColor = System.Drawing.Color.Red;
            this.btnTry.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTry.Location = new System.Drawing.Point(298, 293);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(175, 82);
            this.btnTry.TabIndex = 24;
            this.btnTry.Text = "Enter Access Code";
            this.btnTry.UseVisualStyleBackColor = false;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // lblEnterCode
            // 
            this.lblEnterCode.AutoSize = true;
            this.lblEnterCode.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCode.Location = new System.Drawing.Point(168, 125);
            this.lblEnterCode.Name = "lblEnterCode";
            this.lblEnterCode.Size = new System.Drawing.Size(449, 32);
            this.lblEnterCode.TabIndex = 18;
            this.lblEnterCode.Text = "Please Enter the Admin Access Code:";
            // 
            // pnlCodeDesign
            // 
            this.pnlCodeDesign.AutoScroll = true;
            this.pnlCodeDesign.BackColor = System.Drawing.Color.Red;
            this.pnlCodeDesign.Controls.Add(this.pxtmusic1);
            this.pnlCodeDesign.Controls.Add(this.lbladmincode);
            this.pnlCodeDesign.Controls.Add(this.lblCoins);
            this.pnlCodeDesign.Controls.Add(this.pxthome);
            this.pnlCodeDesign.Location = new System.Drawing.Point(0, 564);
            this.pnlCodeDesign.Name = "pnlCodeDesign";
            this.pnlCodeDesign.Size = new System.Drawing.Size(811, 107);
            this.pnlCodeDesign.TabIndex = 17;
            // 
            // pxtmusic1
            // 
            this.pxtmusic1.Image = global::Magic_Maths_Adventure.Properties.Resources.MusicOn;
            this.pxtmusic1.Location = new System.Drawing.Point(663, 0);
            this.pxtmusic1.Name = "pxtmusic1";
            this.pxtmusic1.Size = new System.Drawing.Size(97, 82);
            this.pxtmusic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtmusic1.TabIndex = 44;
            this.pxtmusic1.TabStop = false;
            this.pxtmusic1.Click += new System.EventHandler(this.pxtmusic1_Click);
            // 
            // lbladmincode
            // 
            this.lbladmincode.AutoSize = true;
            this.lbladmincode.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmincode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbladmincode.Location = new System.Drawing.Point(10, 28);
            this.lbladmincode.Name = "lbladmincode";
            this.lbladmincode.Size = new System.Drawing.Size(450, 28);
            this.lbladmincode.TabIndex = 6;
            this.lbladmincode.Text = "Magic Maths: Admin Access Code Screen";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoins.Location = new System.Drawing.Point(488, 28);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(25, 28);
            this.lblCoins.TabIndex = 5;
            this.lblCoins.Text = "$";
            // 
            // pxthome
            // 
            this.pxthome.Image = global::Magic_Maths_Adventure.Properties.Resources.Home;
            this.pxthome.Location = new System.Drawing.Point(559, 0);
            this.pxthome.Name = "pxthome";
            this.pxthome.Size = new System.Drawing.Size(98, 101);
            this.pxthome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxthome.TabIndex = 0;
            this.pxthome.TabStop = false;
            this.pxthome.Click += new System.EventHandler(this.pxthome_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAdmin.Controls.Add(this.lblWrong2);
            this.pnlAdmin.Controls.Add(this.lblWrong1);
            this.pnlAdmin.Controls.Add(this.lblCorrect);
            this.pnlAdmin.Controls.Add(this.lblHint);
            this.pnlAdmin.Controls.Add(this.lblQuestion);
            this.pnlAdmin.Controls.Add(this.pictureBox1);
            this.pnlAdmin.Controls.Add(this.btnDelete);
            this.pnlAdmin.Controls.Add(this.btnEdit);
            this.pnlAdmin.Controls.Add(this.btnAdd);
            this.pnlAdmin.Controls.Add(this.mskdtxtansw3);
            this.pnlAdmin.Controls.Add(this.mskdtxtansw2);
            this.pnlAdmin.Controls.Add(this.mskdtxtansw1);
            this.pnlAdmin.Controls.Add(this.lblTopic);
            this.pnlAdmin.Controls.Add(this.lblDiff);
            this.pnlAdmin.Controls.Add(this.lblLevel);
            this.pnlAdmin.Controls.Add(this.cmbxTopics);
            this.pnlAdmin.Controls.Add(this.txthint);
            this.pnlAdmin.Controls.Add(this.txtQuestion);
            this.pnlAdmin.Controls.Add(this.lstbxQs);
            this.pnlAdmin.Controls.Add(this.cmbxDiff);
            this.pnlAdmin.Controls.Add(this.cmbxLevel);
            this.pnlAdmin.Controls.Add(this.pnlAdminDesign);
            this.pnlAdmin.Location = new System.Drawing.Point(801, 2);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(771, 668);
            this.pnlAdmin.TabIndex = 4;
            this.pnlAdmin.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magic_Maths_Adventure.Properties.Resources.HelpWizard;
            this.pictureBox1.Location = new System.Drawing.Point(651, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(16, 515);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 43);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Tag = "DELETE";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Red;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(16, 466);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 43);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Tag = "EDIT";
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(16, 419);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 43);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Tag = "ADD";
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mskdtxtansw3
            // 
            this.mskdtxtansw3.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdtxtansw3.Location = new System.Drawing.Point(566, 508);
            this.mskdtxtansw3.Mask = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "000000000000000000000000";
            this.mskdtxtansw3.Name = "mskdtxtansw3";
            this.mskdtxtansw3.Size = new System.Drawing.Size(189, 30);
            this.mskdtxtansw3.TabIndex = 27;
            // 
            // mskdtxtansw2
            // 
            this.mskdtxtansw2.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdtxtansw2.Location = new System.Drawing.Point(566, 472);
            this.mskdtxtansw2.Mask = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "000000000000000000000000";
            this.mskdtxtansw2.Name = "mskdtxtansw2";
            this.mskdtxtansw2.Size = new System.Drawing.Size(189, 30);
            this.mskdtxtansw2.TabIndex = 28;
            // 
            // mskdtxtansw1
            // 
            this.mskdtxtansw1.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdtxtansw1.Location = new System.Drawing.Point(566, 419);
            this.mskdtxtansw1.Mask = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "000000000000000000000000";
            this.mskdtxtansw1.Name = "mskdtxtansw1";
            this.mskdtxtansw1.Size = new System.Drawing.Size(189, 30);
            this.mskdtxtansw1.TabIndex = 26;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Location = new System.Drawing.Point(10, 370);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(86, 32);
            this.lblTopic.TabIndex = 13;
            this.lblTopic.Text = "Topic:";
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiff.Location = new System.Drawing.Point(10, 326);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(134, 32);
            this.lblDiff.TabIndex = 14;
            this.lblDiff.Text = "Difficulty:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(10, 287);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(84, 32);
            this.lblLevel.TabIndex = 15;
            this.lblLevel.Text = "Level:";
            // 
            // cmbxTopics
            // 
            this.cmbxTopics.BackColor = System.Drawing.Color.White;
            this.cmbxTopics.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTopics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbxTopics.FormattingEnabled = true;
            this.cmbxTopics.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division"});
            this.cmbxTopics.Location = new System.Drawing.Point(160, 373);
            this.cmbxTopics.Name = "cmbxTopics";
            this.cmbxTopics.Size = new System.Drawing.Size(386, 33);
            this.cmbxTopics.TabIndex = 26;
            this.cmbxTopics.SelectedIndexChanged += new System.EventHandler(this.cmbxTopics_SelectedIndexChanged);
            // 
            // txthint
            // 
            this.txthint.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthint.Location = new System.Drawing.Point(262, 455);
            this.txthint.Name = "txthint";
            this.txthint.Size = new System.Drawing.Size(189, 30);
            this.txthint.TabIndex = 21;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(262, 419);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(189, 30);
            this.txtQuestion.TabIndex = 20;
            // 
            // lstbxQs
            // 
            this.lstbxQs.FormattingEnabled = true;
            this.lstbxQs.Location = new System.Drawing.Point(3, 3);
            this.lstbxQs.Name = "lstbxQs";
            this.lstbxQs.Size = new System.Drawing.Size(635, 277);
            this.lstbxQs.TabIndex = 19;
            this.lstbxQs.SelectedIndexChanged += new System.EventHandler(this.lstbxQs_SelectedIndexChanged);
            // 
            // cmbxDiff
            // 
            this.cmbxDiff.BackColor = System.Drawing.Color.White;
            this.cmbxDiff.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxDiff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbxDiff.FormattingEnabled = true;
            this.cmbxDiff.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbxDiff.Location = new System.Drawing.Point(160, 325);
            this.cmbxDiff.Name = "cmbxDiff";
            this.cmbxDiff.Size = new System.Drawing.Size(386, 33);
            this.cmbxDiff.TabIndex = 18;
            this.cmbxDiff.SelectedIndexChanged += new System.EventHandler(this.cmbxDiff_SelectedIndexChanged);
            // 
            // cmbxLevel
            // 
            this.cmbxLevel.BackColor = System.Drawing.Color.White;
            this.cmbxLevel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbxLevel.FormattingEnabled = true;
            this.cmbxLevel.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3"});
            this.cmbxLevel.Location = new System.Drawing.Point(160, 287);
            this.cmbxLevel.Name = "cmbxLevel";
            this.cmbxLevel.Size = new System.Drawing.Size(386, 33);
            this.cmbxLevel.TabIndex = 1;
            this.cmbxLevel.SelectedIndexChanged += new System.EventHandler(this.cmbxLevel_SelectedIndexChanged);
            // 
            // pnlAdminDesign
            // 
            this.pnlAdminDesign.AutoScroll = true;
            this.pnlAdminDesign.BackColor = System.Drawing.Color.Red;
            this.pnlAdminDesign.Controls.Add(this.pxtmusic2);
            this.pnlAdminDesign.Controls.Add(this.lbladmin);
            this.pnlAdminDesign.Controls.Add(this.lblcoins1);
            this.pnlAdminDesign.Controls.Add(this.pxtHome1);
            this.pnlAdminDesign.Location = new System.Drawing.Point(0, 564);
            this.pnlAdminDesign.Name = "pnlAdminDesign";
            this.pnlAdminDesign.Size = new System.Drawing.Size(811, 107);
            this.pnlAdminDesign.TabIndex = 17;
            // 
            // pxtmusic2
            // 
            this.pxtmusic2.Image = global::Magic_Maths_Adventure.Properties.Resources.MusicOn;
            this.pxtmusic2.Location = new System.Drawing.Point(670, 3);
            this.pxtmusic2.Name = "pxtmusic2";
            this.pxtmusic2.Size = new System.Drawing.Size(97, 82);
            this.pxtmusic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtmusic2.TabIndex = 53;
            this.pxtmusic2.TabStop = false;
            this.pxtmusic2.Click += new System.EventHandler(this.pxtmusic2_Click);
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbladmin.Location = new System.Drawing.Point(18, 31);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(312, 28);
            this.lbladmin.TabIndex = 7;
            this.lbladmin.Text = "Magic Maths: Admin Screen";
            // 
            // lblcoins1
            // 
            this.lblcoins1.AutoSize = true;
            this.lblcoins1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoins1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcoins1.Location = new System.Drawing.Point(500, 31);
            this.lblcoins1.Name = "lblcoins1";
            this.lblcoins1.Size = new System.Drawing.Size(25, 28);
            this.lblcoins1.TabIndex = 5;
            this.lblcoins1.Text = "$";
            // 
            // pxtHome1
            // 
            this.pxtHome1.Image = global::Magic_Maths_Adventure.Properties.Resources.Home;
            this.pxtHome1.Location = new System.Drawing.Point(566, 3);
            this.pxtHome1.Name = "pxtHome1";
            this.pxtHome1.Size = new System.Drawing.Size(98, 101);
            this.pxtHome1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtHome1.TabIndex = 5;
            this.pxtHome1.TabStop = false;
            this.pxtHome1.Click += new System.EventHandler(this.pxtHome1_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(199, 419);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(57, 14);
            this.lblQuestion.TabIndex = 53;
            this.lblQuestion.Text = "Question:";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(223, 455);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(33, 14);
            this.lblHint.TabIndex = 54;
            this.lblHint.Text = "Hint:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(470, 419);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(90, 14);
            this.lblCorrect.TabIndex = 55;
            this.lblCorrect.Text = "Correct Answer:";
            // 
            // lblWrong1
            // 
            this.lblWrong1.AutoSize = true;
            this.lblWrong1.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong1.Location = new System.Drawing.Point(470, 472);
            this.lblWrong1.Name = "lblWrong1";
            this.lblWrong1.Size = new System.Drawing.Size(88, 14);
            this.lblWrong1.TabIndex = 56;
            this.lblWrong1.Text = "Wrong Answer:";
            // 
            // lblWrong2
            // 
            this.lblWrong2.AutoSize = true;
            this.lblWrong2.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong2.Location = new System.Drawing.Point(470, 508);
            this.lblWrong2.Name = "lblWrong2";
            this.lblWrong2.Size = new System.Drawing.Size(88, 14);
            this.lblWrong2.TabIndex = 57;
            this.lblWrong2.Text = "Wrong Answer:";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1584, 661);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.pnlEnterCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the Admin Section";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnlEnterCode.ResumeLayout(false);
            this.pnlEnterCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHelpCode)).EndInit();
            this.pnlCodeDesign.ResumeLayout(false);
            this.pnlCodeDesign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxthome)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAdminDesign.ResumeLayout(false);
            this.pnlAdminDesign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtmusic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxtHome1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEnterCode;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.Label lblEnterCode;
        private System.Windows.Forms.Panel pnlCodeDesign;
        private System.Windows.Forms.MaskedTextBox mskedtxtCode;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.TextBox txthint;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.ListBox lstbxQs;
        private System.Windows.Forms.ComboBox cmbxDiff;
        private System.Windows.Forms.ComboBox cmbxLevel;
        private System.Windows.Forms.Panel pnlAdminDesign;
        private System.Windows.Forms.ComboBox cmbxTopics;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.MaskedTextBox mskdtxtansw3;
        private System.Windows.Forms.MaskedTextBox mskdtxtansw2;
        private System.Windows.Forms.MaskedTextBox mskdtxtansw1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pxthome;
        private System.Windows.Forms.PictureBox pxtHome1;
        private System.Windows.Forms.PictureBox pxtHelpCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label lblcoins1;
        private System.Windows.Forms.Label lbladmincode;
        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.PictureBox pxtmusic1;
        private System.Windows.Forms.PictureBox pxtmusic2;
        private System.Windows.Forms.Label lblWrong2;
        private System.Windows.Forms.Label lblWrong1;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblQuestion;
    }
}