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
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;
        }

        public static List<int> xcoordinate = new List<int>() { 334, 339, 349, 360, 390, 442, 447, 381, 349, 349, 344 };//static lists to store x and y coordinates so they can be referenced and looped through
        public static List<int> ycoordinate = new List<int>() { 224, 289, 338, 388, 463, 512, 374, 316, 280, 149, 82 };
        public static List<Image> wizard = new List<Image>();// utilising reference data types alongside lists to loop through and cause animation

        string Title = "Magic Maths";
        int TitlePosition = 0;
        string Producedby = "Produced by Mojang Ltd";
        int ProducedbyPosition = 0;// remembering how much of the string Producedby variable has been spelled out

        int wizardnum = 0;
        int pictureloc = 0;
        int tick = 0;

        private void frmLoading_Load(object sender, EventArgs e)
        {
            Classes.Methods.Deserialise();
            wizard.Add(Properties.Resources.GoodWizard1);
            wizard.Add(Properties.Resources.GoodWizard2);
            wizard.Add(Properties.Resources.GoodWizard3);
            wizard.Add(Properties.Resources.GoodWizard4);
        }

        private void tmrElse_Tick(object sender, EventArgs e)
        {
            if (wizardnum == 3)//basic if used to improve the animation
            {
                wizardnum = 0;
                wizard.Clear();
                wizard.Add(Properties.Resources.GoodWizard4);
                wizard.Add(Properties.Resources.GoodWizard4);
                wizard.Add(Properties.Resources.GoodWizard4);
                wizard.Add(Properties.Resources.GoodWizard4);

                pxtstar.Visible = true;//star becomes visible
                if (pictureloc < 10)
                {
                    pictureloc++;
                    pxtstar.Location = new Point(xcoordinate[pictureloc], ycoordinate[pictureloc]);
                    //star moves
                    //text appears
                }
                else
                {
                    if (Title.Length > TitlePosition)// nested ifs clearly used to make text appear at the same time as star finishes movement
                    {
                        lblTitle.Text += Title[TitlePosition];
                        TitlePosition++;
                    }
                    if (Producedby.Length > ProducedbyPosition)
                    {
                        lblProducedby.Text += Producedby[ProducedbyPosition];
                        ProducedbyPosition++;
                    }
                }
            }
            wizardnum++;
            pxtWizard.Image = wizard[wizardnum];
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            tick++;
            if (tick == 7)
            {
                tmrLoad.Stop();
                tmrElse.Stop();
                frmLoginRegister jump = new frmLoginRegister();
                this.Hide();
                jump.Show();
            }
        }
    }
}
