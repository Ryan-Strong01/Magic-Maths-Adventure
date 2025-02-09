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
    public partial class frmShop : Form
    {
        public frmShop()
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;
        }

        string realavat = "";
        string[] avatarparts = new string[12];
        List<string> parts = new List<string>();
        string avat = "";

        public static void find()
        {
            for(int d = 0; d < Classes.Methods.players.Count; d++)
            {
                if(Classes.Methods.players[d].USERNAME == Classes.Methods.PlayerRightNow.USERNAME)
                {
                    Classes.Methods.players[d] = Classes.Methods.PlayerRightNow;
                }
                Classes.Methods.Serialise();
            }
        }
        private void pxtItemShoes_MouseHover(object sender, EventArgs e)
        {
            PictureBox target = (PictureBox)sender;
            switch (target.Tag.ToString())
            {
                case "HAT":
                    realavat = Classes.Methods.PlayerRightNow.Avatar;
                    string[] avatarparts = Classes.Methods.PlayerRightNow.Avatar.Split(',');
                    avatarparts[3] = "HAT";
                    parts = avatarparts.ToList();
                    string avat = "";
                    for (int x = 0; x < parts.Count; x++)
                    {
                        if (x != 0)//preventing the first word from getting a comma before it ie ,Male,Blonde,Earth
                        {
                            avat += "," + parts[x];
                        }
                        else
                        {
                            avat += parts[x];
                        }
                    }
                    Classes.Methods.PlayerRightNow.Avatar = avat;
                        Classes.Methods.CreateAvatar(pxtItemHat);
                        Classes.Methods.PlayerRightNow.Avatar = realavat;
                        realavat = "";
                        avat = "";
                        parts.Clear();
                    break;
                case "ORB":
                    realavat = Classes.Methods.PlayerRightNow.Avatar;
                    avatarparts = Classes.Methods.PlayerRightNow.Avatar.Split(',');
                    avatarparts[5] = "ORB";//updating the avatar so you can see what your avatar would look like with it
                    parts = avatarparts.ToList();
                    avat = "";
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
                    Classes.Methods.PlayerRightNow.Avatar = avat;
                        Classes.Methods.CreateAvatar(pxtItemOrb);
                        Classes.Methods.PlayerRightNow.Avatar = realavat;
                        realavat = "";
                        avat = "";
                        parts.Clear();
                    break;
                case "STAFF":
                    realavat = Classes.Methods.PlayerRightNow.Avatar;
                    avatarparts = Classes.Methods.PlayerRightNow.Avatar.Split(',');
                    avatarparts[4] = "STAFF";
                    parts = avatarparts.ToList();
                    avat = "";
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
                    Classes.Methods.PlayerRightNow.Avatar = avat;
                        Classes.Methods.CreateAvatar(pxtItemStaff);
                        Classes.Methods.PlayerRightNow.Avatar = realavat;
                        realavat = "";
                        avat = "";
                        parts.Clear();
                    break;
                case "PET":
                    realavat = Classes.Methods.PlayerRightNow.Avatar;
                    avatarparts = Classes.Methods.PlayerRightNow.Avatar.Split(',');
                    avatarparts[6] = "PET";
                    parts = avatarparts.ToList();
                    avat = "";
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
                    Classes.Methods.PlayerRightNow.Avatar = avat;
                    Classes.Methods.CreateAvatar(pxtItemPet);
                    Classes.Methods.PlayerRightNow.Avatar = realavat;
                    realavat = "";
                    avat = "";
                    parts.Clear();
                    break;
                case "FAMILIAR":
                    realavat = Classes.Methods.PlayerRightNow.Avatar;
                    avatarparts = Classes.Methods.PlayerRightNow.Avatar.Split(',');
                    avatarparts[7] = "FAMILIAR";
                    parts = avatarparts.ToList();
                    avat = "";
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
                    Classes.Methods.PlayerRightNow.Avatar = avat;
                    Classes.Methods.CreateAvatar(pxtItemFamiliar);
                    Classes.Methods.PlayerRightNow.Avatar = realavat;
                    realavat = "";
                    avat = "";
                    parts.Clear();
                    break;
                case "RUNES":
                    realavat = Classes.Methods.PlayerRightNow.Avatar;
                    avatarparts = Classes.Methods.PlayerRightNow.Avatar.Split(',');
                    avatarparts[8] = "RUNES";
                    parts = avatarparts.ToList();
                    avat = "";
                    for (int x = 0; x < parts.Count; x++)// looping through all values in the avatar
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
                    Classes.Methods.PlayerRightNow.Avatar = avat;
                    Classes.Methods.CreateAvatar(pxtItemRunes);
                    Classes.Methods.PlayerRightNow.Avatar = realavat;
                    realavat = "";
                    avat = "";
                    parts.Clear();
                    break;
                case "BELT":
                    realavat = Classes.Methods.PlayerRightNow.Avatar;
                    avatarparts = Classes.Methods.PlayerRightNow.Avatar.Split(',');
                    avatarparts[9] = "BELT";
                    parts = avatarparts.ToList();
                    avat = "";
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
                    Classes.Methods.PlayerRightNow.Avatar = avat;
                    Classes.Methods.CreateAvatar(pxtItemBelt);
                    Classes.Methods.PlayerRightNow.Avatar = realavat;
                    realavat = "";
                    avat = "";
                    parts.Clear();
                    break;
                case "SHOES":
                    realavat = Classes.Methods.PlayerRightNow.Avatar;
                    avatarparts = Classes.Methods.PlayerRightNow.Avatar.Split(',');
                    avatarparts[10] = "SHOES";
                    parts = avatarparts.ToList();
                    avat = "";
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
                    Classes.Methods.PlayerRightNow.Avatar = avat;
                    Classes.Methods.CreateAvatar(pxtItemShoes);
                    Classes.Methods.PlayerRightNow.Avatar = realavat;
                    realavat = "";
                    avat = "";
                    parts.Clear();
                    break;
            }
        }

        private void pxtItemShoes_MouseLeave(object sender, EventArgs e)
        {
            PictureBox target = (PictureBox)sender;
            switch (target.Tag.ToString())
            {
                case "HAT":
                    pxtItemHat.Image = Properties.Resources.Hat;
                    break;
                case "ORB":
                    pxtItemOrb.Image = Properties.Resources.Orb;
                    break;
                case "STAFF":
                    pxtItemStaff.Image = Properties.Resources.Staff;
                    break;
                case "PET":
                    pxtItemPet.Image = Properties.Resources.dog;
                    break;
                case "FAMILIAR":
                    pxtItemFamiliar.Image = Properties.Resources.Cat;
                    break;
                case "RUNES":
                    pxtItemRunes.Image = Properties.Resources.Runes;
                    break;
                case "BELT":
                    pxtItemBelt.Image = Properties.Resources.Belt;
                    break;
                case "SHOES":
                    pxtItemShoes.Image = Properties.Resources.Shoes;
                    break;
            }
        }

        SoundPlayer player = new SoundPlayer("MagicMathsMusic.wav");
        private void frmShop_Load(object sender, EventArgs e)
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
                    pnlShop.BackColor = Color.Blue;
                    break;
                case "Earth":
                    pnlShop.BackColor = Color.Green;
                    break;
                case "Fire":
                    pnlShop.BackColor = Color.Red;
                    break;
            }
        }

        private void pxthome_Click(object sender, EventArgs e)
        {
            frmMenu jump = new frmMenu();
            this.Hide();
            jump.Show();
        }

        private void lblShoes_Click(object sender, EventArgs e)
        {
            string[] avatarparts = Classes.Methods.PlayerRightNow.Avatar.Split(',');
            Label label = (Label)sender;
            switch (label.Tag.ToString())
            {
                case "HAT":
                    //string[] avatarparts = Classes.Methods.PlayerRightNow.Avatar.Split(',');
                    if (avatarparts[3] != "HAT")
                    {
                        if (Classes.Methods.PlayerRightNow.COINS >= 15)
                        {
                            Classes.Methods.PlayerRightNow.COINS = Classes.Methods.PlayerRightNow.COINS - 15;
                            //string[] avatarparts = Classes.Methods.PlayerRightNow.Avatar.Split(',');
                            avatarparts[3] = "HAT";
                            parts = avatarparts.ToList();
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
                            Classes.Methods.PlayerRightNow.Avatar = avat;
                            find();
                            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS;
                            frmMessageBox jump = new frmMessageBox("Item bought", "The item has been purchased", 0, "");
                            jump.ShowDialog();
                        }
                        else
                        {
                            frmMessageBox jump = new frmMessageBox("Insufficient funds", "You need to play more to earn coins", 0, "");
                            jump.ShowDialog();
                        }
                    }
                    else//user has a hat
                    {
                        frmMessageBox jump = new frmMessageBox("Item already owned", "You already have a hat", 0, "");
                        jump.ShowDialog();
                    }
                    break;
                case "ORB":
                    if (avatarparts[5] != "ORB")//checking if you already own the item
                    {
                        if (Classes.Methods.PlayerRightNow.COINS >= 5)
                        {
                            Classes.Methods.PlayerRightNow.COINS = Classes.Methods.PlayerRightNow.COINS - 5;
                            avatarparts[5] = "ORB";
                            parts = avatarparts.ToList();
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
                            Classes.Methods.PlayerRightNow.Avatar = avat;
                            find();
                            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS;
                            frmMessageBox jump = new frmMessageBox("Item bought", "The item has been purchased", 0, "");
                            jump.ShowDialog();
                        }
                        else
                        {
                            frmMessageBox jump = new frmMessageBox("Insufficient funds", "You need to play more to earn coins", 0, "");
                            jump.ShowDialog();
                        }
                    }
                    else
                    {
                        frmMessageBox jump = new frmMessageBox("Item already owned", "You already have an orb", 0, "");
                        jump.ShowDialog();
                    }
                    break;
                case "STAFF":
                    if (avatarparts[4] != "STAFF")
                    {
                        if (Classes.Methods.PlayerRightNow.COINS >= 10)//checking if you own enough coins
                        {
                            Classes.Methods.PlayerRightNow.COINS = Classes.Methods.PlayerRightNow.COINS - 10;
                            avatarparts[4] = "STAFF";
                            parts = avatarparts.ToList();
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
                            Classes.Methods.PlayerRightNow.Avatar = avat;
                            find();
                            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS;
                            frmMessageBox jump = new frmMessageBox("Item bought", "The item has been purchased", 0, "");
                            jump.ShowDialog();
                        }
                        else
                        {
                            frmMessageBox jump = new frmMessageBox("Insufficient funds", "You need to play more to earn coins", 0, "");
                            jump.ShowDialog();
                        }
                    }
                    else
                    {
                        frmMessageBox jump = new frmMessageBox("Item already owned", "You already have a staff", 0, "");
                        jump.ShowDialog();
                    }
                    break;
                case "DOG":
                    if (avatarparts[6] != "PET")
                    {
                        if (Classes.Methods.PlayerRightNow.COINS >= 20)
                        {
                            Classes.Methods.PlayerRightNow.COINS = Classes.Methods.PlayerRightNow.COINS - 20;//if you have enough coins it will take 20 coins and give you it
                            avatarparts[6] = "PET";
                            parts = avatarparts.ToList();
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
                            Classes.Methods.PlayerRightNow.Avatar = avat;
                            find();
                            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS;
                            frmMessageBox jump = new frmMessageBox("Item bought", "The item has been purchased", 0, "");
                            jump.ShowDialog();
                        }
                        else
                        {
                            frmMessageBox jump = new frmMessageBox("Insufficient funds", "You need to play more to earn coins", 0, "");
                            jump.ShowDialog();
                        }
                    }
                    else
                    {
                        frmMessageBox jump = new frmMessageBox("Item already owned", "You already have a dog", 0, "");
                        jump.ShowDialog();
                    }
                    break;
                case "RUNES":
                    if (avatarparts[8] != "RUNES")
                    {
                        if (Classes.Methods.PlayerRightNow.COINS >= 10)
                        {
                            Classes.Methods.PlayerRightNow.COINS = Classes.Methods.PlayerRightNow.COINS - 10;
                            avatarparts[8] = "RUNES";
                            parts = avatarparts.ToList();
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
                            Classes.Methods.PlayerRightNow.Avatar = avat;//updating new avatar
                            find();
                            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS;//showing how many coins you have after buying the item
                            frmMessageBox jump = new frmMessageBox("Item bought", "The item has been purchased", 0, "");
                            jump.ShowDialog();
                        }
                        else
                        {
                            frmMessageBox jump = new frmMessageBox("Insufficient funds", "You need to play more to earn coins", 0, "");
                            jump.ShowDialog();
                        }
                    }
                    else
                    {
                        frmMessageBox jump = new frmMessageBox("Item already owned", "You already have runes effect", 0, "");
                        jump.ShowDialog();
                    }
                    break;
                case "CAT":
                    if (avatarparts[7] != "CAT")
                    {
                        if (Classes.Methods.PlayerRightNow.COINS >= 20)
                        {
                            Classes.Methods.PlayerRightNow.COINS = Classes.Methods.PlayerRightNow.COINS - 20;
                            string[] avatarparts6 = Classes.Methods.PlayerRightNow.Avatar.Split(',');
                            avatarparts[7] = "CAT";
                            parts = avatarparts.ToList();
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
                            Classes.Methods.PlayerRightNow.Avatar = avat;
                            find();
                            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS;
                            frmMessageBox jump = new frmMessageBox("Item bought", "The item has been purchased", 0, "");
                            jump.ShowDialog();
                        }
                        else
                        {
                            frmMessageBox jump = new frmMessageBox("Insufficient funds", "You need to play more to earn coins", 0, "");
                            jump.ShowDialog();
                        }
                    }
                    else
                    {
                        frmMessageBox jump = new frmMessageBox("Item already owned", "You already have a cat", 0, "");
                        jump.ShowDialog();
                    }
                    break;
                case "BELT":
                    if (avatarparts[9] != "BELT")
                    {
                        if (Classes.Methods.PlayerRightNow.COINS >= 5)
                        {
                            Classes.Methods.PlayerRightNow.COINS = Classes.Methods.PlayerRightNow.COINS - 5;
                            avatarparts[9] = "BELT";
                            parts = avatarparts.ToList();
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
                            Classes.Methods.PlayerRightNow.Avatar = avat;
                            find();
                            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS;
                            frmMessageBox jump = new frmMessageBox("Item bought", "The item has been purchased", 0, "");
                            jump.ShowDialog();
                        }
                        else
                        {
                            frmMessageBox jump = new frmMessageBox("Insufficient funds", "You need to play more to earn coins", 0, "");
                            jump.ShowDialog();
                        }
                    }
                    else
                    {
                        frmMessageBox jump = new frmMessageBox("Item already owned", "You already have a belt", 0, "");
                        jump.ShowDialog();
                    }
                    break;
                case "SHOES":
                    if (avatarparts[10] != "SHOES")
                    {
                        if (Classes.Methods.PlayerRightNow.COINS >= 15)
                        {
                            Classes.Methods.PlayerRightNow.COINS = Classes.Methods.PlayerRightNow.COINS - 15;
                            avatarparts[10] = "SHOES";
                            parts = avatarparts.ToList();
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
                            Classes.Methods.PlayerRightNow.Avatar = avat;
                            find();
                            lblCoins.Text = "$" + Classes.Methods.PlayerRightNow.COINS;
                            frmMessageBox jump = new frmMessageBox("Item bought", "The item has been purchased", 0, "");
                            jump.ShowDialog();
                        }
                        else
                        {
                            frmMessageBox jump = new frmMessageBox("Insufficient funds", "You need to play more to earn coins", 0, "");
                            jump.ShowDialog();
                        }
                    }
                    else
                    {
                        frmMessageBox jump = new frmMessageBox("Item already owned", "You already have shoes", 0, "");
                        jump.ShowDialog();
                    }
                    break;
            }
        }

        private void pxtHelp_Click(object sender, EventArgs e)
        {
            frmHelp jump = new frmHelp(10);
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
