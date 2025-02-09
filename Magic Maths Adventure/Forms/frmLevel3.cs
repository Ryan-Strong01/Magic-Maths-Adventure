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
    public partial class frmLevel3 : Form
    {
        public frmLevel3()
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
        public static void GenQ(Label lbl, List<Button> btn, out string correct, out string hint)
        {
            Random ran = new Random();
            int question = ran.Next(0,Classes.Questions.All.Count);

            string[] removeIndicator = Classes.Questions.All[question].Split(':');
            string[] Q = removeIndicator[1].Split('/');

            lbl.Text = Q[0];
            string unsplitanswer = Q[1];
            hint = Q[2];

            string[] answers = unsplitanswer.Split('_');
            List<string> answerlist = answers.ToList();//so you can take the count
            correct = answerlist[0];


            for (int s = 0; s < 3; s++)
            {
                int possibleAnswer = ran.Next(answerlist.Count);
                btn[s].Text = answerlist[possibleAnswer];
                answerlist.RemoveAt(possibleAnswer);
            }
            Classes.Questions.All.RemoveAt(question);
        }
        public static List<Button> btns = new List<Button>();

        SoundPlayer player = new SoundPlayer("MagicMathsMusic.wav");
        private void frmLevel3_Load(object sender, EventArgs e)
        {
            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS;
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

            btns.Clear();
            btns.Add(btnAnswer1);
            btns.Add(btnAnswer2);
            btns.Add(btnAnswer3);
            Classes.Methods.CreateAvatar(pxtYourAvatar);
            string[] AvatarParts = Classes.Methods.PlayerRightNow.Avatar.Split(',');

            Classes.Methods.PlayerRightNow.HINT = false;

            for (int x = 0; x < Classes.Methods.players.Count; x++)
            {
                if (Classes.Methods.players[x].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                {
                    Classes.Methods.players[x] = Classes.Methods.PlayerRightNow;
                }
            }

            switch (AvatarParts[2])
            {
                case "Water":
                    pnlLevel3.BackColor = Color.Blue;
                    btnAnswer1.BackColor = Color.Blue;
                    btnAnswer2.BackColor = Color.Blue;
                    btnAnswer3.BackColor = Color.Blue;
                    break;
                case "Earth":
                    pnlLevel3.BackColor = Color.Green;
                    btnAnswer1.BackColor = Color.Green;
                    btnAnswer2.BackColor = Color.Green;
                    btnAnswer3.BackColor = Color.Green;
                    break;
                case "Fire":
                    pnlLevel3.BackColor = Color.Red;
                    btnAnswer1.BackColor = Color.Red;
                    btnAnswer2.BackColor = Color.Red;
                    btnAnswer3.BackColor = Color.Red;
                    break;
            }

            switch (Classes.Methods.PlayerRightNow.DIFFICULTY)
            {
                case 1:
                    Classes.Methods.ReadInQuestions("AEASY3:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "AEASY3";
                    serial();
                    break;
                case 2:
                    Classes.Methods.ReadInQuestions("SEASY3:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "SEASY3";
                    serial();
                    break;
                case 3:
                    Classes.Methods.ReadInQuestions("MEASY3:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "MEASY3";
                    serial();
                    break;
                case 4:
                    Classes.Methods.ReadInQuestions("DEASY3:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "DEASY3";
                    serial();
                    break;
                case 5:
                    Classes.Methods.ReadInQuestions("AMEDIUM3:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "AMEDIUM3";
                    serial();
                    break;
                case 6:
                    Classes.Methods.ReadInQuestions("SMEDIUM3:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "SMEDIUM3";
                    serial();
                    break;
                case 7:
                    Classes.Methods.ReadInQuestions("MMEDIUM3:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "MMEDIUM3";
                    serial();
                    break;
                case 8:
                    Classes.Methods.ReadInQuestions("DMEDIUM3:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "DMEDIUM3";
                    serial();
                    break;
                case 9:
                    Classes.Methods.ReadInQuestions("AHARD3:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "AHARD3";
                    serial();
                    break;
                case 10:
                    Classes.Methods.ReadInQuestions("SHARD3:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "SHARD3";
                    serial();
                    break;
                case 11:
                    Classes.Methods.ReadInQuestions("MHARD3:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "MHARD3";
                    serial();
                    break;
                case 12:
                    Classes.Methods.ReadInQuestions("DHARD3:");
                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "DHARD3";
                    serial();
                    break;
            }
            GenQ(lblQuestion, btns, out Answer, out hint);
        }

        string Answer;
        string hint;
        int health = 3;
        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Text == Answer)
            {
                frmMessageBox jump = new frmMessageBox("You got it correct!", "Well done", 2, "");
                jump.ShowDialog();
                GenQ(lblQuestion, btns, out Answer, out hint);

                pgrsbrVill.Value = pgrsbrVill.Value - 20;
                if(pgrsbrVill.Value == 0)
                {
                    if (Classes.Methods.PlayerRightNow.HINT == false)
                    {
                        Classes.Methods.PlayerRightNow.COINS += 5;
                    }
                    else
                    {
                        Classes.Methods.PlayerRightNow.COINS += 3;//+= so it adds onto your pre existing coins rather than just making it 3
                    }


                        Classes.Methods.PlayerRightNow.LVL3SCORE = r;//updating user score to be displayed in leaderboards

                    Classes.Methods.PlayerRightNow.CURRENTLEVEL = "NONE";
                    for (int x = 0; x < Classes.Methods.players.Count; x++)
                    {
                        if (Classes.Methods.players[x].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                        {
                            Classes.Methods.players[x] = Classes.Methods.PlayerRightNow;
                        }
                    }
                    Classes.Methods.Serialise();    

                        frmMessageBox t = new frmMessageBox("You Killed gargasmel!", "Great: You won Level 3! Feel free to try again", 2, "");
                        t.ShowDialog();

                    frmMenu to = new frmMenu();
                    this.Hide();
                    to.Show();
                    }
            }
            else
            {
                health--;
                frmMessageBox jump = new frmMessageBox("You got it incorrect!", "Sorry", 2, "");
                jump.ShowDialog();
                GenQ(lblQuestion, btns, out Answer, out hint);

                switch (health)
                {
                    case 0:
                        Classes.Methods.PlayerRightNow.CURRENTLEVEL = "NONE";
                        for (int x = 0; x < Classes.Methods.players.Count; x++)
                        {
                            if (Classes.Methods.players[x].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                            {
                                Classes.Methods.players[x] = Classes.Methods.PlayerRightNow;
                            }
                        }
                        Classes.Methods.Serialise();

                        pxtHeart3.Image = Properties.Resources.HeartDead;
                        frmMessageBox m = new frmMessageBox("You were Killed by Gargasmel!", "Sorry: You lost Level 2! Feel free to try again", 2, "");
                        m.ShowDialog();

                        frmMenu go = new frmMenu();
                        this.Hide();
                        go.Show();
                        break;
                    case 1:
                        pxtHeart2.Image = Properties.Resources.HeartDead;
                        break;
                    case 2:
                        pxtHealth1.Image = Properties.Resources.HeartDead;//editing the hearts above your avatar
                        break;
                }
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
            if (Classes.Methods.PlayerRightNow.HINT == false)
            {

                frmMessageBox jump = new frmMessageBox("Would you like a hint?", "WARNING: USAGE OF HINTS REDUCES COINS EARNED", 1, hint);
                jump.ShowDialog();
            }
            else
            {
                frmMessageBox jump = new frmMessageBox(hint, "This is the hint", 2, hint);
                jump.ShowDialog();
            }
        }
        int r = 0;
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            r++;
            lbltime.Text = r.ToString();
        }

        private void pxtHelp_Click(object sender, EventArgs e)
        {
            frmHelp jump = new frmHelp(9);
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
