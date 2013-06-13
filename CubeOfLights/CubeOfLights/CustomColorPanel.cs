using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Configuration;

namespace CubeOfLights
{
    public partial class CustomColorPanel : UserControl
    {
        public CustomColorPanel()
        {
            InitializeComponent();
        }

        private int RED, GREEN, BLUE = 0;

        public int Red
        {
            get
            {
                return RED;
            }
            set
            {
                RED = value;
                Invalidate();
            }
        }

        public int Green
        {
            get
            {
                return GREEN;
            }
            set
            {
                GREEN = value;
                Invalidate();
            }
        }

        public int Blue
        {
            get
            {
                return BLUE;
            }
            set
            {
                BLUE = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            trackBar1.Value = this.Red;
            trackBar2.Value = this.Green;
            trackBar3.Value = this.Blue;
            textBox1.Text = this.Red.ToString();
            textBox2.Text = this.Green.ToString();
            textBox3.Text = this.Blue.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Red = trackBar1.Value;
            PanelPaint();

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            this.Green = trackBar2.Value;
            PanelPaint();

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            this.Blue = trackBar3.Value;
            PanelPaint();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Red = int.Parse(textBox1.Text);
            PanelPaint();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Green = int.Parse(textBox2.Text);
            PanelPaint();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.Blue = int.Parse(textBox3.Text);
            PanelPaint();

        }

        private void PanelPaint()
        {
            panel1.BackColor = Color.FromArgb(255, this.Red, this.Green, this.Blue);

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                try
                {
                    this.Red = System.Convert.ToInt32(this.Text);


                    CappValue(this.Red);
                    UpdatePanel();
                }
                catch
                {
                    MessageBox.Show("Red textBox is not a number.");
                }
            }

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                try
                {
                    this.Green = System.Convert.ToInt32(this.Text);


                    CappValue(this.Green);
                    UpdatePanel();
                }
                catch
                {
                    MessageBox.Show("Red textBox is not a number.");
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                try
                {
                    this.Blue = System.Convert.ToInt32(this.Text);


                    CappValue(this.Blue);
                    UpdatePanel();
                }
                catch
                {
                    MessageBox.Show("Red textBox is not a number.");
                }
            }

        }

        public void UpdatePanel()
        {
            trackBar1.Value = this.Red;
            trackBar2.Value = this.Green;
            trackBar3.Value = this.Blue;
            textBox1.Text = this.Red.ToString();
            textBox2.Text = this.Green.ToString();
            textBox3.Text = this.Blue.ToString();
            PanelPaint();
        }


        private void CappValue(int a)
        {
            if (a < 0)
                a = 0;
            else if (a > 255)
                a = 255;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.Red = random.Next(0, 255);
            this.Green = random.Next(0, 255);
            this.Blue = random.Next(0, 255);
            UpdatePanel();
        }

    }
}
