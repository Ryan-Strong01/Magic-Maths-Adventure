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
    public partial class frmHelp : Form
    {
        int Origin;
        public frmHelp(int loc)
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;

            Origin = loc;
            cmbxIssues.DropDownStyle = ComboBoxStyle.DropDownList;// editing combo box style so you can't put anything into combo box
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            if (Classes.Methods.PlayerRightNow.Avatar != null)//since you can access help before creating an account I'm making sure it doesn't break
            {
                string[] AvatarParts = Classes.Methods.PlayerRightNow.Avatar.Split(',');
                switch (AvatarParts[2])
                {
                    case "Water":
                        cmbxIssues.BackColor = Color.Blue;
                        pnlHelp.BackColor = Color.Blue;
                        pnlAnswer.BackColor = Color.Blue;
                        break;
                    case "Earth":
                        cmbxIssues.BackColor = Color.Green;
                        pnlHelp.BackColor = Color.Green;
                        pnlAnswer.BackColor = Color.Green;
                        break;
                    case "Fire":
                        cmbxIssues.BackColor = Color.Red;
                        pnlHelp.BackColor = Color.Red;
                        pnlAnswer.BackColor = Color.Red;
                        break;
                }
            }

            switch (Origin)// adding questions based off whatever form you originate from
            {
                case 1://login
                    lblAnswer.Text = "Enter your details and click login";
                    cmbxIssues.Text = "";//removing previous questions
                    cmbxIssues.Items.Add("What if I have no account?");
                    cmbxIssues.Items.Add("It keeps saying that it's incorrect");//adding questions for combo box
                    break;
                case 2://forgotten password
                    lblAnswer.Text = "Enter your security ID and click the button";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("What is my security ID?");
                    cmbxIssues.Items.Add("Why can't I put anything into the textbox?");
                    break;
                case 3://register
                    lblAnswer.Text = "Enter your valid information and click the register button";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("I don't like my current avatar, what do I do?");
                    cmbxIssues.Items.Add("It won't accept the username I want, why not?");
                    break;
                case 4://build avatar
                    lblAnswer.Text = "Enter your valid information and click the register button";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("Will I be able to customise my avatar later?");
                    cmbxIssues.Items.Add("will I see this avatar later?");
                    break;
                case 5://Menu
                    lblAnswer.Text = "Click on what option you would like to pursue";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("Why can't I do the minigames?");
                    cmbxIssues.Items.Add("What kind of stuff is in the feedback?");
                    break;
                case 6://Difficulty selector
                    lblAnswer.Text = "Select a difficulty you would like to do the game on";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("What does difficulty influence?");
                    cmbxIssues.Items.Add("I'm unsure what difficulty to do");
                    cmbxIssues.Items.Add("Are the questions unique?");
                    break;
                case 7://Lvl1
                    lblAnswer.Text = "click the button that contains the right answer";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("How many questions do I need to get right?");
                    cmbxIssues.Items.Add("How many coins do you get for this level?");
                    break;
                case 8://lvl2
                    lblAnswer.Text = "at the left edge of the textbox, type in the correct answer";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("How many do I need to get right?");
                    cmbxIssues.Items.Add("What does getting a hint do?");
                    break;
                case 9://lvl3
                    lblAnswer.Text = "Drag and drop the correct answer into the gray area";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("Is this the final level of the main quiz?");
                    cmbxIssues.Items.Add("What can I do after this?");
                    break;
                case 10://shop
                    lblAnswer.Text = "Use the money you earned playing the game to buy cosmetics";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("How do I get the crown some players have?");
                    cmbxIssues.Items.Add("How many cosmetics can I buy?");
                    break;
                case 11://leaderboards
                    lblAnswer.Text = "Use the combobox to select a level and see the rankings for time";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("What time does it take?");
                    cmbxIssues.Items.Add("Why do I not have my time displayed?");
                    break;
                case 12://admin code
                    lblAnswer.Text = "Enter the admin code to access the admin centre";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("What is the admin?");
                    cmbxIssues.Items.Add("What if I want to access the admin but don't have the code?");
                    break;
                case 13://admin
                    lblAnswer.Text = "Edit, delete and add questions at each level";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("If I delete a question is it permanent?");
                    cmbxIssues.Items.Add("Do I have to use numbers when making a question?");
                    break;
                case 14://feedback
                    lblAnswer.Text = "Review your results from playing the main game to get better";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("Why is it saying I don't need tips?");
                    cmbxIssues.Items.Add("Do I get feedback for my mini games?");
                    break;
                case 15://MiniGame selector
                    lblAnswer.Text = "Please select a label to go to the relevant mini game";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("Do I earn coins from the mini games?");
                    cmbxIssues.Items.Add("What if I've done all the mini games?");
                    break;
                case 16://ogre battle
                    lblAnswer.Text = "Answer how many 100s, 10s and 1s are in the given number";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("How many do I need to answer to kill the ogre?");
                    cmbxIssues.Items.Add("How many coins do I earn from this game?");
                    break;
                case 17://potion maker
                    lblAnswer.Text = "click on the label with the right answer to make a potion";
                    cmbxIssues.Text = "";
                    cmbxIssues.Items.Add("How many do I need to get right for the potion to brew?");
                    cmbxIssues.Items.Add("What happens if I get one wrong?");
                    break;
            }
        }

        private void cmbxIssues_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbxIssues.Text)// adding text depending on what you choose for combo box questions
            {
                case "What if I have no account?"://login
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "click the label saying 'Sign Up' to be brought to the relevant form";
                    break;
                case "It keeps saying that it's incorrect"://login
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "Then one of the details you are entering is incorrect";
                    break;
                case "What is my security ID?"://forgotten
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "It is the unique number assigned to you during registration";
                    break;
                case "Why can't I put anything into the textbox?"://forgotten
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "It will only accept numbers - attempting to put letters in it will not be valid";
                    break;
                case "I don't like my current avatar, what do I do?"://reg
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "click on the 'Build Avatar' button and change it";
                    break;
                case "It won't accept the username I want, why not?"://reg
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "It means that username is currently in use, you will need a new name";
                    break;
                case "Will I be able to customise my avatar later?"://avatar builder
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "Yes there is an avatar shop in game";
                    break;
                case "will I see this avatar later?"://avatar builder
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "Yes - your avatar is your visual representation in the game";
                    break;
                case "Why can't I do the minigames?"://menu
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "you need to complete the main game at least once";
                    break;
                case "What kind of stuff is in the feedback?"://menu
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "what you need to work on out of the main multiplication, addition etc";
                    break;
                case "What does difficulty influence?"://difficulty selector
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "the hardness of the questions";
                    break;
                case "I'm unsure what difficulty to do"://difficulty selector
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "try to challenge yourself while being realistic - we recommend medium";
                    break;
                case "Are the questions unique?"://difficulty selector
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "The questions on each level will be unique";
                    break;
                case "How many questions do I need to get right?"://lvl1
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "10";
                    break;
                case "How many coins do you get for this level?"://lvl1
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "20 without hints - 15 with hints";
                    break;
                case "How many do I need to get right?"://lvl2
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "20";
                    break;
                case "What does getting a hint do?"://lvl2
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "helps you answer the question but reduces the amount you can earn";
                    break;
                case "Is this the final level of the main quiz?"://lvl3
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "Yes";
                    break;
                case "What can I do after this?"://lvl3
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "Enjoy our selection of minigames or customise your avatar";
                    break;
                case "How do I get the crown some players have?"://shop
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "The crown is only available to those with a number one spot on the leaderboards";
                    break;
                case "How many cosmetics can I buy?"://shop
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "You can buy all the shown items";
                    break;
                case "What time does it take?"://leaderboards
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "It takes your most recent time";
                    break;
                case "Why do I not have my time displayed?"://leaderboards
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "If you haven't played and your time is 0 it's not displayed";
                    break;
                case "What is the admin?"://admin code
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "It's the part of the system that allows you to edit questions";
                    break;
                case "What if I want to access the admin but don't have the code?"://admin code
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "If you don't have the code you will be unable to access the admin";
                    break;
                case "If I delete a question is it permanent?"://admin code
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "deleting questions permanently removes it from the system";
                    break;
                case "Do I have to use numbers when making a question?"://admin code
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "Yes, you have to follow the prebuilt structure for questions";
                    break;
                case "Why is it saying I don't need tips?"://feedback
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "Because your results are good enough already that you don't need assistance";
                    break;
                case "Do I get feedback for my mini games?"://feedback
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "Unfortunately no, you don't get feedback for your mini games";
                    break;
                case "Do I earn coins from the mini games?"://minigame selector
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "Yes you earn coins but less than you earn from the main game";
                    break;
                case "What if I've done all the mini games?"://minigame selector
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "Then congratulations on completing the game - try replay to get better times";
                    break;
                case "How many do I need to answer to kill the ogre?"://ogre battle
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "You need to answer 20 questions correctly to finish";
                    break;
                case "How many coins do I earn from this game?"://ogre battle
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "You earn 2 coins for playing this game";
                    break;
                case "How many do I need to get right for the potion to brew?"://potion maker
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "you need to get 10 right to get the potion";
                    break;
                case "What happens if I get one wrong?"://potion maker
                    lblComboxanswers.Visible = true;
                    lblComboxanswers.Text = "If you get 1 wrong the potion is ruined and you lose";
                    break;
            }
        }
    }
}
