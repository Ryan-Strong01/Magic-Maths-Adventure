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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));// creating a new resized bitmap so the cursor won't be huge
            Cursor custom = new Cursor(resizedArrow.GetHicon());//converting cursor image form bitmap to necessary cu file image
            this.Cursor = custom;
        }

        SoundPlayer player = new SoundPlayer("MagicMathsMusic.wav");
        private void frmMenu_Load(object sender, EventArgs e)
        {
            if(Classes.Methods.PlayerRightNow.MUSIC == true)
            {
                pxtmusic.Image = Properties.Resources.MusicOn;

                try//error trapping in case the user doesn't have a music output eg headphones so it doesn't collapse
                {
                    player.Play();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
            else
            {
                pxtmusic.Image = Properties.Resources.MusicOff;
            }

            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS;
            string[] AvatarParts = Classes.Methods.PlayerRightNow.Avatar.Split(',');//getting user's magic type so I can customise form colour scheme to magic type
            switch (AvatarParts[2])
            {
                case "Water":
                    btnAdmin.BackColor = Color.Blue;
                    btnGame.BackColor = Color.Blue;
                    btnLeaderboards.BackColor = Color.Blue;
                    btnMiniGames.BackColor = Color.Blue;
                    btnShop.BackColor = Color.Blue;
                    btnFeedback.BackColor = Color.Blue;
                    pnlMenu.BackColor = Color.Blue;
                    break;
                case "Earth":
                    btnAdmin.BackColor = Color.Green;
                    btnGame.BackColor = Color.Green;
                    btnLeaderboards.BackColor = Color.Green;
                    btnMiniGames.BackColor = Color.Green;
                    btnShop.BackColor = Color.Green;
                    btnFeedback.BackColor = Color.Green;
                    pnlMenu.BackColor = Color.Green;
                    break;
                case "Fire":
                    btnAdmin.BackColor = Color.Red;
                    btnGame.BackColor = Color.Red;
                    btnLeaderboards.BackColor = Color.Red;
                    btnMiniGames.BackColor = Color.Red;
                    btnShop.BackColor = Color.Red;
                    btnFeedback.BackColor = Color.Red;
                    pnlMenu.BackColor = Color.Red;
                    break;
            }
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;// making an object out of the button selected so I can do things based off it's properties ie text

            switch (button.Tag.ToString())
            {
                case "1":
                    if (Classes.Methods.PlayerRightNow.CURRENTLEVEL != "NONE")// checking if the user left in the middle of a game
                    {
                        frmMessageBox jump = new frmMessageBox("You quit in the middle of a game, would you like to return?", "UNCOMPLETED GAME", 4, "");
                        jump.ShowDialog();

                        this.Hide();
                    }
                    else
                    {
                        frmDifficulty j = new frmDifficulty();
                        this.Hide();
                        j.Show();
                    }
                    break;
                case "2":
                    if (Classes.Methods.PlayerRightNow.LVL3SCORE != 0)// making sure the user has played main game before doing mini games
                    {
                        frmMiniGameSelector m = new frmMiniGameSelector();
                        this.Hide();
                        m.Show();
                    }
                    else
                    {
                        frmMessageBox t = new frmMessageBox("You must reach level 3 before playing the mini games", "Error: Main game not completed", 2, "");
                        t.ShowDialog();
                    }
                    break;
                case "3":
                    frmLeaderboards w = new frmLeaderboards();
                    this.Hide();
                    w.Show();
                    break;
                case "4":
                    frmAdmin d = new frmAdmin();
                    this.Hide();
                    d.Show();
                    break;
                case "5":
                    frmShop g = new frmShop();
                    this.Hide();
                    g.Show();
                    break;
                case "6":
                    frmFeedback b = new frmFeedback();
                    this.Hide();
                    b.Show();
                    break;
            }
        }

        private void pxtHelp_Click(object sender, EventArgs e)
        {
            frmHelp jump = new frmHelp(5);
            jump.ShowDialog();
        }

        private void pxtmusic_Click(object sender, EventArgs e)
        {
            if (Classes.Methods.PlayerRightNow.MUSIC == true)// turning music on/off depending on user preferences
            {
                pxtmusic.Image = Properties.Resources.MusicOff;
                Classes.Methods.PlayerRightNow.MUSIC = false;
                for(int y = 0; y < Classes.Methods.players.Count; y++)// updating user info
                {
                    if(Classes.Methods.players[y].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
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
