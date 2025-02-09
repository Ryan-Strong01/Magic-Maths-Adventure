using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Drawing;

namespace Magic_Maths_Adventure.Classes
{
    public static class Methods
    {
        public static List<Player> players = new List<Player>();
        public static Classes.Player PlayerRightNow = new Classes.Player();

        public static void Serialise()
        {
            IFormatter format = new BinaryFormatter();

            using (Stream serialise = new FileStream("UserObjects.txt", FileMode.Create, FileAccess.Write))//.Create ensures it will create a file if it can't find one
            {
                format.Serialize(serialise, players);//serialise the players list
            }
        }

        public static void Deserialise()
        {
            if (new FileInfo("UserObjects.txt").Length > 0)//making sure system doesn't break if the file is empty
            {
                IFormatter formatt = new BinaryFormatter();

                using (Stream deserialise = new FileStream("UserObjects.txt", FileMode.Open, FileAccess.Read))
                {
                    players = (List<Player>)formatt.Deserialize(deserialise);
                }
            }
        }

        public static void CreateAvatar(PictureBox picture)
        {
            string[] avatarparts = new string[12];
            avatarparts = Classes.Methods.PlayerRightNow.Avatar.Split(',');

            List<string> OwnedItems = new List<string>();

            int gender = 0;

            switch (avatarparts[0])
            {
                case "Male":
                    gender = 0;
                    break;
                case "Female":
                    gender = 1;
                    break;
            }

            int hair = 0;

            switch (avatarparts[1])
            {
                case "Ginger":
                    hair = 0;
                    break;
                case "Blonde":
                    hair = 1;
                    break;
                case "Brown":
                    hair = 2;
                    break;
            }

            int Magic = 0;

            switch (avatarparts[2])
            {
                case "Earth":
                    Magic = 0;
                    break;
                case "Fire":
                    Magic = 1;
                    break;
                case "Water":
                    Magic = 2;
                    break;
            }

            bool hatowned;//1
            bool staffowned;//2
            bool orbowned;//3
            bool petowned;//4
            bool catowned;//5
            bool runeseffectowned;//6
            bool beltowned;//7
            bool shoesowned;
            bool crownowned;

            if (avatarparts[3].ToString() == "NOTHING")
            {
                hatowned = false;
            }
            else
            {
                hatowned = true;
                OwnedItems.Add("Hat");
            }

            if (avatarparts[4] == "NOTHING")
            {
                staffowned = false;
            }
            else
            {
                staffowned = true;
                OwnedItems.Add("Staff");
            }
            
            if (avatarparts[5] == "NOTHING")
            {
                orbowned = false;
            }
            else
            {
                orbowned = true;
                OwnedItems.Add("Orb");
            }

            if (avatarparts[6] == "NOTHING")
            {
                petowned = false;
            }
            else
            {
                petowned = true;
                OwnedItems.Add("Pet");
            }

            if (avatarparts[7] == "NOTHING")
            {
                catowned = false;
            }
            else
            {
                catowned = true;
                OwnedItems.Add("Cat");
            }

            if (avatarparts[8] == "NOTHING")
            {
                runeseffectowned = false;
            }
            else
            {
                runeseffectowned = true;
                OwnedItems.Add("Runes");
            }

            if (avatarparts[9] == "NOTHING")
            {
                beltowned = false;
            }
            else
            {
                beltowned = true;
                OwnedItems.Add("Belt");
            }

            if (avatarparts[10] == "NOTHING")
            {
                shoesowned = false;
            }
            else
            {
                shoesowned = true;
                OwnedItems.Add("Shoes");
            }

            if(avatarparts[11] == "NOTHING")
            {
                crownowned = false;
            }
            else
            {
                crownowned = true;
                OwnedItems.Add("Crown");
            }

            try
            {
                switch (gender)
                {
                    case 0://male
                        switch (hair)
                        {
                            case 0://ginger
                                if (Magic == 0)//male ginger earth
                                {
                                    Image head = Properties.Resources.Wizard_Male_Head_Ginger_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Earth_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 350, 250);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 0, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, 300, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 400, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, 70, 350);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 190, 560);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if(crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                else if (Magic == 1)//male ginger fire
                                {
                                    Image head = Properties.Resources.Wizard_Male_Head_Ginger_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Fire_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 350, 250);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 0, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, 300, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 400, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, 70, 350);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 190, 560);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                else if (Magic == 2)// male ginger water
                                {
                                    Image head = Properties.Resources.Wizard_Male_Head_Ginger_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Water_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 350, 250);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 0, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, 300, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 400, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, 70, 350);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 190, 560);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                break;
                            case 1://blonde
                                if (Magic == 0)//male blonde earth
                                {
                                    Image head = Properties.Resources.Wizard_Male_Head_Blonde_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Earth_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 350, 250);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 0, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, 300, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 400, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, 70, 350);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 190, 560);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                else if (Magic == 1)//male blonde fire
                                {
                                    Image head = Properties.Resources.Wizard_Male_Head_Blonde_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Fire_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 350, 250);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 0, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, 300, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 400, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, 70, 350);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 190, 560);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                else if (Magic == 2)// male blonde water
                                {
                                    Image head = Properties.Resources.Wizard_Male_Head_Blonde_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Water_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 350, 250);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 0, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, 300, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 400, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, 70, 350);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 190, 560);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                break;
                            case 2://brown
                                if (Magic == 0)//male brown earth
                                {
                                    Image head = Properties.Resources.Wizard_Male_Head_Brown_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Earth_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 350, 250);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 0, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, 300, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 400, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, 70, 350);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 190, 560);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                else if (Magic == 1)//male brown fire
                                {
                                    Image head = Properties.Resources.Wizard_Male_Head_Brown_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Fire_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 350, 250);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 0, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, 300, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 400, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, 70, 350);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 190, 560);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                else if (Magic == 2)// male brown water
                                {
                                    Image head = Properties.Resources.Wizard_Male_Head_Brown_Finished;
                                    Image body = Properties.Resources.Wizard_Male_Body_Water_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 130, 150);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 350, 250);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 0, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, 300, 510);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 400, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, 70, 350);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 190, 560);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(350, 200));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 120, 140);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                break;
                        }
                        break;
                    case 1://female
                        switch (hair)
                        {
                            case 0://ginger
                                if (Magic == 0)//female ginger earth
                                {
                                    Image head = Properties.Resources.Wizard_Female_Head_Ginger_Finished;
                                    Image body = Properties.Resources.Wizard_Female_Body_Earth_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 140, 230);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 70, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, -20, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 40, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, -140, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 0, 650);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                else if (Magic == 1)//female ginger fire
                                {
                                    Image head = Properties.Resources.Wizard_Female_Head_Ginger_Finished;
                                    Image body = Properties.Resources.Wizard_Female_Body_Fire_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 140, 230);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 70, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, -20, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 40, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, -140, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 0, 650);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                else if (Magic == 2)// female ginger water
                                {
                                    Image head = Properties.Resources.Wizard_Female_Head_Ginger_Finished;
                                    Image body = Properties.Resources.Wizard_Female_Body_Water_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 140, 230);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 70, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, -20, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 40, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, -140, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 0, 650);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                break;
                            case 1://blonde
                                if (Magic == 0)//female blonde earth
                                {
                                    Image head = Properties.Resources.Blonde_Witch;
                                    Image body = Properties.Resources.Wizard_Female_Body_Earth_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 140, 230);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 70, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, -20, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 40, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, -140, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 0, 650);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                else if (Magic == 1)//female blonde fire
                                {
                                    Image head = Properties.Resources.Blonde_Witch;
                                    Image body = Properties.Resources.Wizard_Female_Body_Fire_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 140, 230);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 70, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, -20, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 40, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, -140, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 0, 650);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                else if (Magic == 2)// female blonde water
                                {
                                    Image head = Properties.Resources.Blonde_Witch;
                                    Image body = Properties.Resources.Wizard_Female_Body_Water_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 140, 230);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 70, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, -20, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 40, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, -140, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 0, 650);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                break;
                            case 2://brown
                                if (Magic == 0)//female brown earth
                                {
                                    Image head = Properties.Resources.Wizard_Female_Head_Brown_Finished;
                                    Image body = Properties.Resources.Wizard_Female_Body_Earth_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 140, 230);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 70, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, -20, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 40, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, -140, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 0, 650);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                else if (Magic == 1)//female brown fire
                                {
                                    Image head = Properties.Resources.Wizard_Female_Head_Brown_Finished;
                                    Image body = Properties.Resources.Wizard_Female_Body_Fire_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 140, 230);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 70, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, -20, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 40, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, -140, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 0, 650);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                else if (Magic == 2)// female brown water
                                {
                                    Image head = Properties.Resources.Wizard_Female_Head_Brown_Finished;
                                    Image body = Properties.Resources.Wizard_Female_Body_Water_Finished;

                                    Bitmap avatar = new Bitmap(body.Width, head.Height + body.Height);
                                    using (Graphics generate = Graphics.FromImage(avatar))
                                    {
                                        generate.DrawImage(head, 23, 290);
                                        generate.DrawImage(body, 0, head.Height);
                                    }
                                    if (OwnedItems.Count > 0)
                                    {
                                        if (hatowned == true)
                                        {
                                            //code to make hat ontop of avatar variable
                                            Bitmap hat = new Bitmap(Properties.Resources.Hat, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(hat, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (staffowned == true)
                                        {
                                            //code to add staff to avatar variable
                                            Bitmap staff = new Bitmap(Properties.Resources.Staff, new Size(200, 700));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(staff, 140, 230);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (orbowned == true)
                                        {
                                            //code to add orb to avatar variable
                                            Bitmap orb = new Bitmap(Properties.Resources.Orb, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(orb, 90, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (petowned == true)
                                        {
                                            //code to add pet to avatar variable
                                            Bitmap pet = new Bitmap(Properties.Resources.dog, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(pet, 70, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (catowned == true)
                                        {
                                            //code to add cat to avatar variable
                                            Bitmap familiar = new Bitmap(Properties.Resources.Cat, new Size(200, 200));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(familiar, -20, 600);//1 is how far across, 2 is how far down
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (runeseffectowned == true)
                                        {
                                            //code to add runes effect to avatar variable
                                            Bitmap rune = new Bitmap(Properties.Resources.Runes, new Size(50, 100));// 150 is width and 150 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(rune, 40, 180);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (beltowned == true)
                                        {
                                            //code to add belt to avatar variable
                                            Bitmap belt = new Bitmap(Properties.Resources.Belt, new Size(400, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(belt, -140, 300);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (shoesowned == true)
                                        {
                                            //code to add shoes to avatar variable
                                            Bitmap shoes = new Bitmap(Properties.Resources.Shoes, new Size(300, 300));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(shoes, 0, 650);
                                            }


                                            picture.Image = avatar;
                                        }

                                        if (crownowned == true)
                                        {
                                            Bitmap crown = new Bitmap(Properties.Resources.Crown, new Size(125, 100));// 390 is width and 300 is height

                                            using (Graphics generate = Graphics.FromImage(avatar))
                                            {
                                                generate.DrawImage(crown, 60, 300);
                                            }


                                            picture.Image = avatar;
                                        }
                                    }
                                    picture.Image = avatar;
                                }
                                break;
                        }
                        break;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Something has gone wrong, for more details this is it: " + error);
            }
        }

        public static void ReadInQuestions(string input)
        {
            Classes.Questions.All.Clear();
            Classes.Questions.Question.Clear();
            Classes.Questions.Answers.Clear();
            Classes.Questions.Hints.Clear();
            try
            {
                using (StreamReader read = new StreamReader("GameQuestions.txt"))
                {
                    string sentence;
                    while ((sentence = read.ReadLine()) != null)
                    {
                        if (sentence.Contains(input))
                        {
                            Classes.Questions.All.Add(sentence);
                            //string[] RemoveIndicator = sentence.Split(':');
                            //string[] WholeQuestion = RemoveIndicator[1].Split('/');
                            //Classes.Questions.Question.Add(WholeQuestion[0]);
                            //Classes.Questions.Answers.Add(WholeQuestion[1]);
                            //Classes.Questions.Hints.Add(WholeQuestion[2]);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("An error has occurred reading in the details, for more information - " + error);
            }
        }
    }
}
