using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Maths_Adventure.Forms
{
    public partial class frmMessageBox : Form
    {
        int loc;
        string secret;

        public static void serial()
        {
            for (int x = 0; x < Classes.Methods.players.Count; x++)
            {
                if (Classes.Methods.players[x].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                {
                    Classes.Methods.players[x] = Classes.Methods.PlayerRightNow;
                }
            }
            Classes.Methods.Serialise();
        }
        public frmMessageBox(string message, string title, int origin, string hint)
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;

            if (origin == 3)
            {
                lblMessage.Text = "";
                lblMessage.Location = new Point(12, 26);
                this.Text = title;
                loc = origin;
                secret = hint;
                string[] errors = message.Split(',');//during user reg the user will have many errors so I store it as a string and pass it through
                foreach (string error in errors)
                {
                    lblMessage.Text += Environment.NewLine + error;
                }
            }
            else
            {
                lblMessage.Location = new Point(12, 80);
                lblMessage.Text = message;
                this.Text = title;
                loc = origin;
                secret = hint;
            }
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            btnYes.Enabled = false;
            btnYes.Visible = false;
            btnNo.Enabled = false;
            btnNo.Visible = false;
            if (Classes.Methods.PlayerRightNow.Avatar != null)
            {
                string[] AvatarParts = Classes.Methods.PlayerRightNow.Avatar.Split(',');
                switch (AvatarParts[2])
                {
                    case "Water":
                        pnlError.BackColor = Color.Blue;
                        btnYes.BackColor = Color.Blue;
                        btnNo.BackColor = Color.Blue;
                        break;
                    case "Earth":
                        pnlError.BackColor = Color.Green;
                        btnYes.BackColor = Color.Green;
                        btnNo.BackColor = Color.Green;
                        break;
                    case "Fire":
                        pnlError.BackColor = Color.Red;
                        btnYes.BackColor = Color.Red;
                        btnNo.BackColor = Color.Red;
                        break;
                }
            }

            switch (loc)
            {
                case 1:
                    btnYes.Enabled = true;
                    btnYes.Visible = true;
                    btnNo.Enabled = true;
                    btnNo.Visible = true;
                    break;
                case 2:
                    btnYes.Enabled = true;
                    btnYes.Visible = true;
                    btnYes.Text = "OK";
                    break;
                case 3:
                    btnYes.Enabled = true;
                    btnYes.Visible = true;
                    btnYes.Text = "OK";
                  
                    break;
                case 4:
                    btnYes.Enabled = true;
                    btnYes.Visible = true;
                    btnNo.Enabled = true;
                    btnNo.Visible = true;
                    pxtclose.Visible = false;
                    pxtclose.Enabled = false;
                    break;
                case 5:
                    btnYes.Enabled = true;
                    btnYes.Visible = true;
                    btnNo.Enabled = true;
                    btnNo.Visible = true;
                    pxtclose.Visible = false;
                    pxtclose.Enabled = false;
                    break;
            }
        }

        private void pxtclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            switch (loc)
            {
                case 1:
                    lblMessage.Text = secret;

                    Classes.Methods.PlayerRightNow.HINT = true;

                    for (int x = 0; x < Classes.Methods.players.Count; x++)
                    {
                        if (Classes.Methods.players[x].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                        {
                            Classes.Methods.players[x] = Classes.Methods.PlayerRightNow;
                        }
                    }
                    break;
                case 2:
                    this.Close();
                    break;
                case 3:
                    this.Close();
                    break;
                case 4:
                    switch (Classes.Methods.PlayerRightNow.CURRENTLEVEL)//bringing user back to their prior level after clicking yes
                    {
                        case "AEASY1":
                            Classes.Methods.ReadInQuestions("AEASY1:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 1;
                            serial();
                            frmLevel1 a = new frmLevel1();
                            this.Hide();
                            a.Show();
                            break;
                        case "SEASY1":
                            Classes.Methods.ReadInQuestions("SEASY1:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 2;
                            serial();
                            frmLevel1 b = new frmLevel1();
                            this.Hide();
                            b.Show();
                            break;
                        case "MEASY1":
                            Classes.Methods.ReadInQuestions("MEASY1:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 3;
                            serial();
                            frmLevel1 C = new frmLevel1();
                            this.Hide();
                            C.Show();
                            break;
                        case "DEASY1":
                            Classes.Methods.ReadInQuestions("DEASY1:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 4;
                            serial();
                            frmLevel1 D = new frmLevel1();
                            this.Hide();
                            D.Show();
                            break;
                        case "AMEADIUM1":
                            Classes.Methods.ReadInQuestions("AMEADIUM1:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 5;
                            serial();
                            frmLevel1 E = new frmLevel1();
                            this.Hide();
                            E.Show();
                            break;
                        case "SMEDIUM1":
                            Classes.Methods.ReadInQuestions("SMEDIUM1:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 6;
                            serial();
                            frmLevel1 F = new frmLevel1();
                            this.Hide();
                            F.Show();
                            break;
                        case "MMEDIUM1":
                            Classes.Methods.ReadInQuestions("MMEDIUM1:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 7;
                            serial();
                            frmLevel1 G = new frmLevel1();
                            this.Hide();
                            G.Show();
                            break;
                        case "DMEDIUM1":
                            Classes.Methods.ReadInQuestions("DMEDIUM1:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 8;
                            serial();
                            frmLevel1 H = new frmLevel1();
                            this.Hide();
                            H.Show();
                            break;
                        case "AHARD1":
                            Classes.Methods.ReadInQuestions("AHARD1:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 9;
                            serial();
                            frmLevel1 I = new frmLevel1();
                            this.Hide();
                            I.Show();
                            break;
                        case "SHARD1":
                            Classes.Methods.ReadInQuestions("SHARD1:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 10;
                            serial();
                            frmLevel1 J = new frmLevel1();
                            this.Hide();
                            J.Show();
                            break;
                        case "MHARD1":
                            Classes.Methods.ReadInQuestions("MHARD1:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 11;
                            serial();
                            frmLevel1 K = new frmLevel1();
                            this.Hide();
                            K.Show();
                            break;
                        case "DHARD1":
                            Classes.Methods.ReadInQuestions("DHARD1:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 12;
                            serial();
                            frmLevel1 L = new frmLevel1();
                            this.Hide();
                            L.Show();
                            break;
                        case "AEASY2":
                            Classes.Methods.ReadInQuestions("AEASY2:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 1;
                            serial();
                            frmLevel2 O = new frmLevel2();
                            this.Hide();
                            O.Show();
                            break;
                        case "SEASY2":
                            Classes.Methods.ReadInQuestions("SEASY2:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 2;
                            serial();
                            frmLevel2 M = new frmLevel2();
                            this.Hide();
                            M.Show();
                            break;
                        case "MEASY2":
                            Classes.Methods.ReadInQuestions("MEASY2:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 3;
                            serial();
                            frmLevel2 N = new frmLevel2();
                            this.Hide();
                            N.Show();
                            break;
                        case "DEASY2":
                            Classes.Methods.ReadInQuestions("DEASY2:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 4;
                            serial();
                            frmLevel2 P = new frmLevel2();
                            this.Hide();
                            P.Show();
                            break;
                        case "AMEDIUM2":
                            Classes.Methods.ReadInQuestions("AMEDIUM2:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 5;
                            serial();
                            frmLevel2 Q = new frmLevel2();
                            this.Hide();
                            Q.Show();
                            break;
                        case "SMEDIUM2":
                            Classes.Methods.ReadInQuestions("SMEDIUM2:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 6;
                            serial();
                            frmLevel2 R = new frmLevel2();
                            this.Hide();
                            R.Show();
                            break;
                        case "MMEDIUM2":
                            Classes.Methods.ReadInQuestions("MMEDIUM2:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 7;
                            serial();
                            frmLevel2 S = new frmLevel2();
                            this.Hide();
                            S.Show();
                            break;
                        case "DMEDIUM2":
                            Classes.Methods.ReadInQuestions("DMEDIUM2:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 8;
                            serial();
                            frmLevel2 T = new frmLevel2();
                            this.Hide();
                            T.Show();
                            break;
                        case "AHARD2":
                            Classes.Methods.ReadInQuestions("AHARD2:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 9;
                            serial();
                            frmLevel2 U = new frmLevel2();
                            this.Hide();
                            U.Show();
                            break;
                        case "SHARD2":
                            Classes.Methods.ReadInQuestions("SHARD2:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 10;
                            serial();
                            frmLevel2 V = new frmLevel2();
                            this.Hide();
                            V.Show();
                            break;
                        case "MHARD2":
                            Classes.Methods.ReadInQuestions("MHARD2:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 11;
                            serial();
                            frmLevel2 W = new frmLevel2();
                            this.Hide();
                            W.Show();
                            break;
                        case "DHARD2":
                            Classes.Methods.ReadInQuestions("DHARD2:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 12;
                            serial();
                            frmLevel2 Z = new frmLevel2();
                            this.Hide();
                            Z.Show();
                            break;
                        case "AEASY3":
                            Classes.Methods.ReadInQuestions("AEASY3:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 1;
                            serial();
                            frmLevel3 QW = new frmLevel3();
                            this.Hide();
                            QW.Show();
                            break;
                        case "SEASY3":
                            Classes.Methods.ReadInQuestions("SEASY3:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 2;
                            serial();
                            frmLevel3 QE = new frmLevel3();
                            this.Hide();
                            QE.Show();
                            break;
                        case "MEASY3":
                            Classes.Methods.ReadInQuestions("MEASY3:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 3;
                            serial();
                            frmLevel3 QR = new frmLevel3();
                            this.Hide();
                            QR.Show();
                            break;
                        case "DEASY3":
                            Classes.Methods.ReadInQuestions("AEASY3:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 4;
                            serial();
                            frmLevel3 QT = new frmLevel3();
                            this.Hide();
                            QT.Show();
                            break;
                        case "AMEDIUM3":
                            Classes.Methods.ReadInQuestions("AMEDIUM3:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 5;
                            serial();
                            frmLevel3 QY = new frmLevel3();
                            this.Hide();
                            QY.Show();
                            break;
                        case "SMEDIUM3":
                            Classes.Methods.ReadInQuestions("SMEDIUM3:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 6;
                            serial();
                            frmLevel3 QU = new frmLevel3();
                            this.Hide();
                            QU.Show();
                            break;
                        case "MMEDIUM3":
                            Classes.Methods.ReadInQuestions("MMEDIUM3:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 7;
                            serial();
                            frmLevel3 QI = new frmLevel3();
                            this.Hide();
                            QI.Show();
                            break;
                        case "DMEDIUM3":
                            Classes.Methods.ReadInQuestions("DMEDIUM3:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 8;
                            serial();
                            frmLevel3 QO = new frmLevel3();
                            this.Hide();
                            QO.Show();
                            break;
                        case "AHARD3":
                            Classes.Methods.ReadInQuestions("AHARD3:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 9;
                            serial();
                            frmLevel3 QP = new frmLevel3();
                            this.Hide();
                            QP.Show();
                            break;
                        case "SHARD3":
                            Classes.Methods.ReadInQuestions("SHARD3:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 10;
                            serial();
                            frmLevel3 QA = new frmLevel3();
                            this.Hide();
                            QA.Show();
                            break;
                        case "MHARD3":
                            Classes.Methods.ReadInQuestions("MHARD3:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 11;
                            serial();
                            frmLevel3 QS = new frmLevel3();
                            this.Hide();
                            QS.Show();
                            break;
                        case "DHARD3":
                            Classes.Methods.ReadInQuestions("DHARD3:");
                            Classes.Methods.PlayerRightNow.DIFFICULTY = 12;
                            serial();
                            frmLevel3 QD = new frmLevel3();
                            this.Hide();
                            QD.Show();
                            break;
                    }
                    break;
                case 5:
                    this.Hide();
                    frmVideo jum = new frmVideo();
                    jum.ShowDialog();
                    break;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            switch (loc)
            {
                case 1:
                    this.Hide();
                    break;
                case 4:
                    frmDifficulty jump = new frmDifficulty();
                    this.Hide();
                    jump.Show();
                    break;
                case 5:
                    this.Hide();
                    break;
            }
        }
    }
}
