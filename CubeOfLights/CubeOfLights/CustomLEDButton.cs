using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeOfLights
{
    public partial class CustomLEDButton : UserControl
    {
        private int RED, GREEN, BLUE;

        public CustomLEDButton()
        {
            InitializeComponent();
        }

        public int Red
        {
            get { return RED; }
            set { RED = value; Invalidate(); }
        }
        public int Green
        {
            get { return GREEN; }
            set { GREEN = value; Invalidate(); }
        }
        public int Blue
        {
            get { return BLUE; }
            set { BLUE = value; Invalidate(); }
        }

        public void SetRGB(CustomColorPanel myColorPanel)
        {
            if (myColorPanel.Visible)
            {

                this.Red = myColorPanel.Red;
                this.Green = myColorPanel.Green;
                this.Blue = myColorPanel.Blue;
                myColorPanel.Visible = false;
            }
            else
            {
                myColorPanel.Red = this.Red;
                myColorPanel.Green = this.Green;
                myColorPanel.Blue = this.Blue;
                myColorPanel.Visible = true;
            }
            this.BackColor = Color.FromArgb(255, this.Red, this.Green, this.Blue);
        }


    }
}
