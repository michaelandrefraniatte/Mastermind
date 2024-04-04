using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static Region rg;
        private static GraphicsPath gp;
        private static List<Color> colors = new List<Color>(), seecolors = new List<Color>(), randcolors = new List<Color>();
        private static int inccolor1line1 = 0;
        private static int inccolor2line1 = 0;
        private static int inccolor3line1 = 0;
        private static int inccolor4line1 = 0;
        private static int inccolor1line2 = 0;
        private static int inccolor2line2 = 0;
        private static int inccolor3line2 = 0;
        private static int inccolor4line2 = 0;
        private static int inccolor1line3 = 0;
        private static int inccolor2line3 = 0;
        private static int inccolor3line3 = 0;
        private static int inccolor4line3 = 0;
        private static int inccolor1line4 = 0;
        private static int inccolor2line4 = 0;
        private static int inccolor3line4 = 0;
        private static int inccolor4line4 = 0;
        private static int inccolor1line5 = 0;
        private static int inccolor2line5 = 0;
        private static int inccolor3line5 = 0;
        private static int inccolor4line5 = 0;
        private static int inccolor1line6 = 0;
        private static int inccolor2line6 = 0;
        private static int inccolor3line6 = 0;
        private static int inccolor4line6 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            gp = new GraphicsPath();
            gp.AddEllipse(pbcolor1linesee.DisplayRectangle);
            rg = new Region(gp);
            pbcolor1linesee.Region = rg;
            pbcolor2linesee.Region = rg;
            pbcolor3linesee.Region = rg;
            pbcolor4linesee.Region = rg;
            pbcolor1line1.Region = rg;
            pbcolor2line1.Region = rg;
            pbcolor3line1.Region = rg;
            pbcolor4line1.Region = rg;
            pbcolor1line2.Region = rg;
            pbcolor2line2.Region = rg;
            pbcolor3line2.Region = rg;
            pbcolor4line2.Region = rg;
            pbcolor1line3.Region = rg;
            pbcolor2line3.Region = rg;
            pbcolor3line3.Region = rg;
            pbcolor4line3.Region = rg;
            pbcolor1line4.Region = rg;
            pbcolor2line4.Region = rg;
            pbcolor3line4.Region = rg;
            pbcolor4line4.Region = rg;
            pbcolor1line5.Region = rg;
            pbcolor2line5.Region = rg;
            pbcolor3line5.Region = rg;
            pbcolor4line5.Region = rg;
            pbcolor1line6.Region = rg;
            pbcolor2line6.Region = rg;
            pbcolor3line6.Region = rg;
            pbcolor4line6.Region = rg;
            gp = new GraphicsPath();
            gp.AddEllipse(pbcheck1line1.DisplayRectangle);
            rg = new Region(gp);
            pbcheck1line1.Region = rg;
            pbcheck2line1.Region = rg;
            pbcheck3line1.Region = rg;
            pbcheck4line1.Region = rg;
            pbcheck1line2.Region = rg;
            pbcheck2line2.Region = rg;
            pbcheck3line2.Region = rg;
            pbcheck4line2.Region = rg;
            pbcheck1line3.Region = rg;
            pbcheck2line3.Region = rg;
            pbcheck3line3.Region = rg;
            pbcheck4line3.Region = rg;
            pbcheck1line4.Region = rg;
            pbcheck2line4.Region = rg;
            pbcheck3line4.Region = rg;
            pbcheck4line4.Region = rg;
            pbcheck1line5.Region = rg;
            pbcheck2line5.Region = rg;
            pbcheck3line5.Region = rg;
            pbcheck4line5.Region = rg;
            pbcheck1line6.Region = rg;
            pbcheck2line6.Region = rg;
            pbcheck3line6.Region = rg;
            pbcheck4line6.Region = rg;
            seecolors = RandomizeColors();
        }
        private void btsee_Click(object sender, EventArgs e)
        {
            pbcolor1linesee.BackColor = seecolors[0];
            pbcolor2linesee.BackColor = seecolors[1];
            pbcolor3linesee.BackColor = seecolors[2];
            pbcolor4linesee.BackColor = seecolors[3];
        }
        private void btnew_Click(object sender, EventArgs e)
        {
            seecolors = RandomizeColors();
            pbcolor1linesee.BackColor = Color.Silver;
            pbcolor2linesee.BackColor = Color.Silver;
            pbcolor3linesee.BackColor = Color.Silver;
            pbcolor4linesee.BackColor = Color.Silver;
            pbcolor1line1.BackColor = Color.Silver;
            pbcolor2line1.BackColor = Color.Silver;
            pbcolor3line1.BackColor = Color.Silver;
            pbcolor4line1.BackColor = Color.Silver;
            pbcolor1line2.BackColor = Color.Silver;
            pbcolor2line2.BackColor = Color.Silver;
            pbcolor3line2.BackColor = Color.Silver;
            pbcolor4line2.BackColor = Color.Silver;
            pbcolor1line3.BackColor = Color.Silver;
            pbcolor2line3.BackColor = Color.Silver;
            pbcolor3line3.BackColor = Color.Silver;
            pbcolor4line3.BackColor = Color.Silver;
            pbcolor1line4.BackColor = Color.Silver;
            pbcolor2line4.BackColor = Color.Silver;
            pbcolor3line4.BackColor = Color.Silver;
            pbcolor4line4.BackColor = Color.Silver;
            pbcolor1line5.BackColor = Color.Silver;
            pbcolor2line5.BackColor = Color.Silver;
            pbcolor3line5.BackColor = Color.Silver;
            pbcolor4line5.BackColor = Color.Silver;
            pbcolor1line6.BackColor = Color.Silver;
            pbcolor2line6.BackColor = Color.Silver;
            pbcolor3line6.BackColor = Color.Silver;
            pbcolor4line6.BackColor = Color.Silver;
            pbcheck1line1.BackColor = Color.Silver;
            pbcheck2line1.BackColor = Color.Silver;
            pbcheck3line1.BackColor = Color.Silver;
            pbcheck4line1.BackColor = Color.Silver;
            pbcheck1line2.BackColor = Color.Silver;
            pbcheck2line2.BackColor = Color.Silver;
            pbcheck3line2.BackColor = Color.Silver;
            pbcheck4line2.BackColor = Color.Silver;
            pbcheck1line3.BackColor = Color.Silver;
            pbcheck2line3.BackColor = Color.Silver;
            pbcheck3line3.BackColor = Color.Silver;
            pbcheck4line3.BackColor = Color.Silver;
            pbcheck1line4.BackColor = Color.Silver;
            pbcheck2line4.BackColor = Color.Silver;
            pbcheck3line4.BackColor = Color.Silver;
            pbcheck4line4.BackColor = Color.Silver;
            pbcheck1line5.BackColor = Color.Silver;
            pbcheck2line5.BackColor = Color.Silver;
            pbcheck3line5.BackColor = Color.Silver;
            pbcheck4line5.BackColor = Color.Silver;
            pbcheck1line6.BackColor = Color.Silver;
            pbcheck2line6.BackColor = Color.Silver;
            pbcheck3line6.BackColor = Color.Silver;
            pbcheck4line6.BackColor = Color.Silver;
        }
        public static List<Color> RandomizeColors()
        {
            colors = new List<Color>();
            colors.Add(Color.Orange);
            colors.Add(Color.DodgerBlue);
            colors.Add(Color.Red);
            colors.Add(Color.Purple);
            colors.Add(Color.Green);
            List<Color> list = colors;
            List<Color> randomizedList = new List<Color>();
            Random rnd = new Random();
            while (list.Count > 0)
            {
                int index = rnd.Next(0, list.Count);
                randomizedList.Add(list[index]);
                list.RemoveAt(index);
            }
            colors = new List<Color>();
            colors.Add(Color.Orange);
            colors.Add(Color.DodgerBlue);
            colors.Add(Color.Red);
            colors.Add(Color.Purple);
            colors.Add(Color.Green);
            return randomizedList;
        }
        private void pbcolor1line1_Click(object sender, EventArgs e)
        {
            if (inccolor1line1 > 4)
                inccolor1line1 = 0;
            pbcolor1line1.BackColor = colors.ElementAt(inccolor1line1);
            inccolor1line1++;
        }
        private void pbcolor2line1_Click(object sender, EventArgs e)
        {
            if (inccolor2line1 > 4)
                inccolor2line1 = 0;
            pbcolor2line1.BackColor = colors.ElementAt(inccolor2line1);
            inccolor2line1++;
        }
        private void pbcolor3line1_Click(object sender, EventArgs e)
        {
            if (inccolor3line1 > 4)
                inccolor3line1 = 0;
            pbcolor3line1.BackColor = colors.ElementAt(inccolor3line1);
            inccolor3line1++;
        }
        private void pbcolor4line1_Click(object sender, EventArgs e)
        {
            if (inccolor4line1 > 4)
                inccolor4line1 = 0;
            pbcolor4line1.BackColor = colors.ElementAt(inccolor4line1);
            inccolor4line1++;
        }
        private void pbcolor1line2_Click(object sender, EventArgs e)
        {
            if (inccolor1line2 > 4)
                inccolor1line2 = 0;
            pbcolor1line2.BackColor = colors.ElementAt(inccolor1line2);
            inccolor1line2++;
        }
        private void pbcolor2line2_Click(object sender, EventArgs e)
        {
            if (inccolor2line2 > 4)
                inccolor2line2 = 0;
            pbcolor2line2.BackColor = colors.ElementAt(inccolor2line2);
            inccolor2line2++;
        }
        private void pbcolor3line2_Click(object sender, EventArgs e)
        {
            if (inccolor3line2 > 4)
                inccolor3line2 = 0;
            pbcolor3line2.BackColor = colors.ElementAt(inccolor3line2);
            inccolor3line2++;
        }
        private void pbcolor4line2_Click(object sender, EventArgs e)
        {
            if (inccolor4line2 > 4)
                inccolor4line2 = 0;
            pbcolor4line2.BackColor = colors.ElementAt(inccolor4line2);
            inccolor4line2++;
        }
        private void pbcolor1line3_Click(object sender, EventArgs e)
        {
            if (inccolor1line3 > 4)
                inccolor1line3 = 0;
            pbcolor1line3.BackColor = colors.ElementAt(inccolor1line3);
            inccolor1line3++;
        }
        private void pbcolor2line3_Click(object sender, EventArgs e)
        {
            if (inccolor2line3 > 4)
                inccolor2line3 = 0;
            pbcolor2line3.BackColor = colors.ElementAt(inccolor2line3);
            inccolor2line3++;
        }
        private void pbcolor3line3_Click(object sender, EventArgs e)
        {
            if (inccolor3line3 > 4)
                inccolor3line3 = 0;
            pbcolor3line3.BackColor = colors.ElementAt(inccolor3line3);
            inccolor3line3++;
        }
        private void pbcolor4line3_Click(object sender, EventArgs e)
        {
            if (inccolor4line3 > 4)
                inccolor4line3 = 0;
            pbcolor4line3.BackColor = colors.ElementAt(inccolor4line3);
            inccolor4line3++;
        }
        private void pbcolor1line4_Click(object sender, EventArgs e)
        {
            if (inccolor1line4 > 4)
                inccolor1line4 = 0;
            pbcolor1line4.BackColor = colors.ElementAt(inccolor1line4);
            inccolor1line4++;
        }
        private void pbcolor2line4_Click(object sender, EventArgs e)
        {
            if (inccolor2line4 > 4)
                inccolor2line4 = 0;
            pbcolor2line4.BackColor = colors.ElementAt(inccolor2line4);
            inccolor2line4++;
        }
        private void pbcolor3line4_Click(object sender, EventArgs e)
        {
            if (inccolor3line4 > 4)
                inccolor3line4 = 0;
            pbcolor3line4.BackColor = colors.ElementAt(inccolor3line4);
            inccolor3line4++;
        }
        private void pbcolor4line4_Click(object sender, EventArgs e)
        {
            if (inccolor4line4 > 4)
                inccolor4line4 = 0;
            pbcolor4line4.BackColor = colors.ElementAt(inccolor4line4);
            inccolor4line4++;
        }
        private void pbcolor1line5_Click(object sender, EventArgs e)
        {
            if (inccolor1line5 > 4)
                inccolor1line5 = 0;
            pbcolor1line5.BackColor = colors.ElementAt(inccolor1line5);
            inccolor1line5++;
        }
        private void pbcolor2line5_Click(object sender, EventArgs e)
        {
            if (inccolor2line5 > 4)
                inccolor2line5 = 0;
            pbcolor2line5.BackColor = colors.ElementAt(inccolor2line5);
            inccolor2line5++;
        }
        private void pbcolor3line5_Click(object sender, EventArgs e)
        {
            if (inccolor3line5 > 4)
                inccolor3line5 = 0;
            pbcolor3line5.BackColor = colors.ElementAt(inccolor3line5);
            inccolor3line5++;
        }
        private void pbcolor4line5_Click(object sender, EventArgs e)
        {
            if (inccolor4line5 > 4)
                inccolor4line5 = 0;
            pbcolor4line5.BackColor = colors.ElementAt(inccolor4line5);
            inccolor4line5++;
        }
        private void pbcolor1line6_Click(object sender, EventArgs e)
        {
            if (inccolor1line6 > 4)
                inccolor1line6 = 0;
            pbcolor1line6.BackColor = colors.ElementAt(inccolor1line6);
            inccolor1line6++;
        }
        private void pbcolor2line6_Click(object sender, EventArgs e)
        {
            if (inccolor2line6 > 4)
                inccolor2line6 = 0;
            pbcolor2line6.BackColor = colors.ElementAt(inccolor2line6);
            inccolor2line6++;
        }
        private void pbcolor3line6_Click(object sender, EventArgs e)
        {
            if (inccolor3line6 > 4)
                inccolor3line6 = 0;
            pbcolor3line6.BackColor = colors.ElementAt(inccolor3line6);
            inccolor3line6++;
        }
        private void pbcolor4line6_Click(object sender, EventArgs e)
        {
            if (inccolor4line6 > 4)
                inccolor4line6 = 0;
            pbcolor4line6.BackColor = colors.ElementAt(inccolor4line6);
            inccolor4line6++;
        }
        private void btcheckline1_Click(object sender, EventArgs e)
        {
        }
        private void btcheckline2_Click(object sender, EventArgs e)
        {
        }
        private void btcheckline3_Click(object sender, EventArgs e)
        {
        }
        private void btcheckline4_Click(object sender, EventArgs e)
        {
        }
        private void btcheckline5_Click(object sender, EventArgs e)
        {
        }
        private void btcheckline6_Click(object sender, EventArgs e)
        {
        }
    }
}