using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Magic_Maths_Adventure.Forms
{
    public partial class frmLevel2 : Form
    {
        public frmLevel2()
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;
        }

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
        public static void GenQ(Label labelQ, out string right)
        {
            Random ran = new Random();
            int question = ran.Next(0,Classes.Questions.All.Count);
            string[] removeIndicator = Classes.Questions.All[question].Split(':');
            string[] questionparts = removeIndicator[1].Split('/');
            string[] answers = questionparts[1].Split('_');
            
            labelQ.Text = questionparts[0];
            right = answers[0];

            Classes.Questions.All.RemoveAt(question);
        }

        SoundPlayer player = new SoundPlayer("MagicMathsMusic.wav");

        string answer = "";
        private void frmLevel2_Load(object sender, EventArgs e)
        {
            if (Classes.Methods.PlayerRightNow.MUSIC == true)
            {
                pxtmusic.Image = Properties.Resources.MusicOn;

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
                pxtmusic.Image = Properties.Resources.MusicOff;
            }

            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS;
            string[] AvatarParts = Classes.Methods.PlayerRightNow.Avatar.Split(',');

            switch (AvatarParts[2])
            {
                case "Water":
                    pnlLevel2.BackColor = Color.Blue;
                    btnAnswer.BackColor = Color.Blue;
                    break;
                case "Earth":
                    pnlLevel2.BackColor = Color.Green;
                    btnAnswer.BackColor = Color.Green;
                    break;
                case "Fire":
                    pnlLevel2.BackColor = Color.Red;
                    btnAnswer.BackColor = Color.Red;
                    break;
            }
                    Classes.Methods.CreateAvatar(pxtYourAvatar);

            switch (Classes.Methods.PlayerRightNow.DIFFICULTY)
            {
                case 1:
                    Classes.Methods.ReadInQuestions("AEASY2:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "AEASY2";
                    serial();
                    break;
                case 2:
                    Classes.Methods.ReadInQuestions("SEASY2:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "SEASY2";
                    serial();
                    break;
                case 3:
                    Classes.Methods.ReadInQuestions("MEASY2:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "MEASY2";
                    serial();
                    break;
                case 4:
                    Classes.Methods.ReadInQuestions("DEASY2:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "DEASY2";
                    serial();
                    break;
                case 5:
                    Classes.Methods.ReadInQuestions("AMEDIUM2:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "AMEDIUM2";
                    serial();
                    break;
                case 6:
                    Classes.Methods.ReadInQuestions("SMEDIUM2:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "SMEDIUM2";
                    serial();
                    break;
                case 7:
                    Classes.Methods.ReadInQuestions("MMEDIUM2:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "MMEDIUM2";
                    serial();
                    break;
                case 8:
                    Classes.Methods.ReadInQuestions("DMEDIUM2:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "DMEDIUM2";
                    serial();
                    break;
                case 9:
                    Classes.Methods.ReadInQuestions("AHARD2:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "AHARD2";
                    serial();
                    break;
                case 10:
                    Classes.Methods.ReadInQuestions("SHARD2:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "SHARD2";
                    serial();
                    break;
                case 11:
                    Classes.Methods.ReadInQuestions("MHARD2:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "MHARD2";
                    serial();
                    break;
                case 12:
                    Classes.Methods.ReadInQuestions("DHARD1:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "DHARD2";
                    serial();
                    break;
            }
            GenQ(lblQuestion,out answer);
        }

        bool chars = false;
        int health = 3;
        private void btnAnswer_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtanswer.Text))
            {
                foreach(char letter in txtanswer.Text)
                {
                    if (char.IsLetter(letter))
                    {
                        chars = true;
                    }
                }

                if (chars == true)//validation to ensure you dont break the system
                {
                    frmMessageBox h = new frmMessageBox("Make sure your answer is only numbers", "You need to add numbers/remove non-numbers", 2, "");
                    h.ShowDialog();
                    chars = false;
                }
                else
                {
                    string response = txtanswer.Text.Replace(" ", "");
                    if (response == answer)
                    {
                        txtanswer.Text = "";
                        pgrsbrVillain.Value += -20;// taking away health from the enemy

                        frmMessageBox h = new frmMessageBox("You got it right!", "Great: You answered correctly! Feel free to try again", 2, "");
                        h.ShowDialog();
                        if (pgrsbrVillain.Value == 0)
                        {

                                Classes.Methods.PlayerRightNow.LVL2SCORE = r;//updating user score to be displayed in leaderboards

                            Classes.Methods.PlayerRightNow.COINS += 5;
                            for (int x = 0; x < Classes.Methods.players.Count; x++)
                            {
                                if (Classes.Methods.players[x].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                                {
                                    Classes.Methods.players[x] = Classes.Methods.PlayerRightNow;
                                }
                            }
                            Classes.Methods.Serialise();

                                frmMessageBox t = new frmMessageBox("You Killed gimli!", "Great: You won Level 2! Feel free to try again", 2, "");
                            t.ShowDialog();

                            frmLevel3 jump = new frmLevel3();
                            this.Hide();
                            jump.Show();
                        }
                        GenQ(lblQuestion, out answer);

                    }
                    else
                    {
                        txtanswer.Text = "";
                        frmMessageBox t = new frmMessageBox("You got it wrong!", "Sorry: You got it wrong! Feel free to try again", 2, "");
                        t.ShowDialog();

                        health--;

                        switch (health)
                        {
                            case 0:
                                pxtHeart3.Image = Properties.Resources.HeartDead;
                                Classes.Methods.PlayerRightNow.LVL2SCORE = r;
                                frmMessageBox m = new frmMessageBox("You were Killed by gimli!", "Sorry: You lost Level 2! Feel free to try again", 2, "");
                                m.ShowDialog();

                                frmMenu jump = new frmMenu();
                                this.Hide();
                                jump.Show();
                                break;
                            case 1:
                                pxtHeart2.Image = Properties.Resources.HeartDead;
                                break;
                            case 2:
                                pxtHealth1.Image = Properties.Resources.HeartDead;
                                break;
                        }

                        GenQ(lblQuestion, out answer);
                    }
                }
            }
            else
            {
                frmMessageBox m = new frmMessageBox("Please enter an answer!", "No answer given", 2, "");
                m.ShowDialog();
            }
        }

        private void pxthome_Click(object sender, EventArgs e)
        {
            frmMenu jump = new frmMenu();
            this.Hide();
            jump.Show();
        }

        private void pxtHint_Click(object sender, EventArgs e)
        {
        }

        int r = 0;
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            r++;
            lbltime.Text = r.ToString();
        }

        private void pxtHelp_Click(object sender, EventArgs e)
        {
            frmHelp jump = new frmHelp(8);
            jump.ShowDialog();
        }

        private void pxtmusic_Click(object sender, EventArgs e)
        {
            if (Classes.Methods.PlayerRightNow.MUSIC == true)
            {
                pxtmusic.Image = Properties.Resources.MusicOff;
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
                pxtmusic.Image = Properties.Resources.MusicOn;

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
