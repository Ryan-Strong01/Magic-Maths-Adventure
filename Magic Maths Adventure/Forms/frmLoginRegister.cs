using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Maths_Adventure.Forms
{
    public partial class frmLoginRegister : Form
    {
        public frmLoginRegister()
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;
        }

        private void pxtHelpLog_Click(object sender, EventArgs e)// to help screen from the login
        {
            frmHelp jump = new frmHelp(1);
            jump.ShowDialog();
        }

        private void lblforgotten_Click(object sender, EventArgs e)// to forgotten password panel from login
        {
            mskedtxtID.Text = "";
            lblYourPass.Text = "";
            pnlLogin.Visible = false;
            pnlLogin.Location = new Point(808, 2);
            pnlFindLost.Location = new Point(2, 2);
            pnlFindLost.Visible = true;
        }

        private void lblNeedtoRegister_Click(object sender, EventArgs e)// to registration panel from login
        {
            Image head = Properties.Resources.Wizard_Male_Head_Ginger_Finished;// autosetting an avatar so user will always have one even if they don't choose
            Image body = Properties.Resources.Wizard_Male_Body_Earth_Finished;

            Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
            using (Graphics generate = Graphics.FromImage(avatar))
            {
                generate.DrawImage(head, 130, 150);
                generate.DrawImage(body, 0, head.Height);
            }
            pxtYourAvatar.Image = avatar;
            pxtYourWiz.Image = avatar;
            pxtYourWiz.Tag = "Male,Ginger,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";//setting a preset for the avatar so the user cannot have no avatar
            pxtYourAvatar.Tag = "Male,Ginger,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";

            pnlLogin.Visible = false;
            pnlLogin.Location = new Point(808, 2);
            pnlRegister.Location = new Point(2, 2);
            pnlRegister.Visible = true;
        }

        int VisibleOrInvis = 0;
        private void pxtPasswordVisible_Click(object sender, EventArgs e)// to make password visible
        {
            switch (VisibleOrInvis)
            {
                case 0:
                    pxtPasswordVisible.Image = Properties.Resources.PasswordVisible;
                    VisibleOrInvis = 1;

                    txtLoginPassword.PasswordChar = '\0';
                    break;
                case 1:
                    pxtPasswordVisible.Image = Properties.Resources.PasswordInvisible;
                    VisibleOrInvis = 0;

                    txtLoginPassword.PasswordChar = '●';
                    break;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginUsername.Text == "")
            {
                if (txtLoginPassword.Text == "")
                {
                    frmMessageBox jump = new frmMessageBox("Enter a username and password", "Login Invalid", 2, "");
                    jump.ShowDialog();
                    return;// return to prevent multiple errors popping up
                }
                frmMessageBox a = new frmMessageBox("Enter a username", "Login Invalid", 2, "");
                a.ShowDialog();
                return;
            }
            else if (txtLoginPassword.Text == "")
            {
                frmMessageBox b = new frmMessageBox("Enter a password", "Login Invalid", 2, "");
                b.ShowDialog();
                return;
            }

            bool IsUserRight = false;
            bool IsPassRight = false;

            for (int X = 0; X < Classes.Methods.players.Count; X++)
            {
                if (txtLoginUsername.Text == Classes.Methods.players[X].USERNAME)
                {
                    IsUserRight = true;
                    if (txtLoginPassword.Text == Classes.Methods.players[X].PASSWORD)// loop to go through serialised users to see if they match
                    {
                        Classes.Methods.PlayerRightNow = Classes.Methods.players[X];
                        
                        IsPassRight = true;

                        frmMenu jump = new frmMenu();
                        this.Hide();
                        jump.Show();
                    }
                }
            }
            if (IsUserRight == false)
            {
                txtLoginUsername.Text = "";
                txtLoginPassword.Text = "";
                frmMessageBox jump = new frmMessageBox("Wrong Username or Password", "Login Invalid", 2, "");
                jump.ShowDialog();
            }
            else if (IsPassRight == false)
            {
                txtLoginUsername.Text = "";
                txtLoginPassword.Text = "";
                frmMessageBox jump = new frmMessageBox("Wrong Username or Password", "Login Invalid", 2, "");//unique form exclusively for errors
                jump.ShowDialog();
            }
        }// end of all the login code

        private void btnFind_Click(object sender, EventArgs e)// beginning of the forgotten password code
        {
            bool found = false;
            if (!string.IsNullOrWhiteSpace(mskedtxtID.Text))
            {
                try
                {
                    for (int z = 0; z < Classes.Methods.players.Count; z++)
                    {
                        if (Convert.ToInt16(mskedtxtID.Text) == Classes.Methods.players[z].SECURITYID)
                        {
                            found = true;
                            lblYourPass.Text = Classes.Methods.players[z].PASSWORD;
                        }
                    }
                    if (!found)//checking that the user hasn't found an ID
                    {
                        frmMessageBox jump = new frmMessageBox("A user with that ID doesn't exist", "No user found", 2, "");
                        jump.ShowDialog();
                        mskedtxtID.Text = "";
                    }
                    
                }
                catch(Exception error)
                {
                    MessageBox.Show(error + "There has likely been an issue with the list of users - some probable causes are invalid data, spaces or multiple matching IDs");
                }
            }
            else
            {
                frmMessageBox jump = new frmMessageBox("Please enter an ID", "ID Invalid", 2, "");
                jump.ShowDialog();
            }
        }

        private void pxtHelpForgotten_Click(object sender, EventArgs e)// help screen for the forgotten form
        {
            frmHelp jump = new frmHelp(2);
            jump.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)// go from forgotten form to login
        {
            pnlLogin.Visible = true;
            pnlLogin.Location = new Point(2, 2);
            pnlFindLost.Location = new Point(808, 2);
            pnlFindLost.Visible = false;
        }// end of forgotten password code

        private void btnCreateWiz_Click(object sender, EventArgs e)// start of the registration form
        {
            pnlRegister.Visible = false;
            pnlRegister.Location = new Point(808, 2);
            pnlBuildAvatar.Location = new Point(2, 2);
            pnlBuildAvatar.Visible = true;
        }

        private void pxtHelpReg_Click(object sender, EventArgs e)
        {
            frmHelp jump = new frmHelp(3);
            jump.ShowDialog();
        }

        private void btnRegisterAcc_Click(object sender, EventArgs e)
        {
            pxtYourWiz.Tag = pxtYourAvatar.Tag;

            Classes.Player user = new Classes.Player(txtRegisterUser.Text, txtRegisterPass.Text, pxtYourWiz.Tag.ToString());// creating a parameritised object

            if (user.errors.Count > 0)
            {
                string issues = "";
                for(int d = 0; d < user.errors.Count; d++)
                {
                    if( d != 0)
                    {
                        issues += "," + user.errors[d];
                    }
                    else
                    {
                        issues += user.errors[d];
                    }
                }
                frmMessageBox jump = new frmMessageBox(issues, "ERROR!", 3, "");
                jump.ShowDialog();
                    txtRegisterUser.Text = "";
                    txtRegisterPass.Text = "";
            }
            else
            {
                //user.COINS = 1000;
                Classes.Methods.players.Add(user);//adding user to our object list
                Classes.Methods.Serialise();//writing out object list
                string message = "An account has successfully been made with the security ID " + user.SECURITYID;
                frmMessageBox jump = new frmMessageBox(message, "Account Created!", 2, "");
                jump.ShowDialog();
                    txtLoginUsername.Text = txtRegisterUser.Text;
                    txtLoginPassword.Text = "";
                    txtRegisterUser.Text = "";
                    txtRegisterPass.Text = "";

                    pnlRegister.Visible = false;
                    pnlRegister.Location = new Point(808, 2);
                    pnlLogin.Location = new Point(2, 2);
                    pnlLogin.Visible = true;

            }
        }//end of reg form

        public List<string> sexes = new List<string>() { "Male", "Female" };// start of avatar builder form
        int sexnum = 0;
        public List<string> colours = new List<string>() { "Ginger", "Blonde", "Brown" };
        int colournum = 0;
        public List<string> magics = new List<string>() { "Earth", "Fire", "Water" };// lists showing different characteristics to choose from
        int magicnum = 0;
        private void pxtleftsex_Click(object sender, EventArgs e)
        {
            switch (sexnum)
            {
                case 0:
                    sexnum++;
                    break;
                case 1:
                    sexnum = 0;
                    break;
            }
            lblSexselector.Text = sexes[sexnum];
        }

        private void pxtrightsex_Click(object sender, EventArgs e)
        {
            switch (sexnum)//swapping between the options using a switch
            {
                case 0:
                    sexnum++;
                    break;
                case 1:
                    sexnum = 0;
                    break;
            }
            lblSexselector.Text = sexes[sexnum];
        }

        private void pxtrightcolour_Click(object sender, EventArgs e)
        {
            if (colournum == 2)
            {
                colournum = 0;
            }
            else
            {
                colournum++;
            }
            lblHairSelector.Text = colours[colournum];
        }

        private void pxtleftcolour_Click(object sender, EventArgs e)
        {
            if (colournum == 0)
            {
                colournum = 2;
            }
            else
            {
                colournum--;
            }
            lblHairSelector.Text = colours[colournum];
        }

        private void pxtrightmagic_Click(object sender, EventArgs e)
        {
            if (magicnum == 2)
            {
                magicnum = 0;
            }
            else
            {
                magicnum++;
            }
            lblMagicSelector.Text = magics[magicnum];
        }

        private void pxtleftmagic_Click(object sender, EventArgs e)
        {
            if (magicnum == 0)
            {
                magicnum = 2;
            }
            else
            {
                magicnum--;
            }
            lblMagicSelector.Text = magics[magicnum];
        }

        private void btnBuildAv_Click(object sender, EventArgs e)
        {
            int gender = 0;
            int colourofhair = 0;
            if (lblSexselector.Text == "Male")// assigning values to male and female so it can be used in a switch statement
            {
                gender = 1;
            }
            else
            {
                gender = 2;
            }

            try
            {
                switch (gender)
                {
                    case 1:
                        switch (lblHairSelector.Text)
                        {
                            case "Ginger":
                                colourofhair = 1;
                                break;
                            case "Blonde":
                                colourofhair = 2;
                                break;
                            case "Brown":
                                colourofhair = 3;
                                break;
                        }
                        switch (colourofhair)
                        {
                            case 1:
                                if (lblMagicSelector.Text == "Earth")
                                {

                                    Image head = Properties.Resources.Wizard_Male_Head_Ginger_Finished;//creating variables out of different images in resources
                                    Image body = Properties.Resources.Wizard_Male_Body_Earth_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);// creating new variable using previous 2
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);//drawing them using method
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Male,Ginger,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Male,Ginger,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                else if (lblMagicSelector.Text == "Fire")
                                {

                                    Image head = Properties.Resources.Wizard_Male_Head_Ginger_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Fire_Finished;// bringing in the images and storing them within variables

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Male,Ginger,Fire,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Male,Ginger,Fire,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                else if (lblMagicSelector.Text == "Water")
                                {

                                    Image head = Properties.Resources.Wizard_Male_Head_Ginger_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Water_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Male,Ginger,Water,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Male,Ginger,Water,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                break;

                            case 2:
                                if (lblMagicSelector.Text == "Earth")
                                {

                                    Image head = Properties.Resources.Wizard_Male_Head_Blonde_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Earth_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Male,Blonde,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Male,Blonde,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                else if (lblMagicSelector.Text == "Fire")
                                {

                                    Image head = Properties.Resources.Wizard_Male_Head_Blonde_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Fire_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Male,Blonde,Fire,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Male,Blonde,Fire,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                else if (lblMagicSelector.Text == "Water")
                                {

                                    Image head = Properties.Resources.Wizard_Male_Head_Blonde_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Water_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Male,Blonde,Water,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Male,Blonde,Water,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                break;

                            case 3:
                                if (lblMagicSelector.Text == "Earth")
                                {

                                    Image head = Properties.Resources.Wizard_Male_Head_Brown_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Earth_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Male,Brown,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Male,Brown,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";//setting the avatar using a string

                                }
                                else if (lblMagicSelector.Text == "Fire")
                                {

                                    Image head = Properties.Resources.Wizard_Male_Head_Brown_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Fire_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Male,Brown,Fire,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Male,Brown,Fire,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                else if (lblMagicSelector.Text == "Water")
                                {

                                    Image head = Properties.Resources.Wizard_Male_Head_Brown_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Water_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Male,Brown,Water,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Male,Brown,Water,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                break;
                        }
                        break;

                    case 2://for female avatar
                        switch (lblHairSelector.Text)//assigning a value to different hair colours to be used in switch
                        {
                            case "Ginger":
                                colourofhair = 1;
                                break;
                            case "Blonde":
                                colourofhair = 2;
                                break;
                            case "Brown":
                                colourofhair = 3;
                                break;
                        }
                        switch (colourofhair)
                        {
                            case 1:
                                if (lblMagicSelector.Text == "Earth")
                                {

                                    Image head = Properties.Resources.Wizard_Female_Head_Ginger_Finished;
                                    Image body = Properties.Resources.Wizard_Female_Body_Earth_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Female,Ginger,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Female,Ginger,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                else if (lblMagicSelector.Text == "Fire")
                                {

                                    Image head = Properties.Resources.Wizard_Female_Head_Ginger_Finished;
                                    Image body = Properties.Resources.Wizard_Female_Body_Fire_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Female,Ginger,Fire,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Female,Ginger,Fire,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                else if (lblMagicSelector.Text == "Water")
                                {

                                    Image head = Properties.Resources.Wizard_Female_Head_Ginger_Finished;
                                    Image body = Properties.Resources.Wizard_Female_Body_Water_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Female,Ginger,Water,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Female,Ginger,Water,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                break;
                            case 2:
                                if (lblMagicSelector.Text == "Earth")
                                {

                                    Image head = Properties.Resources.Blonde_Witch;
                                    Image body = Properties.Resources.Wizard_Female_Body_Earth_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Female,Blonde,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Female,Blonde,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";

                                }
                                else if (lblMagicSelector.Text == "Fire")
                                {

                                    Image head = Properties.Resources.Blonde_Witch;
                                    Image body = Properties.Resources.Wizard_Female_Body_Fire_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Female,Blonde,Fire,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Female,Blonde,Fire,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";

                                }
                                else if (lblMagicSelector.Text == "Water")
                                {
                                    Image head = Properties.Resources.Blonde_Witch;
                                    Image body = Properties.Resources.Wizard_Female_Body_Water_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 30, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Female,Blonde,Water,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Female,Blonde,Water,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";

                                }
                                break;
                            case 3:
                                if (lblMagicSelector.Text == "Earth")
                                {

                                    Image head = Properties.Resources.Wizard_Female_Head_Brown_Finished;
                                    Image body = Properties.Resources.Wizard_Female_Body_Earth_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Female,Brown,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Female,Brown,Earth,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                else if (lblMagicSelector.Text == "Fire")
                                {

                                    Image head = Properties.Resources.Wizard_Female_Head_Brown_Finished;
                                    Image body = Properties.Resources.Wizard_Female_Body_Fire_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Female,Brown,Fire,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Female,Brown,Fire,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                else if (lblMagicSelector.Text == "Water")
                                {
                                    Image head = Properties.Resources.Wizard_Female_Head_Brown_Finished;
                                    Image body = Properties.Resources.Wizard_Female_Body_Water_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    pxtYourAvatar.Image = avatar;
                                    pxtYourAvatar.Tag = "Female,Brown,Water,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                    pxtYourWiz.Tag = "Female,Brown,Water,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING,NOTHING";
                                }
                                break;
                        }
                        break;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error + "An error during the creation of the avatar has ocurred - make sure your choices are valid");
            }
        }

        private void btnChooseAv_Click(object sender, EventArgs e)
        {
            pnlBuildAvatar.Visible = false;
            pnlBuildAvatar.Location = new Point(808, 2);// moving between panels on a form - doing this allows me to use data on other forms
            pnlRegister.Location = new Point(2, 2);
            pnlRegister.Visible = true;
            pxtYourWiz.Image = pxtYourAvatar.Image;
        }

        private void pxtHelpBuild_Click(object sender, EventArgs e)
        {
            frmHelp jump = new frmHelp(4);
            jump.ShowDialog();
        }

        private void frmLoginRegister_Load(object sender, EventArgs e)
        {
        }// end of avatar builder
    }
}
