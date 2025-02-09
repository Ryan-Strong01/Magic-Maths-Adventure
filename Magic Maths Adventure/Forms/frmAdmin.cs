using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Magic_Maths_Adventure.Forms
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;

            cmbxDiff.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxTopics.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        SoundPlayer player = new SoundPlayer("MagicMathsMusic.wav");
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            Classes.Admin.QuestionsToEdit.Clear();//clearing the list so you can't make duplicates

            try
            {
                using (StreamReader read = new StreamReader("GameQuestions.txt"))
                {
                    string sentence;
                    while ((sentence = read.ReadLine()) != null)//while loop to go through all textfile values
                    {
                            Classes.Admin.QuestionsToEdit.Add(sentence);//adding in all the questions from the text file
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("An error has occurred reading in the details, for more information - " + error);
            }

            if (Classes.Methods.PlayerRightNow.MUSIC == true)
            {
                pxtmusic1.Image = Properties.Resources.MusicOn;
                pxtmusic2.Image = Properties.Resources.MusicOn;

                try
                {
                    player.Play();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
            else
            {
                pxtmusic1.Image = Properties.Resources.MusicOff;
                pxtmusic2.Image = Properties.Resources.MusicOff;
            }

            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS;
            lblcoins1.Text = "$" + Classes.Methods.PlayerRightNow.COINS;
            string[] AvatarParts = Classes.Methods.PlayerRightNow.Avatar.Split(',');

            switch (AvatarParts[2])
            {
                case "Water":
                    pnlCodeDesign.BackColor = Color.Blue;
                    btnTry.BackColor = Color.Blue;
                    pnlAdminDesign.BackColor = Color.Blue;
                    cmbxDiff.BackColor = Color.Blue;
                    cmbxLevel.BackColor = Color.Blue;
                    cmbxTopics.BackColor = Color.Blue;
                    btnAdd.BackColor = Color.Blue;
                    btnEdit.BackColor = Color.Blue;
                    btnDelete.BackColor = Color.Blue;
                    break;
                case "Earth":
                    pnlCodeDesign.BackColor = Color.Green;
                    btnTry.BackColor = Color.Green;
                    pnlAdminDesign.BackColor = Color.Green;
                    cmbxDiff.BackColor = Color.Green;
                    cmbxLevel.BackColor = Color.Green;
                    cmbxTopics.BackColor = Color.Green;
                    btnAdd.BackColor = Color.Green;
                    btnEdit.BackColor = Color.Green;
                    btnDelete.BackColor = Color.Green;
                    break;
                case "Fire":
                    pnlCodeDesign.BackColor = Color.Red;
                    btnTry.BackColor = Color.Red;
                    pnlAdminDesign.BackColor = Color.Red;
                    cmbxDiff.BackColor = Color.Red;
                    cmbxLevel.BackColor = Color.Red;
                    cmbxTopics.BackColor = Color.Red;
                    btnAdd.BackColor = Color.Red;
                    btnEdit.BackColor = Color.Red;
                    btnDelete.BackColor = Color.Red;
                    break;
            }
        }

        const int AccessCode = 15;//variable is constant so it can't be changed
        private void btnTry_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrWhiteSpace(mskedtxtCode.Text))
                {
                    int EnteredCode = Convert.ToInt32(mskedtxtCode.Text.Replace(" ", ""));
                    if (AccessCode == EnteredCode)
                    {
                        frmMessageBox jump = new frmMessageBox("Correct Access Code Entered", "Welcome System Administrator", 2, "");
                        jump.ShowDialog();
                        pnlAdmin.Visible = true;
                        pnlEnterCode.Location = new Point(801, 2);
                        pnlAdmin.Location = new Point(1, 2);
                        pnlEnterCode.Visible = false;
                    }
                    else
                    {
                    frmMessageBox jump = new frmMessageBox("Incorrect Access Code Entered", "ERROR", 2, "");
                    jump.ShowDialog();
                    mskedtxtCode.Text = "";
                    }
                }
            else
            {
                frmMessageBox jump = new frmMessageBox("Please Enter a value for the Access Code", "ERROR", 2, "");
                jump.ShowDialog();
                mskedtxtCode.Text = "";
            }

        }

        private void cmbxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbxTopics.Text))
            {
                if (!string.IsNullOrWhiteSpace(cmbxDiff.Text))
                {
                    switch (cmbxLevel.Text)
                    {
                        case "Level 1":
                            switch (cmbxDiff.Text)
                            {
                                case "Easy":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L1 Easy Add
                                            lstbxQs.Items.Clear();
                                            foreach(string item in Classes.Admin.QuestionsToEdit)//foreach loop to go through every value
                                            {
                                                if (item.Contains("AEASY1:"))//adding in all the relevant questions to the listbox
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L1 Easy Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SEASY1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L1 Easy Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MEASY1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L1 Easy Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DEASY1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;

                                case "Medium":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L1 Med Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AMEADIUM1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L1 Med Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SMEDIUM1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L1 Med Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MMEDIUM1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L1 Med Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DMEDIUM1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Hard":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L1 Hard Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AHARD1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L1 HARD Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SHARD1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L1 HARD Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MHARD1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L1 HARD Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DHARD1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case "Level 2":
                            switch (cmbxDiff.Text)
                            {
                                case "Easy":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L2 EASY Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AEASY2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L2 EASY Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SEASY2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L2 EASY Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MEASY2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 EASY Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DEASY2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Medium":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L2 MED Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AMEDIUM2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L2 MED Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SMEDIUM2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L2 MED Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MMEDIUM2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 MED Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DMEDIUM2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Hard":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L2 Hard Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AHARD2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L2 HARD Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SHARD2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L2 HARD Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MHARD2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 HARD Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DHARD2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case "Level 3":
                            switch (cmbxDiff.Text)
                            {
                                case "Easy":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L3 EASY Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AEASY3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L3 EASY Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SEASY3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L3 EASY Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MEASY3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L3 EASY Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DEASY3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Medium":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L3 MED Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AMEDIUM3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L3 MED Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SMEDIUM3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L3 MED Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MMEDIUM3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 MED Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DMEDIUM3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Hard":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L3 HARD Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AHARD3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L3 HARD Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SHARD3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L3 HARD Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MHARD3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 HARD Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DHARD3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                }
            }
        }

        private void cmbxDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbxTopics.Text))//checking to see if you have entered in all necessary detail to get questions
            {
                if (!string.IsNullOrWhiteSpace(cmbxLevel.Text))
                {
                    switch (cmbxLevel.Text)
                    {
                        case "Level 1":
                            switch (cmbxDiff.Text)
                            {
                                case "Easy":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L1 Easy Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AEASY1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L1 Easy Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SEASY1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L1 Easy Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MEASY1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L1 Easy Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DEASY1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;

                                case "Medium":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L1 Med Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AMEADIUM1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L1 Med Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SMEDIUM1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L1 Med Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MMEDIUM1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L1 Med Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DMEDIUM1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Hard":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L1 Hard Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AHARD1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L1 HARD Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SHARD1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L1 HARD Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MHARD1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L1 HARD Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DHARD1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case "Level 2":
                            switch (cmbxDiff.Text)
                            {
                                case "Easy":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L2 EASY Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AEASY2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L2 EASY Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SEASY2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L2 EASY Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MEASY2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 EASY Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DEASY2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Medium":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L2 MED Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AMEDIUM2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L2 MED Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SMEDIUM2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L2 MED Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MMEDIUM2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 MED Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DMEDIUM2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Hard":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L2 Hard Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AHARD2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L2 HARD Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SHARD2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L2 HARD Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MHARD2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 HARD Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DHARD2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case "Level 3":
                            switch (cmbxDiff.Text)
                            {
                                case "Easy":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L3 EASY Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AEASY3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L3 EASY Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SEASY3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L3 EASY Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MEASY3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L3 EASY Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DEASY3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Medium":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L3 MED Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AMEDIUM3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L3 MED Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SMEDIUM3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L3 MED Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MMEDIUM3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 MED Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DMEDIUM3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Hard":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L3 HARD Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AHARD3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L3 HARD Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SHARD3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L3 HARD Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MHARD3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 HARD Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DHARD3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                }
            }
        }

        private void cmbxTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbxDiff.Text))
            {
                if (!string.IsNullOrWhiteSpace(cmbxLevel.Text))
                {
                    switch (cmbxLevel.Text)
                    {
                        case "Level 1":
                            switch (cmbxDiff.Text)
                            {
                                case "Easy":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L1 Easy Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AEASY1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L1 Easy Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SEASY1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L1 Easy Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MEASY1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L1 Easy Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DEASY1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;

                                case "Medium":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L1 Med Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AMEADIUM1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L1 Med Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SMEDIUM1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L1 Med Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MMEDIUM1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L1 Med Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DMEDIUM1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Hard":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L1 Hard Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AHARD1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L1 HARD Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SHARD1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L1 HARD Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MHARD1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L1 HARD Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DHARD1:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case "Level 2":
                            switch (cmbxDiff.Text)
                            {
                                case "Easy":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L2 EASY Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AEASY2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L2 EASY Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SEASY2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L2 EASY Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MEASY2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 EASY Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DEASY2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Medium":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L2 MED Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AMEDIUM2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L2 MED Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SMEDIUM2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L2 MED Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MMEDIUM2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 MED Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DMEDIUM2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Hard":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L2 Hard Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AHARD2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L2 HARD Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SHARD2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L2 HARD Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MHARD2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 HARD Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DHARD2:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case "Level 3":
                            switch (cmbxDiff.Text)
                            {
                                case "Easy":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L3 EASY Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AEASY3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L3 EASY Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SEASY3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L3 EASY Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MEASY3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L3 EASY Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DEASY3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Medium":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L3 MED Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AMEDIUM3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L3 MED Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SMEDIUM3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L3 MED Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MMEDIUM3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 MED Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DMEDIUM3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case "Hard":
                                    switch (cmbxTopics.Text)
                                    {
                                        case "Addition"://L3 HARD Add
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("AHARD3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Subtraction"://L3 HARD Subtract
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("SHARD3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Multiplication"://L3 HARD Mult
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("MHARD3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                        case "Division"://L2 HARD Div
                                            lstbxQs.Items.Clear();
                                            foreach (string item in Classes.Admin.QuestionsToEdit)
                                            {
                                                if (item.Contains("DHARD3:"))
                                                {
                                                    lstbxQs.Items.Add(item);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                }
            }
        }
        string indicator;
        string hint;
        string Question;
        string answ1;
        string answ2;
        string answ3;

        private void lstbxQs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string TotalQuestion = lstbxQs.Text;
                string[] remove = TotalQuestion.Split(':');
                string[] splitQ = remove[1].Split('/');
                string[] answers = splitQ[1].Split('_');

                indicator = remove[0];
                Question = splitQ[0];
                answ1 = answers[0];
                answ2 = answers[1];
                answ3 = answers[2];
                hint = splitQ[2];

                txtQuestion.Text = Question;
                txthint.Text = hint;
                mskdtxtansw1.Text = answ1;
                mskdtxtansw2.Text = answ2;
                mskdtxtansw3.Text = answ3;
            }
            catch(Exception error)
            {

            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Tag.ToString())
            {
                case "ADD":
                    if (!string.IsNullOrWhiteSpace(cmbxLevel.Text) && !string.IsNullOrWhiteSpace(cmbxDiff.Text) && !string.IsNullOrWhiteSpace(cmbxTopics.Text))
                    {

                        if (!string.IsNullOrWhiteSpace(txtQuestion.Text) && !string.IsNullOrWhiteSpace(txthint.Text) && !string.IsNullOrWhiteSpace(mskdtxtansw1.Text) && !string.IsNullOrWhiteSpace(mskdtxtansw2.Text) && !string.IsNullOrWhiteSpace(mskdtxtansw3.Text))
                        {
                            string question = txtQuestion.Text.Replace(" ", "");
                            string hint = txthint.Text;
                            string answ1 = mskdtxtansw1.Text.Replace(" ", "");
                            string answ2 = mskdtxtansw2.Text.Replace(" ", "");
                            string answ3 = mskdtxtansw3.Text.Replace(" ", "");

                            if (indicator == null)
                            {
                                string GetIndicator = lstbxQs.Items[1].ToString();
                                string[] Get = GetIndicator.Split(':');
                                indicator = Get[0];
                            }

                            string Checker = indicator + ":" + question + "/" + answ1 + "_" + answ2 + "_" + answ3 + "/" + hint;//making question into necessary structure
                            bool copy = false;
                            for (int y = 0; y < lstbxQs.Items.Count; y++)
                            {
                                if (lstbxQs.Items[y].ToString() == Checker)
                                {
                                    copy = true;//making sure question just isn't a duplicate of an existing question
                                    txtQuestion.Text = "";
                                    txthint.Text = "";
                                    mskdtxtansw1.Text = "";
                                    mskdtxtansw2.Text = "";
                                    mskdtxtansw3.Text = "";
                                    frmMessageBox f = new frmMessageBox("This is a duplicate of an existing question", "Attempted duplication", 2, "");
                                    f.ShowDialog();
                                }
                            }

                            if (copy == false)
                            {
                                txtQuestion.Text = "";
                                txthint.Text = "";
                                mskdtxtansw1.Text = "";
                                mskdtxtansw2.Text = "";
                                mskdtxtansw3.Text = "";

                                lstbxQs.Items.Add(Checker);

                                for (int a = Classes.Admin.QuestionsToEdit.Count - 1; a >= 0; a--)//looping through and removing all questions with indicator
                                {
                                    if (Classes.Admin.QuestionsToEdit[a].Contains(indicator))
                                    {
                                        Classes.Admin.QuestionsToEdit.RemoveAt(a);
                                    }
                                }


                                foreach (string item in lstbxQs.Items)//re adding all the questions using the listbox (including the newly added questions)
                                {
                                    Classes.Admin.QuestionsToEdit.Add(item);
                                }

                                using (StreamWriter WriteTo = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "GameQuestions.txt", false))//writing out to update the textfile
                                {
                                    for (int x = 0; x < Classes.Admin.QuestionsToEdit.Count; x++)// for loop to make sure computer writes everything to text file
                                    {
                                        WriteTo.WriteLine(Classes.Admin.QuestionsToEdit[x]);
                                    }
                                }

                                frmMessageBox f = new frmMessageBox("This question has been added", "Question Added", 2, "");
                                f.ShowDialog();
                            }
                        }
                        else
                        {
                            frmMessageBox f = new frmMessageBox("Please enter text into all textboxes", "Incomplete data entry", 2, "");
                            f.ShowDialog();
                        }
            }
                    else
                    {
                        frmMessageBox f = new frmMessageBox("Please select a topic, level and difficulty", "Details not specified", 2, "");
                        f.ShowDialog();
                    }
                        break;
                case "EDIT":

                    int num = lstbxQs.SelectedIndex;//getting location of question
                    bool dupe = false;
                    if (!string.IsNullOrWhiteSpace(cmbxLevel.Text) && !string.IsNullOrWhiteSpace(cmbxDiff.Text) && !string.IsNullOrWhiteSpace(cmbxTopics.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(txtQuestion.Text) && !string.IsNullOrWhiteSpace(txthint.Text) && !string.IsNullOrWhiteSpace(mskdtxtansw1.Text) && !string.IsNullOrWhiteSpace(mskdtxtansw2.Text) && !string.IsNullOrWhiteSpace(mskdtxtansw3.Text))
                        {

                            string question = txtQuestion.Text.Replace(" ", "");//removing spaces to prevent errors
                            string hint = txthint.Text;
                            string answ1 = mskdtxtansw1.Text.Replace(" ", "");
                            string answ2 = mskdtxtansw2.Text.Replace(" ", "");
                            string answ3 = mskdtxtansw3.Text.Replace(" ", "");

                            if (indicator == null)
                            {
                                string GetIndicator = lstbxQs.Items[3].ToString();
                                string[] Get = GetIndicator.Split(':');
                                indicator = Get[0];
                            }
                            string SELECTED = indicator + ":" + question + "/" + answ1 + "_" + answ2 + "_" + answ3 + "/" + hint;

                            for (int c = 0; c > lstbxQs.Items.Count; c++)
                            {
                                if (SELECTED == lstbxQs.Items[c].ToString())
                                {
                                    dupe = true;
                                    frmMessageBox f = new frmMessageBox("You have edited this question into a duplicate", "Attempted duplication", 2, "");
                                    f.ShowDialog();
                                }
                            }

                            if (!dupe)//making sure you didn't edit it into a duplicate
                            {
                                try
                                {
                                    lstbxQs.Items[num] = SELECTED;
                                    frmMessageBox f = new frmMessageBox("You have successfully edited this question", "Question edited", 2, "");
                                    f.ShowDialog();
                                }
                                catch
                                {
                                    frmMessageBox M = new frmMessageBox("You need to choose a question to edit", "Choose a question", 2, "");
                                    M.ShowDialog();
                                }

                                for (int a = Classes.Admin.QuestionsToEdit.Count - 1; a >= 0; a--)//looping from the end because if you remove a value it will change the indexing of the loop creating errors
                                {
                                    if (Classes.Admin.QuestionsToEdit[a].Contains(indicator))
                                    {
                                        Classes.Admin.QuestionsToEdit.RemoveAt(a);
                                    }
                                }

                                for (int a = 0; a < Classes.Admin.QuestionsToEdit.Count; a++)
                                {
                                    if (Classes.Admin.QuestionsToEdit[a].Contains(indicator))
                                    {
                                        Classes.Admin.QuestionsToEdit.RemoveAt(a);
                                    }
                                }

                                foreach (string item in lstbxQs.Items)
                                {
                                    Classes.Admin.QuestionsToEdit.Add(item);
                                }

                                using (StreamWriter WriteTo = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "GameQuestions.txt", false))
                                {
                                    for (int x = 0; x < Classes.Admin.QuestionsToEdit.Count; x++)// for loop to make sure computer writes everything to text file
                                    {
                                        WriteTo.WriteLine(Classes.Admin.QuestionsToEdit[x]);
                                    }
                                }
                                txtQuestion.Text = "";
                                txthint.Text = "";
                                mskdtxtansw1.Text = "";
                                mskdtxtansw2.Text = "";
                                mskdtxtansw3.Text = "";
                            }
                        }
                        else
                        {
                            frmMessageBox f = new frmMessageBox("Please enter text into all textboxes", "Incomplete data entry", 2, "");
                            f.ShowDialog();
                        }
                    }
                    else
                    {
                        frmMessageBox f = new frmMessageBox("Please select a topic, level and difficulty", "Details not specified", 2, "");
                        f.ShowDialog();
                    }
                    break;
                case "DELETE":
                    if (!string.IsNullOrWhiteSpace(cmbxLevel.Text) && !string.IsNullOrWhiteSpace(cmbxDiff.Text) && !string.IsNullOrWhiteSpace(cmbxTopics.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(txtQuestion.Text) && !string.IsNullOrWhiteSpace(txthint.Text) && !string.IsNullOrWhiteSpace(mskdtxtansw1.Text) && !string.IsNullOrWhiteSpace(mskdtxtansw2.Text) && !string.IsNullOrWhiteSpace(mskdtxtansw3.Text))//making sure you enter values for everything
                        {
                            if (lstbxQs.Items.Count > 10)//making sure you don't delete too many questions
                            {
                                if (indicator == null)
                                {
                                    string GetIndicator = lstbxQs.Items[3].ToString();
                                    string[] Get = GetIndicator.Split(':');
                                    indicator = Get[0];
                                }

                                try
                                {
                                    int numb = lstbxQs.SelectedIndex;
                                    lstbxQs.Items.RemoveAt(numb);
                                    frmMessageBox qa = new frmMessageBox("This question has been removed from the game", "Question deleted", 2, "");
                                    qa.ShowDialog();
                                }
                                catch
                                {
                                    frmMessageBox ja = new frmMessageBox("You need to select a question to remove", "Need to select a question", 2, "");
                                    ja.ShowDialog();
                                }

                                for (int a = Classes.Admin.QuestionsToEdit.Count - 1; a >= 0; a--)
                                {
                                    if (Classes.Admin.QuestionsToEdit[a].Contains(indicator))
                                    {
                                        Classes.Admin.QuestionsToEdit.RemoveAt(a);
                                    }
                                }

                                foreach (string q in lstbxQs.Items)
                                {
                                    Classes.Admin.QuestionsToEdit.Add(q);
                                }

                                using (StreamWriter WriteTo = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "GameQuestions.txt", false))
                                {
                                    for (int x = 0; x < Classes.Admin.QuestionsToEdit.Count; x++)// for loop to make sure computer writes everything to text file
                                    {
                                        WriteTo.WriteLine(Classes.Admin.QuestionsToEdit[x]);
                                    }
                                }

                                txtQuestion.Text = "";
                                txthint.Text = "";
                                mskdtxtansw1.Text = "";
                                mskdtxtansw2.Text = "";
                                mskdtxtansw3.Text = "";
                            }
                            else
                            {
                                frmMessageBox f = new frmMessageBox("You have deleted too many questions", "Too many questions deleted", 2, "");
                                f.ShowDialog();
                            }
                        }
                        else
                        {
                            frmMessageBox f = new frmMessageBox("Please select a question to delete", "No question to delete", 2, "");
                            f.ShowDialog();
                        }
                    }
                    else
                    {
                        frmMessageBox f = new frmMessageBox("Please select a topic, level and difficulty", "Details not specified", 2, "");
                        f.ShowDialog();
                    }
                    break;
            }
        }

        private void pxthome_Click(object sender, EventArgs e)
        {
            frmMenu jump = new frmMenu();
            this.Hide();
            jump.Show();
        }

        private void pxtHome1_Click(object sender, EventArgs e)
        {
            frmMenu jump = new frmMenu();
            this.Hide();
            jump.Show();
        }

        private void pxtHelpCode_Click(object sender, EventArgs e)
        {
            frmHelp jump = new frmHelp(12);
            jump.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmHelp jump = new frmHelp(13);
            jump.ShowDialog();
        }

        private void pxtmusic1_Click(object sender, EventArgs e)
        {
            if (Classes.Methods.PlayerRightNow.MUSIC == true)
            {
                pxtmusic1.Image = Properties.Resources.MusicOff;
                pxtmusic2.Image = Properties.Resources.MusicOff;
                Classes.Methods.PlayerRightNow.MUSIC = false;
                for (int y = 0; y < Classes.Methods.players.Count; y++)
                {
                    if (Classes.Methods.players[y].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                    {
                        Classes.Methods.players[y] = Classes.Methods.PlayerRightNow;
                    }
                }
                Classes.Methods.Serialise();
                player.Stop();
            }
            else
            {
                pxtmusic1.Image = Properties.Resources.MusicOn;
                pxtmusic2.Image = Properties.Resources.MusicOn;

                Classes.Methods.PlayerRightNow.MUSIC = true;
                for (int y = 0; y < Classes.Methods.players.Count; y++)
                {
                    if (Classes.Methods.players[y].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                    {
                        Classes.Methods.players[y] = Classes.Methods.PlayerRightNow;
                    }
                }
                Classes.Methods.Serialise();

                try
                {
                    player.Play();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }

        private void pxtmusic2_Click(object sender, EventArgs e)
        {
            if (Classes.Methods.PlayerRightNow.MUSIC == true)
            {
                pxtmusic2.Image = Properties.Resources.MusicOff;
                Classes.Methods.PlayerRightNow.MUSIC = false;
                for (int y = 0; y < Classes.Methods.players.Count; y++)
                {
                    if (Classes.Methods.players[y].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                    {
                        Classes.Methods.players[y] = Classes.Methods.PlayerRightNow;
                    }
                }
                Classes.Methods.Serialise();
                player.Stop();
            }
            else
            {
                pxtmusic2.Image = Properties.Resources.MusicOn;

                Classes.Methods.PlayerRightNow.MUSIC = true;
                for (int y = 0; y < Classes.Methods.players.Count; y++)
                {
                    if (Classes.Methods.players[y].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                    {
                        Classes.Methods.players[y] = Classes.Methods.PlayerRightNow;
                    }
                }
                Classes.Methods.Serialise();

                try
                {
                    player.Play();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }
    }
}
