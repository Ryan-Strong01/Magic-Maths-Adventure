using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Maths_Adventure.Classes
{
    [Serializable]
    public class Player
    {
        public List<string> errors = new List<string>();

        private int SecurityID;
        private string username;
        private string password;
        private string Wizard;
        private int DifficultyChosen;//this one
        private int LevelOn;//this one
        private int lvl1score, lvl2score, lvl3score;//these ones
        private int Admin;
        private bool musictoggled;//this one
        private int coins;//this one
        private bool HintActivated;
        private string currentlevel;
        public Player()
        {

        }

        public Player(string user, string pass, string wiz)
        {
            SECURITYID = Methods.players.Count + 1;
            USERNAME = user;
            PASSWORD = pass;
            Wizard = wiz;
            DIFFICULTY = 0;
            LEVELON = 0;
            LVL1SCORE = 0;
            LVL2SCORE = 0;
            LVL3SCORE = 0;
            ADMIN = 3;
            MUSIC = false;
            COINS = 0;
            HINT = false;
            CURRENTLEVEL = "NONE";
        }


        bool entered;
        bool length;
        bool range;
        bool format;
        public string USERNAME
        {
            get { return username; }
            set
            {
                Classes.Validation.Presence("username", value, errors,out entered);//using methods from validation class to save time
                if (entered)
                {
                    Classes.Validation.Length("username", value, errors, out length);
                    if (length)
                    {
                        Classes.Validation.Range("username", value, errors, out range);
                        if (range)
                        {
                            Classes.Validation.Format("username", value, errors, out format);
                            if(format)
                            {
                                bool unique = true;
                                for (int Q = 0; Q < Classes.Methods.players.Count; Q++)
                                {
                                    if (value == Classes.Methods.players[Q].username)
                                    {
                                        unique = false;
                                        errors.Add("Username not unique");//adding to error list to display
                                        break;
                                    }
                                }
                                if (unique)
                                {
                                    username = value;
                                }
                            }
                        }
                       
                    }
                }
            }
        }
        bool presence2;
        bool length2;
        bool range2;
        bool format2;

        public string PASSWORD
        {
            get { return password; }
            set
            {
                Classes.Validation.Presence("password", value, errors, out presence2);
                if (presence2)
                {
                    Classes.Validation.Length("password", value, errors, out length2);
                    if (length2)
                    {
                        Classes.Validation.Range("password", value, errors, out range2);
                        if (range2)
                        {
                            Classes.Validation.Format("password", value, errors, out format2);
                            if (format2)
                            {
                                password = value;
                            }
                        }
                    }
                }
            }
        }
        bool presence3;

        public string Avatar
        {
            get { return Wizard; }
            set
            {
                Classes.Validation.Presence("avatar", value, errors, out presence3);
                if (presence3)
                {
                    Wizard = value;
                }
            }
        }

        public int SECURITYID
        {
            get { return SecurityID; }
            set { SecurityID = value; }
        }

        public int DIFFICULTY
        {
            get { return DifficultyChosen; }
            set { DifficultyChosen = value;}
        }

        public int LEVELON
        {
            get { return LevelOn; }
            set { LevelOn = value; }
        }

        public int LVL1SCORE
        {
            get { return lvl1score; }
            set { lvl1score = value; }
        }

        public int LVL2SCORE
        {
            get { return lvl2score; }
            set { lvl2score = value; }
        }

        public int LVL3SCORE
        {
            get { return lvl3score; }
            set { lvl3score = value; }
        }

        public int ADMIN
        {
            get { return Admin; }
            set { Admin = value; }
        }

        public bool MUSIC
        {
            get { return musictoggled; }
            set { musictoggled = value; }
        }

        public int COINS
        {
            get { return coins; }
            set { coins = value; }
        }
        public bool HINT
        {
            get { return HintActivated; }
            set { HintActivated = value; }
        }
        public string CURRENTLEVEL
        {
            get { return currentlevel; }
            set { currentlevel = value; }
        }
    }
}
