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
    public partial class frmVideo : Form
    {
        public frmVideo()
        {
            InitializeComponent();

            Bitmap resizedArrow = new Bitmap(Properties.Resources.LeftPointerFinished, new Size(50, 50));
            Cursor custom = new Cursor(resizedArrow.GetHicon());
            this.Cursor = custom;
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
            WMPtutorial.URL = AppDomain.CurrentDomain.BaseDirectory + "Tutorial.mp4";//getting video from debug to play
            WMPtutorial.Ctlcontrols.play();//playing video

            
        }

        int SecondsElapsed = 0;
        private void tmrVideoDone_Tick(object sender, EventArgs e)
        {
            SecondsElapsed++;

            if(SecondsElapsed == 85)//count to videos end before closing
            {
                tmrVideoDone.Stop();
                this.Hide();
            }
        }
    }
}
