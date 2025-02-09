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
    public partial class frmPotionMaker : Form
    {
        public frmPotionMaker()
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;
        }

        public List<Label> labelanswers = new List<Label>();
        string answer = "";
        public static void GenQ(Label lbl, List<Label> lbls, out string correct)
        {
            Random ran = new Random();
            int question = ran.Next(0, Classes.MiniGames.Questions.Count);

            string[] split = Classes.MiniGames.Questions[question].Split('-');//splitting the question so you can get all relevant info

            lbl.Text = split[1];
            string[] answers = { split[2], split[3], split[4] };

            List<string> answerlist = answers.ToList();//so you can take the count
            correct = answerlist[0];


            for (int s = 0; s < 3; s++)
            {
                int possibleAnswer = ran.Next(answerlist.Count);
                lbls[s].Text = answerlist[possibleAnswer];
                answerlist.RemoveAt(possibleAnswer);
            }
            Classes.MiniGames.Questions.RemoveAt(question);
        }

        SoundPlayer player = new SoundPlayer("MagicMathsMusic.wav");
        private void frmPotionMaker_Load(object sender, EventArgs e)
        {
            Classes.Methods.CreateAvatar(pxtav);
            labelanswers.Clear();//clearing list so it doesn't end up re adding the same labels over and over
            labelanswers.Add(lblOption1);
            labelanswers.Add(lblOption2);
            labelanswers.Add(lblOption3);

            Classes.MiniGames.Questions.Clear();//clearing list
            try
            {
                using (StreamReader read = new StreamReader("MiniGamesQs.txt"))
                {
                    string sentence;
                    while ((sentence = read.ReadLine()) != null)
                    {
                        if (sentence.Contains("POTIONMAKER"))
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
                    break;
                case "Earth":
                    pnlMenu.BackColor = Color.Green;
                    break;
                case "Fire":
                    pnlMenu.BackColor = Color.Red;
                    break;
            }

            GenQ(lblQuestion, labelanswers, out answer);
        }

        private void lblOption1_Click(object sender, EventArgs e)
        {
            Label clickedlabel = (Label)sender;

            if(clickedlabel.Text == answer)
            {
                frmMessageBox t = new frmMessageBox("Well done, you got it right!", "Well done: You answered correctly", 2, "");
                t.ShowDialog();

                pgrsbrGoal.Value += 10;
                if(pgrsbrGoal.Value == 50)
                {
                    frmMessageBox jump = new frmMessageBox("Keep Going, You're Halfway there!", "Well done: You have gone so far", 2, "");
                    jump.ShowDialog();
                    pxtPotion.Image = Properties.Resources.HorizontalPotion;
                }
                else if(pgrsbrGoal.Value == 90)
                {
                    frmMessageBox jump = new frmMessageBox("Keep Going, You're so close!", "Keep going: Your doing Great", 2, "");
                    jump.ShowDialog();
                    pxtcauldronEmpty.Image = Properties.Resources.CauldronFilled;
                }

                if(pgrsbrGoal.Value == 100)
                {
                    frmMessageBox jump = new frmMessageBox("Congrats you Made a Potion!", "Well done: You Won", 2, "");
                    jump.ShowDialog();

                    Classes.Methods.PlayerRightNow.COINS += 2;
                    for (int x = 0; x < Classes.Methods.players.Count; x++)
                    {
                        if (Classes.Methods.players[x].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                        {
                            Classes.Methods.players[x] = Classes.Methods.PlayerRightNow;
                        }
                    }
                    Classes.Methods.Serialise();

                    frmMenu go = new frmMenu();
                    this.Hide();
                    go.Show();
                }
                GenQ(lblQuestion, labelanswers, out answer);
            }
            else
            {
                frmMessageBox jump = new frmMessageBox("You Messed Up the Potion: It's ruined!", "Sorry, you Lost", 2, "");
                jump.ShowDialog();

                frmMenu go = new frmMenu();
                this.Hide();
                go.Show();
                GenQ(lblQuestion, labelanswers, out answer);
            }
        }

        private void pxthome_Click(object sender, EventArgs e)
        {
            frmMenu jump = new frmMenu();
            this.Hide();
            jump.Show();
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

        private void pxtHelp_Click(object sender, EventArgs e)
        {
            frmHelp go = new frmHelp(17);
            go.ShowDialog();
        }
    }
}
