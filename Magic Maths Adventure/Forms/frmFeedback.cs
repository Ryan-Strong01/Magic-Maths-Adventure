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
    public partial class frmFeedback : Form
    {
        public frmFeedback()
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;
        }

        SoundPlayer player = new SoundPlayer("MagicMathsMusic.wav");
        private void frmFeedback_Load(object sender, EventArgs e)
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
                    lstbxTips.BackColor = Color.Blue;
                    pnlMenu.BackColor = Color.Blue;
                    break;
                case "Earth":
                    lstbxTips.BackColor = Color.Green;
                    pnlMenu.BackColor = Color.Green;
                    break;
                case "Fire":
                    lstbxTips.BackColor = Color.Red;
                    pnlMenu.BackColor = Color.Red;
                    break;
            }
            if (Classes.Methods.PlayerRightNow.LVL1SCORE != 0)
            {
                lbl1.Text = Classes.Methods.PlayerRightNow.LVL1SCORE.ToString() + " seconds";
            }
            else
            {
                lbl1.Text = "This Level is yet to be completed";
            }

            if (Classes.Methods.PlayerRightNow.LVL2SCORE != 0)
            {
                lbl2.Text = Classes.Methods.PlayerRightNow.LVL2SCORE.ToString() + " seconds";
            }
            else
            {
                lbl2.Text = "This Level is yet to be completed";
            }

            if (Classes.Methods.PlayerRightNow.LVL3SCORE != 0)
            {
                lbl3.Text = Classes.Methods.PlayerRightNow.LVL3SCORE.ToString() + " seconds";
            }
            else
            {
                lbl3.Text = "This Level is yet to be completed";
            }



            if (Classes.Methods.PlayerRightNow.LVL1SCORE != 0)
            {
                if (Classes.Methods.PlayerRightNow.LVL1SCORE > 50)//checking what the scores of the user are
                {
                    lbl1.ForeColor = Color.Red;
                    lbl1.Text += " - This is a poor performance";
                    lstbxTips.Items.Add("Tip for level 1: try doing practice rounds before going for your best score");
                }
                else if (Classes.Methods.PlayerRightNow.LVL1SCORE < 20)
                {
                    lbl1.ForeColor = Color.Green;
                    lbl1.Text += " - This is a great performance";
                    lstbxTips.Items.Add("No tips needed for level 1");
                }
                else
                {
                    lbl1.ForeColor = Color.Orange;
                    lbl1.Text += " - This is an alright performance";
                    lstbxTips.Items.Add("Tip for level 1: create a consistent schedule to practice maths daily");
                }
            }

            if (Classes.Methods.PlayerRightNow.LVL2SCORE != 0)
            {
                if (Classes.Methods.PlayerRightNow.LVL2SCORE > 50)
                {
                    lbl2.ForeColor = Color.Red;
                    lbl2.Text += " - This is a poor performance";
                    lstbxTips.Items.Add("Tip for level 2: use all the resources available to you eg the tutorial");
                }
                else if (Classes.Methods.PlayerRightNow.LVL2SCORE < 20)
                {
                    lbl2.ForeColor = Color.Green;
                    lbl2.Text += " - This is a great performance";
                    lstbxTips.Items.Add("No tips needed for level 2");
                }
                else
                {
                    lbl2.ForeColor = Color.Orange;
                    lbl2.Text += " - This is an alright performance";
                    lstbxTips.Items.Add("Tip for level 2: Use other online resources (like corbettmaths)");
                }
            }

            if (Classes.Methods.PlayerRightNow.LVL3SCORE != 0)
            {
                if (Classes.Methods.PlayerRightNow.LVL3SCORE > 50)
                {
                    lbl3.ForeColor = Color.Red;
                    lbl3.Text += " - This is a poor performance";
                    lstbxTips.Items.Add("Tip for level 3: Ask your teacher for advice");
                }
                else if (Classes.Methods.PlayerRightNow.LVL3SCORE < 20)
                {
                    lbl3.ForeColor = Color.Green;
                    lbl3.Text += " - This is a great performance";
                    lstbxTips.Items.Add("No tips needed for level 3");
                }
                else
                {
                    lbl3.ForeColor = Color.Orange;
                    lbl3.Text += " - This is an alright performance";
                    lstbxTips.Items.Add("Tip for level 3: Repetition is the key to success");
                }
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
            frmHelp jump = new frmHelp(14);
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
