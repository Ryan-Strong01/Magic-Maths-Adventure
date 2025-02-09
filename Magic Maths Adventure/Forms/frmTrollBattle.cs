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
    public partial class frmTrollBattle : Form
    {
        public frmTrollBattle()
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;
        }

        string right100; 
        string right10; 
        string right1;
        public static void CreateQ(Label lbl, out string right00, out string right0, out string right)//'out' so i can get data from the method
        {
            Random ran = new Random();
            int question = ran.Next(0,Classes.MiniGames.Questions.Count);
            string[] QUEST = Classes.MiniGames.Questions[question].Split('-');
            lbl.Text = QUEST[1];
            right00 = QUEST[2];
            right0 = QUEST[3];
            right = QUEST[4];

            Classes.MiniGames.Questions.RemoveAt(question);//getting rid of question to prevent duplicates
        }
        SoundPlayer player = new SoundPlayer("MagicMathsMusic.wav");
        private void frmTrollBattle_Load(object sender, EventArgs e)
        {
            Classes.MiniGames.Questions.Clear();
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
                    pnlMenu.BackColor = Color.Blue;
                    btnAnswer.BackColor = Color.Blue;
                    break;
                case "Earth":
                    pnlMenu.BackColor = Color.Green;
                    btnAnswer.BackColor = Color.Green;
                    break;
                case "Fire":
                    pnlMenu.BackColor = Color.Red;
                    btnAnswer.BackColor = Color.Red;
                    break;
            }

            Classes.Methods.CreateAvatar(pxtav);
            try
            {
                using (StreamReader read = new StreamReader("MiniGamesQs.txt"))
                {
                    string sentence;
                    while ((sentence = read.ReadLine()) != null)//reading until the end of the text file
                    {
                        if (sentence.Contains("OGREBATTLE"))
                        {
                            Classes.MiniGames.Questions.Add(sentence);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("An error has occurred reading in the details, for more information - " + error);
            }
            CreateQ(lblQ, out right100, out right10, out right1);
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

        private void pxthome_Click(object sender, EventArgs e)
        {
            frmMenu jump = new frmMenu();
            jump.Show();
            this.Hide();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            string answer00 = "";
            string answer0 = "";
            string answer = "";

            if(!string.IsNullOrWhiteSpace(mskedtxt100s.Text) && !string.IsNullOrWhiteSpace(mskdtxt10s.Text) && !string.IsNullOrWhiteSpace(mskdtxt1s.Text))// AND operators to save time writing out nested ifs
            {
                answer00 = mskedtxt100s.Text.Replace(" ", "");
                answer0 = mskdtxt10s.Text.Replace(" ", "");
                answer = mskdtxt1s.Text.Replace(" ", "");//getting rid of spaces so it won't say its wrong just because it has spaces

                if (answer00 == right100 && answer0 == right10 && answer == right1)
                {
                    frmMessageBox h = new frmMessageBox("You got it right!", "Great: You answered correctly! Feel free to try again", 2, "");
                    h.ShowDialog();

                    mskedtxt100s.Text = "";
                    mskdtxt10s.Text = "";
                    mskdtxt1s.Text = "";

                    pgrsbrWizard.Value += -5;

                    if(pgrsbrWizard.Value == 0)
                    {
                        frmMessageBox u = new frmMessageBox("You beat the troll!", "Great: You won! Feel free to try again", 2, "");
                        u.ShowDialog();

                        Classes.Methods.PlayerRightNow.COINS += 2;
                        for (int x = 0; x < Classes.Methods.players.Count; x++)
                        {
                            if (Classes.Methods.players[x].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                            {
                                Classes.Methods.players[x] = Classes.Methods.PlayerRightNow;
                            }
                        }
                        Classes.Methods.Serialise();

                        frmMenu jump = new frmMenu();
                        jump.Show();
                        this.Hide();
                    }
                    else
                    {
                        CreateQ(lblQ, out right100, out right10, out right1);
                    }
        
                }
                else
                {
                    frmMessageBox h = new frmMessageBox("You got it wrong!", "Sorry: Feel free to try again", 2, "");
                    h.ShowDialog();

                    mskedtxt100s.Text = "";
                    mskdtxt10s.Text = "";
                    mskdtxt1s.Text = "";

                    pgrsbrAv.Value += -50;

                    if(pgrsbrAv.Value == 0)
                    {
                        frmMessageBox n = new frmMessageBox("You Died!", "Sorry: You lost! Feel free to try again", 2, "");
                        n.ShowDialog();

                        frmMenu jump = new frmMenu();
                        jump.Show();
                        this.Hide();
                    }
                    else
                    {
                        CreateQ(lblQ, out right100, out right10, out right1);
                    }
                }
            }
            else
            {
                frmMessageBox h = new frmMessageBox("You need to enter an answer into each text box", "Input valid data", 2, "");
                h.ShowDialog();
            }
        }

        private void pxtHelp_Click(object sender, EventArgs e)
        {
            frmHelp jump = new frmHelp(16);
            jump.ShowDialog();
        }
    }
}
