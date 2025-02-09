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
    public partial class frmDifficulty : Form
    {
        public frmDifficulty()
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;

            cmbxMode.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public static void serial()//method to let me update current user object quickly without issue
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

        SoundPlayer player = new SoundPlayer("MagicMathsMusic.wav");
        private void frmDifficulty_Load(object sender, EventArgs e)
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

            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS.ToString();
            string[] AvatarParts = Classes.Methods.PlayerRightNow.Avatar.Split(',');

            switch (AvatarParts[2])//changing colour scheme based off magic type
            {
                case "Water":
                    btnEasy.BackColor = Color.Blue;
                    btnMedium.BackColor = Color.Blue;
                    btnHard.BackColor = Color.Blue;
                    pnlDifficultyDesign.BackColor = Color.Blue;
                    cmbxMode.BackColor = Color.Blue;
                    break;
                case "Earth":
                    btnEasy.BackColor = Color.Green;
                    btnMedium.BackColor = Color.Green;
                    btnHard.BackColor = Color.Green;
                    pnlDifficultyDesign.BackColor = Color.Green;
                    cmbxMode.BackColor = Color.Green;
                    break;
                case "Fire":
                    btnEasy.BackColor = Color.Red;
                    btnMedium.BackColor = Color.Red;
                    btnHard.BackColor = Color.Red;
                    pnlDifficultyDesign.BackColor = Color.Red;
                    cmbxMode.BackColor = Color.Red;
                    break;
            }
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrWhiteSpace(cmbxMode.Text))
            {
                player.Stop();//stopping music so it doesn't overlay video
                frmMessageBox jum = new frmMessageBox("Would you like to view a tutorial before beginning?", "Optional tutorial available", 5, "");
                jum.ShowDialog();
            }

            switch (button.Tag.ToString())
            {
                case "EASY":
                    if (!string.IsNullOrWhiteSpace(cmbxMode.Text))
                    {
                        switch (cmbxMode.Text)
                        {
                            case "Addition":
                                Classes.Methods.PlayerRightNow.DIFFICULTY = 1;
                                Classes.Methods.PlayerRightNow.CURRENTLEVEL = "AEASY1";//reading in questions you will want
                                serial();

                                Classes.Methods.ReadInQuestions("AEASY1:");

                                frmLevel1 a = new frmLevel1();
                                this.Hide();
                                a.Show();
                                break;
                            case "Subtraction":
                                Classes.Methods.PlayerRightNow.DIFFICULTY = 2;
                                Classes.Methods.PlayerRightNow.CURRENTLEVEL = "SEASY1";
                                serial();
                                Classes.Methods.ReadInQuestions("SEASY1:");

                                frmLevel1 b = new frmLevel1();
                                this.Hide();
                                b.Show();
                                break;
                            case "Multiplication":
                                Classes.Methods.PlayerRightNow.DIFFICULTY = 3;
                                Classes.Methods.PlayerRightNow.CURRENTLEVEL = "MEASY1";
                                serial();
                                Classes.Methods.ReadInQuestions("MEASY1:");

                                frmLevel1 c = new frmLevel1();
                                this.Hide();
                                c.Show();
                                break;
                            case "Division":
                                Classes.Methods.PlayerRightNow.DIFFICULTY = 4;
                                Classes.Methods.PlayerRightNow.CURRENTLEVEL = "MEASY1";
                                serial();
                                Classes.Methods.ReadInQuestions("DEASY1:");

                                frmLevel1 d = new frmLevel1();
                                this.Hide();
                                d.Show();
                                break;
                        }
                    }
                    else
                    {
                        frmMessageBox jump = new frmMessageBox("Please select a question type.", "EEROR!", 2, "");
                        jump.ShowDialog();
                    }
                    break;
                case "MEDIUM":
                    if (!string.IsNullOrWhiteSpace(cmbxMode.Text))
                    {
                        switch (cmbxMode.Text)
                        {
                            case "Addition":
                                Classes.Methods.PlayerRightNow.DIFFICULTY = 5;
                                Classes.Methods.PlayerRightNow.CURRENTLEVEL = "AMEADIUM1";
                                serial();
                                Classes.Methods.ReadInQuestions("AMEADIUM1:");

                                frmLevel1 a = new frmLevel1();
                                this.Hide();
                                a.Show();
                                break;
                            case "Subtraction":
                                Classes.Methods.PlayerRightNow.DIFFICULTY = 6;
                                Classes.Methods.PlayerRightNow.CURRENTLEVEL = "SMEDIUM1";
                                serial();
                                Classes.Methods.ReadInQuestions("SMEDIUM1:");

                                frmLevel1 b = new frmLevel1();
                                this.Hide();
                                b.Show();
                                break;
                            case "Multiplication":
                                Classes.Methods.PlayerRightNow.DIFFICULTY = 7;
                                Classes.Methods.PlayerRightNow.CURRENTLEVEL = "MMEDIUM1";
                                serial();
                                Classes.Methods.ReadInQuestions("MMEDIUM1:");

                                frmLevel1 c = new frmLevel1();
                                this.Hide();
                                c.Show();
                                break;
                            case "Division":
                                Classes.Methods.PlayerRightNow.DIFFICULTY = 8;
                                Classes.Methods.PlayerRightNow.CURRENTLEVEL = "DMEDIUM1";
                                serial();
                                Classes.Methods.ReadInQuestions("DMEDIUM1:");

                                frmLevel1 d = new frmLevel1();
                                this.Hide();
                                d.Show();
                                break;
                        }
                    }
                    else
                    {
                        frmMessageBox jump = new frmMessageBox("Please select a question type.", "EEROR!", 2, "");
                        jump.ShowDialog();
                    }
                    break;
                case "HARD":
                    if (!string.IsNullOrWhiteSpace(cmbxMode.Text))
                    {
                        switch (cmbxMode.Text)
                        {
                            case "Addition":
                                Classes.Methods.PlayerRightNow.DIFFICULTY = 9;
                                Classes.Methods.PlayerRightNow.CURRENTLEVEL = "AHARD1";
                                serial();
                                Classes.Methods.ReadInQuestions("AHARD1:");

                                frmLevel1 a = new frmLevel1();
                                this.Hide();
                                a.Show();
                                break;
                            case "Subtraction":
                                Classes.Methods.PlayerRightNow.DIFFICULTY = 10;
                                Classes.Methods.PlayerRightNow.CURRENTLEVEL = "SHARD1";
                                serial();
                                Classes.Methods.ReadInQuestions("SHARD1:");

                                frmLevel1 b = new frmLevel1();
                                this.Hide();
                                b.Show();
                                break;
                            case "Multiplication":
                                Classes.Methods.PlayerRightNow.DIFFICULTY = 11;
                                Classes.Methods.PlayerRightNow.CURRENTLEVEL = "MHARD1";
                                serial();
                                Classes.Methods.ReadInQuestions("MHARD1:");

                                frmLevel1 c = new frmLevel1();
                                this.Hide();
                                c.Show();
                                break;
                            case "Division":
                                Classes.Methods.PlayerRightNow.DIFFICULTY = 12;
                                Classes.Methods.PlayerRightNow.CURRENTLEVEL = "DHARD1";
                                serial();
                                Classes.Methods.ReadInQuestions("DHARD1:");

                                frmLevel1 d = new frmLevel1();
                                this.Hide();
                                d.Show();
                                break;
                        }
                    }
                    else
                    {
                        frmMessageBox jump = new frmMessageBox("Please select a question type.", "EEROR!", 2, "");
                        jump.ShowDialog();
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

        private void pxtHelp_Click(object sender, EventArgs e)
        {
            frmHelp jump = new frmHelp(6);
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
