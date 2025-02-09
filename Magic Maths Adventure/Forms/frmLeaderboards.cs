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
    public partial class frmLeaderboards : Form
    {
        public frmLeaderboards()
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;
        }
        private void cmbxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cmbxLevel.Text)
                {
                    case "Level 1":
                        lstbxTimes.Items.Clear();
                        List<Tuple<int, string>> times1 = new List<Tuple<int, string>>();//tuple list which can store multiple data types so I can store both the username and scores
                        for (int r = 0; r < Classes.Methods.players.Count; r++)
                        {
                            if (Classes.Methods.players[r].LVL1SCORE != 0)//removing users who've not done the level
                            {
                                times1.Add(Tuple.Create(Classes.Methods.players[r].LVL1SCORE, Classes.Methods.players[r].USERNAME));
                            }
                        }

                        times1.Sort((x, y) => x.Item1.CompareTo(y.Item1));//sorting using the data in the tuple list

                        int rank1 = 1;
                        foreach (var tuple in times1)//tuple is a var since it has multiple data types
                        {
                            lstbxTimes.Items.Add(rank1 + "." + tuple.Item2 + "- " + tuple.Item1 + " seconds");
                            rank1++;
                        }
                        string WinnersAvatar1 = " ";
                        foreach (string item in lstbxTimes.Items)
                        {
                            string[] users = item.Split('.');
                            if (users[0] == "1")
                            {
                                string[] arrayDiv = users[1].Split('-');
                                string name = arrayDiv[0]; ;
                                lblNO1.Text = "Number 1 Champion: " + name;
                                for (int X = 0; X < Classes.Methods.players.Count; X++)
                                {
                                    if (Classes.Methods.players[X].USERNAME == name)
                                    {
                                        WinnersAvatar1 = Classes.Methods.players[X].Avatar;
                                    }
                                }
                                string[] avatarparts = WinnersAvatar1.Split(',');
                                avatarparts[11] = "CROWN";
                                List<string> parts = avatarparts.ToList();
                                string avat = "";
                                for (int x = 0; x < parts.Count; x++)
                                {
                                    if (x != 0)
                                    {
                                        avat += "," + parts[x];
                                    }
                                    else
                                    {
                                        avat += parts[x];
                                    }
                                }
                                WinnersAvatar1 = avat;

                                for (int X = 0; X < Classes.Methods.players.Count; X++)
                                {
                                    if (Classes.Methods.players[X].USERNAME == name)
                                    {
                                        Classes.Methods.players[X].Avatar = WinnersAvatar1;
                                    }
                                }
                                Classes.Methods.Serialise();
                            }
                        }
                        break;
                    case "Level 2":
                        lstbxTimes.Items.Clear();
                        List<Tuple<int, string>> times2 = new List<Tuple<int, string>>();

                        for (int r = 0; r < Classes.Methods.players.Count; r++)
                        {
                            if (Classes.Methods.players[r].LVL2SCORE != 0)
                            {
                                times2.Add(Tuple.Create(Classes.Methods.players[r].LVL2SCORE, Classes.Methods.players[r].USERNAME));
                            }
                        }

                        times2.Sort((x, y) => x.Item1.CompareTo(y.Item1));

                        int rank2 = 1;
                        foreach (var tuple in times2)
                        {
                            lstbxTimes.Items.Add(rank2 + "." + tuple.Item2 + "- " + tuple.Item1 + " seconds");
                            rank2++;
                        }
                        string WinnersAvatar2 = " ";
                        foreach (string item in lstbxTimes.Items)
                        {
                            string[] users = item.Split('.');
                            if (users[0] == "1")//getting the best score
                            {
                                string[] arrayDiv = users[1].Split('-');
                                string name = arrayDiv[0]; ;
                                lblNO1.Text = "Number 1 Champion: " + name;
                                for (int X = 0; X < Classes.Methods.players.Count; X++)
                                {
                                    if (Classes.Methods.players[X].USERNAME == name)
                                    {
                                        WinnersAvatar2 = Classes.Methods.players[X].Avatar;// getting the winners avatar
                                    }
                                }
                                string[] avatarparts = WinnersAvatar2.Split(',');
                                avatarparts[11] = "CROWN";//adding the crown to the winners avatar
                                List<string> parts = avatarparts.ToList();
                                string avat = "";
                                for (int x = 0; x < parts.Count; x++)
                                {
                                    if (x != 0)
                                    {
                                        avat += "," + parts[x];
                                    }
                                    else
                                    {
                                        avat += parts[x];
                                    }
                                }
                                WinnersAvatar2 = avat;

                                for (int X = 0; X < Classes.Methods.players.Count; X++)
                                {
                                    if (Classes.Methods.players[X].USERNAME == name)
                                    {
                                        Classes.Methods.players[X].Avatar = WinnersAvatar2;//updating in object list with users new avatar
                                    }
                                }
                                Classes.Methods.Serialise();
                            }
                        }
                        break;
                    case "Level 3":
                        lstbxTimes.Items.Clear();
                        List<Tuple<int, string>> times3 = new List<Tuple<int, string>>();

                        for (int r = 0; r < Classes.Methods.players.Count; r++)
                        {
                            if (Classes.Methods.players[r].LVL3SCORE != 0)
                            {
                                times3.Add(Tuple.Create(Classes.Methods.players[r].LVL3SCORE, Classes.Methods.players[r].USERNAME));
                            }
                        }

                        times3.Sort((x, y) => x.Item1.CompareTo(y.Item1));

                        int rank3 = 1;
                        foreach (var tuple in times3)
                        {
                            lstbxTimes.Items.Add(rank3 + "." + tuple.Item2 + "- " + tuple.Item1 + " seconds");
                            rank3++;
                        }
                        string WinnersAvatar3 = " ";
                        foreach (string item in lstbxTimes.Items)
                        {
                            string[] users = item.Split('.');
                            if (users[0] == "1")
                            {
                                string[] arrayDiv = users[1].Split('-');
                                string name = arrayDiv[0]; ;
                                lblNO1.Text = "Number 1 Champion: " + name;//displaying winners username
                                for (int X = 0; X < Classes.Methods.players.Count; X++)
                                {
                                    if (Classes.Methods.players[X].USERNAME == name)
                                    {
                                        WinnersAvatar3 = Classes.Methods.players[X].Avatar;
                                    }
                                }
                                string[] avatarparts = WinnersAvatar3.Split(',');
                                avatarparts[11] = "CROWN";
                                List<string> parts = avatarparts.ToList();
                                string avat = "";
                                for (int x = 0; x < parts.Count; x++)
                                {
                                    if (x != 0)
                                    {
                                        avat += "," + parts[x];
                                    }
                                    else
                                    {
                                        avat += parts[x];
                                    }
                                }
                                WinnersAvatar3 = avat;

                                for (int X = 0; X < Classes.Methods.players.Count; X++)
                                {
                                    if (Classes.Methods.players[X].USERNAME == name)
                                    {
                                        Classes.Methods.players[X].Avatar = WinnersAvatar3;
                                    }
                                }
                                Classes.Methods.Serialise();
                            }
                        }
                        break;

                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        SoundPlayer player = new SoundPlayer("MagicMathsMusic.wav");//creating object from soundplayer class based off the music I have in my debug file
        private void frmLeaderboards_Load(object sender, EventArgs e)
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
                    cmbxLevel.BackColor = Color.Blue;
                    pnlBoards.BackColor = Color.Blue;
                    break;
                case "Earth":
                    cmbxLevel.BackColor = Color.Green;
                    pnlBoards.BackColor = Color.Green;
                    break;
                case "Fire":
                    cmbxLevel.BackColor = Color.Red;
                    pnlBoards.BackColor = Color.Red;
                    break;
            }
        }

        private void pxtHelp_Click(object sender, EventArgs e)
        {
            frmHelp jump = new frmHelp(11);
            jump.ShowDialog();
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
    }
}
