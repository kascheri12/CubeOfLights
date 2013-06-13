using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeOfLights
{
    public partial class Form1 : Form
    {
        List<CustomLEDButton> ListLEDButtons = new List<CustomLEDButton>();

        public Form1()
        {
            InitializeComponent();
            customColorPanel1.Visible = false;
            customColorPanel2.Visible = false;
            customColorPanel3.Visible = false;
            customColorPanel4.Visible = false;
            customColorPanel5.Visible = false;
            InitializeCustomLEDButtons();
        }

        private void InitializeCustomLEDButtons()
        {
            ListLEDButtons.Add(customLEDButton1);
            ListLEDButtons.Add(customLEDButton2);
            ListLEDButtons.Add(customLEDButton3);
            ListLEDButtons.Add(customLEDButton4);
            ListLEDButtons.Add(customLEDButton5);
            ListLEDButtons.Add(customLEDButton6);
            ListLEDButtons.Add(customLEDButton7);
            ListLEDButtons.Add(customLEDButton8);
            ListLEDButtons.Add(customLEDButton9);
            ListLEDButtons.Add(customLEDButton10);
            ListLEDButtons.Add(customLEDButton11);
            ListLEDButtons.Add(customLEDButton12);
            ListLEDButtons.Add(customLEDButton13);
            ListLEDButtons.Add(customLEDButton14);
            ListLEDButtons.Add(customLEDButton15);
            ListLEDButtons.Add(customLEDButton16);
            ListLEDButtons.Add(customLEDButton17);
            ListLEDButtons.Add(customLEDButton18);
            ListLEDButtons.Add(customLEDButton19);
            ListLEDButtons.Add(customLEDButton20);
            ListLEDButtons.Add(customLEDButton21);
            ListLEDButtons.Add(customLEDButton22);
            ListLEDButtons.Add(customLEDButton23);
            ListLEDButtons.Add(customLEDButton24);
            ListLEDButtons.Add(customLEDButton25);
            ListLEDButtons.Add(customLEDButton26);
            ListLEDButtons.Add(customLEDButton27);
            ListLEDButtons.Add(customLEDButton28);
            ListLEDButtons.Add(customLEDButton29);
            ListLEDButtons.Add(customLEDButton30);
            ListLEDButtons.Add(customLEDButton31);
            ListLEDButtons.Add(customLEDButton32);
            ListLEDButtons.Add(customLEDButton33);
            ListLEDButtons.Add(customLEDButton34);
            ListLEDButtons.Add(customLEDButton35);
            ListLEDButtons.Add(customLEDButton36);
            ListLEDButtons.Add(customLEDButton37);
            ListLEDButtons.Add(customLEDButton38);
            ListLEDButtons.Add(customLEDButton39);
            ListLEDButtons.Add(customLEDButton40);
            ListLEDButtons.Add(customLEDButton41);
            ListLEDButtons.Add(customLEDButton42);
            ListLEDButtons.Add(customLEDButton43);
            ListLEDButtons.Add(customLEDButton44);
            ListLEDButtons.Add(customLEDButton45);
            ListLEDButtons.Add(customLEDButton46);
            ListLEDButtons.Add(customLEDButton47);
            ListLEDButtons.Add(customLEDButton48);
            ListLEDButtons.Add(customLEDButton49);
            ListLEDButtons.Add(customLEDButton50);
            ListLEDButtons.Add(customLEDButton51);
            ListLEDButtons.Add(customLEDButton52);
            ListLEDButtons.Add(customLEDButton53);
            ListLEDButtons.Add(customLEDButton54);
            ListLEDButtons.Add(customLEDButton55);
            ListLEDButtons.Add(customLEDButton56);
            ListLEDButtons.Add(customLEDButton57);
            ListLEDButtons.Add(customLEDButton58);
            ListLEDButtons.Add(customLEDButton59);
            ListLEDButtons.Add(customLEDButton60);
            ListLEDButtons.Add(customLEDButton61);
            ListLEDButtons.Add(customLEDButton62);
            ListLEDButtons.Add(customLEDButton63);
            ListLEDButtons.Add(customLEDButton64);
            ListLEDButtons.Add(customLEDButton65);
            ListLEDButtons.Add(customLEDButton66);
            ListLEDButtons.Add(customLEDButton67);
            ListLEDButtons.Add(customLEDButton68);
            ListLEDButtons.Add(customLEDButton69);
            ListLEDButtons.Add(customLEDButton70);
            ListLEDButtons.Add(customLEDButton71);
            ListLEDButtons.Add(customLEDButton72);
            ListLEDButtons.Add(customLEDButton73);
            ListLEDButtons.Add(customLEDButton74);
            ListLEDButtons.Add(customLEDButton75);
            ListLEDButtons.Add(customLEDButton76);
            ListLEDButtons.Add(customLEDButton77);
            ListLEDButtons.Add(customLEDButton78);
            ListLEDButtons.Add(customLEDButton79);
            ListLEDButtons.Add(customLEDButton80);
            ListLEDButtons.Add(customLEDButton81);
            ListLEDButtons.Add(customLEDButton82);
            ListLEDButtons.Add(customLEDButton83);
            ListLEDButtons.Add(customLEDButton84);
            ListLEDButtons.Add(customLEDButton85);
            ListLEDButtons.Add(customLEDButton86);
            ListLEDButtons.Add(customLEDButton87);
            ListLEDButtons.Add(customLEDButton88);
            ListLEDButtons.Add(customLEDButton89);
            ListLEDButtons.Add(customLEDButton90);
            ListLEDButtons.Add(customLEDButton91);
            ListLEDButtons.Add(customLEDButton92);
            ListLEDButtons.Add(customLEDButton93);
            ListLEDButtons.Add(customLEDButton94);
            ListLEDButtons.Add(customLEDButton95);
            ListLEDButtons.Add(customLEDButton96);
            ListLEDButtons.Add(customLEDButton97);
            ListLEDButtons.Add(customLEDButton98);
            ListLEDButtons.Add(customLEDButton99);
            ListLEDButtons.Add(customLEDButton100);
            ListLEDButtons.Add(customLEDButton101);
            ListLEDButtons.Add(customLEDButton102);
            ListLEDButtons.Add(customLEDButton103);
            ListLEDButtons.Add(customLEDButton104);
            ListLEDButtons.Add(customLEDButton105);
            ListLEDButtons.Add(customLEDButton106);
            ListLEDButtons.Add(customLEDButton107);
            ListLEDButtons.Add(customLEDButton108);
            ListLEDButtons.Add(customLEDButton109);
            ListLEDButtons.Add(customLEDButton110);
            ListLEDButtons.Add(customLEDButton111);
            ListLEDButtons.Add(customLEDButton112);
            ListLEDButtons.Add(customLEDButton113);
            ListLEDButtons.Add(customLEDButton114);
            ListLEDButtons.Add(customLEDButton115);
            ListLEDButtons.Add(customLEDButton116);
            ListLEDButtons.Add(customLEDButton117);
            ListLEDButtons.Add(customLEDButton118);
            ListLEDButtons.Add(customLEDButton119);
            ListLEDButtons.Add(customLEDButton120);
            ListLEDButtons.Add(customLEDButton121);
            ListLEDButtons.Add(customLEDButton122);
            ListLEDButtons.Add(customLEDButton123);
            ListLEDButtons.Add(customLEDButton124);
            ListLEDButtons.Add(customLEDButton125);
        }

        private void customLEDButton1_Click(object sender, EventArgs e)
        {
            customLEDButton1.SetRGB(customColorPanel1);
        }

        private void customLEDButton2_Click(object sender, EventArgs e)
        {
            customLEDButton2.SetRGB(customColorPanel1);
        }

        private void customLEDButton3_Click(object sender, EventArgs e)
        {
            customLEDButton3.SetRGB(customColorPanel1);
        }

        private void customLEDButton4_Click(object sender, EventArgs e)
        {
            customLEDButton4.SetRGB(customColorPanel1);
        }

        private void customLEDButton5_Click(object sender, EventArgs e)
        {
            customLEDButton5.SetRGB(customColorPanel1);
        }

        private void customLEDButton6_Click(object sender, EventArgs e)
        {
            customLEDButton6.SetRGB(customColorPanel1);
        }

        private void customLEDButton7_Click(object sender, EventArgs e)
        {
            customLEDButton7.SetRGB(customColorPanel1);
        }

        private void customLEDButton8_Click(object sender, EventArgs e)
        {
            customLEDButton8.SetRGB(customColorPanel1);
        }

        private void customLEDButton9_Click(object sender, EventArgs e)
        {
            customLEDButton9.SetRGB(customColorPanel1);
        }

        private void customLEDButton10_Click(object sender, EventArgs e)
        {
            customLEDButton10.SetRGB(customColorPanel1);
        }

        private void customLEDButton11_Click(object sender, EventArgs e)
        {
            customLEDButton11.SetRGB(customColorPanel1);
        }

        private void customLEDButton12_Click(object sender, EventArgs e)
        {
            customLEDButton12.SetRGB(customColorPanel1);
        }

        private void customLEDButton13_Click(object sender, EventArgs e)
        {
            customLEDButton13.SetRGB(customColorPanel1);
        }

        private void customLEDButton14_Click(object sender, EventArgs e)
        {
            customLEDButton14.SetRGB(customColorPanel1);
        }

        private void customLEDButton15_Click(object sender, EventArgs e)
        {
            customLEDButton15.SetRGB(customColorPanel1);
        }

        private void customLEDButton16_Click(object sender, EventArgs e)
        {
            customLEDButton16.SetRGB(customColorPanel1);
        }

        private void customLEDButton17_Click(Object sender, EventArgs e)
        {
            customLEDButton17.SetRGB(customColorPanel1);
        }

        private void customLEDButton18_Click(object sender, EventArgs e)
        {
            customLEDButton18.SetRGB(customColorPanel1);
        }

        private void customLEDButton19_Click(object sender, EventArgs e)
        {
            customLEDButton19.SetRGB(customColorPanel1);
        }

        private void customLEDButton20_Click(object sender, EventArgs e)
        {
            customLEDButton20.SetRGB(customColorPanel1);
        }

        private void customLEDButton21_Click(object sender, EventArgs e)
        {
            customLEDButton21.SetRGB(customColorPanel1);
        }

        private void customLEDButton22_Click(object sender, EventArgs e)
        {
            customLEDButton22.SetRGB(customColorPanel1);
        }

        private void customLEDButton23_Click(object sender, EventArgs e)
        {
            customLEDButton23.SetRGB(customColorPanel1);
        }

        private void customLEDButton24_Click(object sender, EventArgs e)
        {
            customLEDButton24.SetRGB(customColorPanel1);
        }

        private void customLEDButton25_Click(object sender, EventArgs e)
        {
            customLEDButton25.SetRGB(customColorPanel1);
        }
        private void customLEDButton26_Click(object sender, EventArgs e)
        {
            customLEDButton26.SetRGB(customColorPanel2);
        }

        private void customLEDButton27_Click(object sender, EventArgs e)
        {
            customLEDButton27.SetRGB(customColorPanel2);
        }

        private void customLEDButton28_Click(object sender, EventArgs e)
        {
            customLEDButton28.SetRGB(customColorPanel2);
        }

        private void customLEDButton29_Click(object sender, EventArgs e)
        {
            customLEDButton29.SetRGB(customColorPanel2);
        }

        private void customLEDButton30_Click(object sender, EventArgs e)
        {
            customLEDButton30.SetRGB(customColorPanel2);
        }

        private void customLEDButton31_Click(object sender, EventArgs e)
        {
            customLEDButton31.SetRGB(customColorPanel2);
        }

        private void customLEDButton32_Click(object sender, EventArgs e)
        {
            customLEDButton32.SetRGB(customColorPanel2);
        }

        private void customLEDButton33_Click(object sender, EventArgs e)
        {
            customLEDButton33.SetRGB(customColorPanel2);
        }

        private void customLEDButton34_Click(object sender, EventArgs e)
        {
            customLEDButton34.SetRGB(customColorPanel2);
        }

        private void customLEDButton35_Click(object sender, EventArgs e)
        {
            customLEDButton35.SetRGB(customColorPanel2);
        }

        private void customLEDButton36_Click(object sender, EventArgs e)
        {
            customLEDButton36.SetRGB(customColorPanel2);
        }

        private void customLEDButton37_Click(object sender, EventArgs e)
        {
            customLEDButton37.SetRGB(customColorPanel2);
        }

        private void customLEDButton38_Click(object sender, EventArgs e)
        {
            customLEDButton38.SetRGB(customColorPanel2);
        }

        private void customLEDButton39_Click(object sender, EventArgs e)
        {
            customLEDButton39.SetRGB(customColorPanel2);
        }

        private void customLEDButton40_Click(object sender, EventArgs e)
        {
            customLEDButton40.SetRGB(customColorPanel2);
        }

        private void customLEDButton41_Click(object sender, EventArgs e)
        {
            customLEDButton41.SetRGB(customColorPanel2);
        }

        private void customLEDButton42_Click(Object sender, EventArgs e)
        {
            customLEDButton42.SetRGB(customColorPanel2);
        }

        private void customLEDButton43_Click(object sender, EventArgs e)
        {
            customLEDButton43.SetRGB(customColorPanel2);
        }

        private void customLEDButton44_Click(object sender, EventArgs e)
        {
            customLEDButton44.SetRGB(customColorPanel2);
        }

        private void customLEDButton45_Click(object sender, EventArgs e)
        {
            customLEDButton45.SetRGB(customColorPanel2);
        }

        private void customLEDButton46_Click(object sender, EventArgs e)
        {
            customLEDButton46.SetRGB(customColorPanel2);
        }

        private void customLEDButton47_Click(object sender, EventArgs e)
        {
            customLEDButton47.SetRGB(customColorPanel2);
        }

        private void customLEDButton48_Click(object sender, EventArgs e)
        {
            customLEDButton48.SetRGB(customColorPanel2);
        }

        private void customLEDButton49_Click(object sender, EventArgs e)
        {
            customLEDButton49.SetRGB(customColorPanel2);
        }

        private void customLEDButton50_Click(object sender, EventArgs e)
        {
            customLEDButton50.SetRGB(customColorPanel2);
        }

        private void customLEDButton51_Click(object sender, EventArgs e)
        {
            customLEDButton51.SetRGB(customColorPanel3);
        }

        private void customLEDButton52_Click(object sender, EventArgs e)
        {
            customLEDButton52.SetRGB(customColorPanel3);
        }

        private void customLEDButton53_Click(object sender, EventArgs e)
        {
            customLEDButton53.SetRGB(customColorPanel3);
        }

        private void customLEDButton54_Click(object sender, EventArgs e)
        {
            customLEDButton54.SetRGB(customColorPanel3);
        }

        private void customLEDButton55_Click(object sender, EventArgs e)
        {
            customLEDButton55.SetRGB(customColorPanel3);
        }

        private void customLEDButton56_Click(object sender, EventArgs e)
        {
            customLEDButton56.SetRGB(customColorPanel3);
        }

        private void customLEDButton57_Click(object sender, EventArgs e)
        {
            customLEDButton57.SetRGB(customColorPanel3);
        }

        private void customLEDButton58_Click(object sender, EventArgs e)
        {
            customLEDButton58.SetRGB(customColorPanel3);
        }

        private void customLEDButton59_Click(object sender, EventArgs e)
        {
            customLEDButton59.SetRGB(customColorPanel3);
        }

        private void customLEDButton60_Click(object sender, EventArgs e)
        {
            customLEDButton60.SetRGB(customColorPanel3);
        }

        private void customLEDButton61_Click(object sender, EventArgs e)
        {
            customLEDButton61.SetRGB(customColorPanel3);
        }

        private void customLEDButton62_Click(object sender, EventArgs e)
        {
            customLEDButton62.SetRGB(customColorPanel3);
        }

        private void customLEDButton63_Click(object sender, EventArgs e)
        {
            customLEDButton63.SetRGB(customColorPanel3);
        }

        private void customLEDButton64_Click(object sender, EventArgs e)
        {
            customLEDButton64.SetRGB(customColorPanel3);
        }

        private void customLEDButton65_Click(object sender, EventArgs e)
        {
            customLEDButton65.SetRGB(customColorPanel3);
        }

        private void customLEDButton66_Click(object sender, EventArgs e)
        {
            customLEDButton66.SetRGB(customColorPanel3);
        }

        private void customLEDButton67_Click(object sender, EventArgs e)
        {
            customLEDButton67.SetRGB(customColorPanel3);
        }

        private void customLEDButton68_Click(object sender, EventArgs e)
        {
            customLEDButton68.SetRGB(customColorPanel3);
        }

        private void customLEDButton69_Click(object sender, EventArgs e)
        {
            customLEDButton69.SetRGB(customColorPanel3);
        }

        private void customLEDButton70_Click(object sender, EventArgs e)
        {
            customLEDButton70.SetRGB(customColorPanel3);
        }

        private void customLEDButton71_Click(object sender, EventArgs e)
        {
            customLEDButton71.SetRGB(customColorPanel3);
        }

        private void customLEDButton72_Click(object sender, EventArgs e)
        {
            customLEDButton72.SetRGB(customColorPanel3);
        }

        private void customLEDButton73_Click(object sender, EventArgs e)
        {
            customLEDButton73.SetRGB(customColorPanel3);
        }

        private void customLEDButton74_Click(object sender, EventArgs e)
        {
            customLEDButton74.SetRGB(customColorPanel3);
        }

        private void customLEDButton75_Click(object sender, EventArgs e)
        {
            customLEDButton75.SetRGB(customColorPanel3);
        }

        private void customLEDButton76_Click(object sender, EventArgs e)
        {
            customLEDButton76.SetRGB(customColorPanel4);
        }

        private void customLEDButton77_Click(object sender, EventArgs e)
        {
            customLEDButton77.SetRGB(customColorPanel4);
        }

        private void customLEDButton78_Click(object sender, EventArgs e)
        {
            customLEDButton78.SetRGB(customColorPanel4);
        }

        private void customLEDButton79_Click(object sender, EventArgs e)
        {
            customLEDButton79.SetRGB(customColorPanel4);
        }

        private void customLEDButton80_Click(object sender, EventArgs e)
        {
            customLEDButton80.SetRGB(customColorPanel4);
        }

        private void customLEDButton81_Click(object sender, EventArgs e)
        {
            customLEDButton81.SetRGB(customColorPanel4);
        }

        private void customLEDButton82_Click(object sender, EventArgs e)
        {
            customLEDButton82.SetRGB(customColorPanel4);
        }

        private void customLEDButton83_Click(object sender, EventArgs e)
        {
            customLEDButton83.SetRGB(customColorPanel4);
        }

        private void customLEDButton84_Click(object sender, EventArgs e)
        {
            customLEDButton84.SetRGB(customColorPanel4);
        }

        private void customLEDButton85_Click(object sender, EventArgs e)
        {
            customLEDButton85.SetRGB(customColorPanel4);
        }

        private void customLEDButton86_Click(object sender, EventArgs e)
        {
            customLEDButton86.SetRGB(customColorPanel4);
        }

        private void customLEDButton87_Click(object sender, EventArgs e)
        {
            customLEDButton87.SetRGB(customColorPanel4);
        }

        private void customLEDButton88_Click(object sender, EventArgs e)
        {
            customLEDButton88.SetRGB(customColorPanel4);
        }

        private void customLEDButton89_Click(object sender, EventArgs e)
        {
            customLEDButton89.SetRGB(customColorPanel4);
        }

        private void customLEDButton90_Click(object sender, EventArgs e)
        {
            customLEDButton90.SetRGB(customColorPanel4);
        }

        private void customLEDButton91_Click(object sender, EventArgs e)
        {
            customLEDButton91.SetRGB(customColorPanel4);
        }

        private void customLEDButton92_Click(object sender, EventArgs e)
        {
            customLEDButton92.SetRGB(customColorPanel4);
        }

        private void customLEDButton93_Click(object sender, EventArgs e)
        {
            customLEDButton93.SetRGB(customColorPanel4);
        }

        private void customLEDButton94_Click(object sender, EventArgs e)
        {
            customLEDButton94.SetRGB(customColorPanel4);
        }

        private void customLEDButton95_Click(object sender, EventArgs e)
        {
            customLEDButton95.SetRGB(customColorPanel4);
        }

        private void customLEDButton96_Click(object sender, EventArgs e)
        {
            customLEDButton96.SetRGB(customColorPanel4);
        }

        private void customLEDButton97_Click(object sender, EventArgs e)
        {
            customLEDButton97.SetRGB(customColorPanel4);
        }

        private void customLEDButton98_Click(object sender, EventArgs e)
        {
            customLEDButton98.SetRGB(customColorPanel4);
        }

        private void customLEDButton99_Click(object sender, EventArgs e)
        {
            customLEDButton99.SetRGB(customColorPanel4);
        }

        private void customLEDButton100_Click(object sender, EventArgs e)
        {
            customLEDButton100.SetRGB(customColorPanel4);
        }

        private void customLEDButton101_Click(object sender, EventArgs e)
        {
            customLEDButton101.SetRGB(customColorPanel5);
        }

        private void customLEDButton102_Click(object sender, EventArgs e)
        {
            customLEDButton102.SetRGB(customColorPanel5);
        }

        private void customLEDButton103_Click(object sender, EventArgs e)
        {
            customLEDButton103.SetRGB(customColorPanel5);
        }

        private void customLEDButton104_Click(object sender, EventArgs e)
        {
            customLEDButton104.SetRGB(customColorPanel5);
        }

        private void customLEDButton105_Click(object sender, EventArgs e)
        {
            customLEDButton105.SetRGB(customColorPanel5);
        }

        private void customLEDButton106_Click(object sender, EventArgs e)
        {
            customLEDButton106.SetRGB(customColorPanel5);
        }

        private void customLEDButton107_Click(object sender, EventArgs e)
        {
            customLEDButton107.SetRGB(customColorPanel5);
        }

        private void customLEDButton108_Click(object sender, EventArgs e)
        {
            customLEDButton108.SetRGB(customColorPanel5);
        }

        private void customLEDButton109_Click(object sender, EventArgs e)
        {
            customLEDButton109.SetRGB(customColorPanel5);
        }

        private void customLEDButton110_Click(object sender, EventArgs e)
        {
            customLEDButton110.SetRGB(customColorPanel5);
        }

        private void customLEDButton111_Click(object sender, EventArgs e)
        {
            customLEDButton111.SetRGB(customColorPanel5);
        }

        private void customLEDButton112_Click(object sender, EventArgs e)
        {
            customLEDButton112.SetRGB(customColorPanel5);
        }

        private void customLEDButton113_Click(object sender, EventArgs e)
        {
            customLEDButton113.SetRGB(customColorPanel5);
        }

        private void customLEDButton114_Click(object sender, EventArgs e)
        {
            customLEDButton114.SetRGB(customColorPanel5);
        }

        private void customLEDButton115_Click(object sender, EventArgs e)
        {
            customLEDButton115.SetRGB(customColorPanel5);
        }

        private void customLEDButton116_Click(object sender, EventArgs e)
        {
            customLEDButton116.SetRGB(customColorPanel5);
        }

        private void customLEDButton117_Click(object sender, EventArgs e)
        {
            customLEDButton117.SetRGB(customColorPanel5);
        }

        private void customLEDButton118_Click(object sender, EventArgs e)
        {
            customLEDButton118.SetRGB(customColorPanel5);
        }

        private void customLEDButton119_Click(object sender, EventArgs e)
        {
            customLEDButton119.SetRGB(customColorPanel5);
        }

        private void customLEDButton120_Click(object sender, EventArgs e)
        {
            customLEDButton120.SetRGB(customColorPanel5);
        }

        private void customLEDButton121_Click(object sender, EventArgs e)
        {
            customLEDButton121.SetRGB(customColorPanel5);
        }

        private void customLEDButton122_Click(object sender, EventArgs e)
        {
            customLEDButton122.SetRGB(customColorPanel5);
        }

        private void customLEDButton123_Click(object sender, EventArgs e)
        {
            customLEDButton123.SetRGB(customColorPanel5);
        }

        private void customLEDButton124_Click(object sender, EventArgs e)
        {
            customLEDButton124.SetRGB(customColorPanel5);
        }

        private void customLEDButton125_Click(object sender, EventArgs e)
        {
            customLEDButton125.SetRGB(customColorPanel5);
        }

        private void makeAllRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (CustomLEDButton button in ListLEDButtons)
            {
                button.Red = random.Next(0, 255);
                button.Green = random.Next(0, 255);
                button.Blue = random.Next(0, 255);
                button.BackColor = Color.FromArgb(255, button.Red, button.Green, button.Blue);
            }

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CustomLEDButton button in ListLEDButtons)
            {
                button.Red = 255;
                button.Green = 0;
                button.Blue = 0;
                button.BackColor = Color.FromArgb(255, button.Red, button.Green, button.Blue);
            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CustomLEDButton button in ListLEDButtons)
            {
                button.Red = 0;
                button.Green = 255;
                button.Blue = 0;
                button.BackColor = Color.FromArgb(255, button.Red, button.Green, button.Blue);
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CustomLEDButton button in ListLEDButtons)
            {
                button.Red = 0;
                button.Green = 0;
                button.Blue = 255;
                button.BackColor = Color.FromArgb(255, button.Red, button.Green, button.Blue);
            }
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CustomLEDButton button in ListLEDButtons)
            {
                button.Red = 255;
                button.Green = 255;
                button.Blue = 255;
                button.BackColor = Color.FromArgb(255, button.Red, button.Green, button.Blue);
            }
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                tabControl1.SelectTab(4);
            }
        }




    }
}
