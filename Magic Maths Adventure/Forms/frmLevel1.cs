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
    public partial class frmLevel1 : Form
    {
        public frmLevel1()
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;
        }
        public static void GenQ(List<Label> labels, Label q, out string correct, out string hint)
        {
            string question = "";
            string unsplitanswer = "";

            Random rand = new Random();
            int Question = rand.Next(0,Classes.Questions.All.Count);

            string[] RemoveIndicator = Classes.Questions.All[Question].Split(':');
            string[] WholeQuestion = RemoveIndicator[1].Split('/');
            question = WholeQuestion[0];
            unsplitanswer = WholeQuestion[1];
            hint = WholeQuestion[2];

            string[] answers = unsplitanswer.Split('_');
            List<string> answerlist = answers.ToList();//so you can take the count
            correct = answerlist[0];
            

            for (int s = 0; s < 3; s++)
            {
                int possibleAnswer = rand.Next(answerlist.Count);
                labels[s].Text = answerlist[possibleAnswer];
                answerlist.RemoveAt(possibleAnswer);
            }
            q.Text = question;

            Classes.Questions.All.RemoveAt(Question);//removing questions so that don't repeat at that level
        }


        public static List<Label> labels = new List<Label>();

        string rightanswer;
        string hint;
        int health = 3;//user health integer so you can die

        SoundPlayer player = new SoundPlayer("MagicMathsMusic.wav");
        private void frmLevel1_Load(object sender, EventArgs e)
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

            labels.Clear();
            labels.Add(lblOption1);
            labels.Add(lblOption2);
            labels.Add(lblOption3);
                Classes.Methods.PlayerRightNow.LVL1SCORE = 0;
            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS;
            string[] AvatarParts = Classes.Methods.PlayerRightNow.Avatar.Split(',');

            switch (AvatarParts[2])
            {
                case "Water":
                    pnlLevel1.BackColor = Color.Blue;
                    break;
                case "Earth":
                    pnlLevel1.BackColor = Color.Green;
                    break;
                case "Fire":
                    pnlLevel1.BackColor = Color.Red;
                    break;
            }

            pxtAnswerDrop.AllowDrop = true;
            Classes.Methods.CreateAvatar(pxtYourAvatar);

            Classes.Methods.PlayerRightNow.HINT = false;

            for(int x = 0; x < Classes.Methods.players.Count; x++)
            {
                if(Classes.Methods.players[x].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                {
                    Classes.Methods.players[x] = Classes.Methods.PlayerRightNow;
                }
            }

            GenQ(labels, lblQuestion, out rightanswer, out hint);
        }

        private void pxtAnswerDrop_DragDrop(object sender, DragEventArgs e)
        {
            var picture = (PictureBox)sender;
            if (e.Data.GetDataPresent(typeof(Label)))
            {
                var label2drag = (Label)e.Data.GetData(typeof(Label));//getting data of dragged label and turning it into a variable

                if (label2drag.Text == rightanswer)
                {
                    frmMessageBox move = new frmMessageBox("You got it right!", "Great: You got it right! keep going", 2, hint);
                    move.ShowDialog();
                        GenQ(labels, lblQuestion, out rightanswer, out hint);
                    pgrsbrWizard.Value = pgrsbrWizard.Value - 20;

                    if (pgrsbrWizard.Value == 0)
                    {
                        frmMessageBox t = new frmMessageBox("You Killed gorlock!", "Great: You won Level 1! Feel free to try again", 2, hint);
                        t.ShowDialog();

                            Classes.Methods.PlayerRightNow.LVL1SCORE = r;//updating user score to be displayed in leaderboards

                        if (Classes.Methods.PlayerRightNow.HINT == false)//adding coins depending on if you used hints
                        {
                            Classes.Methods.PlayerRightNow.COINS += 5;
                        }
                        else
                        {
                            Classes.Methods.PlayerRightNow.COINS += 3;
                        }

                        for (int x = 0; x < Classes.Methods.players.Count; x++)
                        {
                            if(Classes.Methods.players[x].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                            {
                                Classes.Methods.players[x] = Classes.Methods.PlayerRightNow;
                            }
                        }
                        Classes.Methods.Serialise();

                        frmLevel2 jump = new frmLevel2();
                        this.Hide();
                        jump.Show();
                    }

                }
                else
                {
                    frmMessageBox move = new frmMessageBox("You got it wrong!", "Sorry: You got it wrong! Feel free to try again", 2, hint);
                    move.ShowDialog();
                    health--;

                    switch (health)//seeing what happens when you get one wrong
                    {
                        case 0:
                            pxtHealth3.Image = Properties.Resources.HeartDead;
                            Classes.Methods.PlayerRightNow.LVL1SCORE = r;
                            frmMessageBox jump = new frmMessageBox("You were killed by Gorlock", "Sorry: You died! Feel free to try again", 2, hint);
                            jump.ShowDialog();

                            frmMenu go = new frmMenu();
                            this.Hide();
                            go.Show();
                            break;
                        case 1:
                            pxtHealth2.Image = Properties.Resources.HeartDead;
                            GenQ(labels, lblQuestion, out rightanswer, out hint);
                            break;
                        case 2:
                            pxtHealth1.Image = Properties.Resources.HeartDead;
                            GenQ(labels, lblQuestion, out rightanswer, out hint);
                            break;
                    }
                }

            }
        }

        private void pxtAnswerDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;//dropping effects added to let you move a label into a picturebox
        }

        private void lblOption1_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            label.DoDragDrop(label, DragDropEffects.Move);
        }

        private void pxthome_Click(object sender, EventArgs e)
        {
            frmMenu jump = new frmMenu();
            this.Hide();
            jump.Show();
        }

        int r = 0;
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            r++;
            lbltime.Text = r.ToString();
        }

        private void pxtHint_Click(object sender, EventArgs e)
        {
            if (Classes.Methods.PlayerRightNow.HINT == false)
            {

                    frmMessageBox jump = new frmMessageBox("Would you like a hint?", "WARNING: USAGE OF HINTS REDUCES COINS EARNED", 1 , hint);
                    jump.ShowDialog();
            }
            else
            {
                    frmMessageBox jump = new frmMessageBox(hint, "This is the hint", 2, hint);
                    jump.ShowDialog();
            }
        }

        private void pxtHelp_Click(object sender, EventArgs e)
        {
            frmHelp jump = new frmHelp(7);
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
