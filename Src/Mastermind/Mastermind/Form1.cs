using System;
using System.Collections;
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
        private Region rg;
        private GraphicsPath gp;
        private List<Color> colors = new List<Color>(), seecolors = new List<Color>(), checkcolors = new List<Color>();
        private Color color = Color.Empty;
        private int inccolor1line1 = 0;
        private int inccolor2line1 = 0;
        private int inccolor3line1 = 0;
        private int inccolor4line1 = 0;
        private int inccolor1line2 = 0;
        private int inccolor2line2 = 0;
        private int inccolor3line2 = 0;
        private int inccolor4line2 = 0;
        private int inccolor1line3 = 0;
        private int inccolor2line3 = 0;
        private int inccolor3line3 = 0;
        private int inccolor4line3 = 0;
        private int inccolor1line4 = 0;
        private int inccolor2line4 = 0;
        private int inccolor3line4 = 0;
        private int inccolor4line4 = 0;
        private int inccolor1line5 = 0;
        private int inccolor2line5 = 0;
        private int inccolor3line5 = 0;
        private int inccolor4line5 = 0;
        private int inccolor1line6 = 0;
        private int inccolor2line6 = 0;
        private int inccolor3line6 = 0;
        private int inccolor4line6 = 0;
        private bool enablecheckline1 = true;
        private bool enablecheckline2 = true;
        private bool enablecheckline3 = true;
        private bool enablecheckline4 = true;
        private bool enablecheckline5 = true;
        private bool enablecheckline6 = true;
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
            seecolors.RemoveAt(6);
            seecolors.RemoveAt(5);
            seecolors.RemoveAt(4);
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
            seecolors.RemoveAt(6);
            seecolors.RemoveAt(5);
            seecolors.RemoveAt(4);
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
            enablecheckline1 = true;
            enablecheckline2 = true;
            enablecheckline3 = true;
            enablecheckline4 = true;
            enablecheckline5 = true;
            enablecheckline6 = true;
            btcheckline1.Enabled = true;
            btcheckline2.Enabled = true;
            btcheckline3.Enabled = true;
            btcheckline4.Enabled = true;
            btcheckline5.Enabled = true;
            btcheckline6.Enabled = true;
        }
        public List<Color> RandomizeColors()
        {
            colors = new List<Color>();
            colors.Add(Color.Orange);
            colors.Add(Color.DodgerBlue);
            colors.Add(Color.Red);
            colors.Add(Color.Purple);
            colors.Add(Color.Green);
            colors.Add(Color.Black);
            colors.Add(Color.White);
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
            colors.Add(Color.Black);
            colors.Add(Color.White);
            return randomizedList;
        }
        private void pbcolor1line1_Click(object sender, EventArgs e)
        {
            if (enablecheckline1)
            {
                if (inccolor1line1 > 6)
                    inccolor1line1 = 0;
                pbcolor1line1.BackColor = colors.ElementAt(inccolor1line1);
                inccolor1line1++;
            }
        }
        private void pbcolor2line1_Click(object sender, EventArgs e)
        {
            if (enablecheckline1)
            {
                if (inccolor2line1 > 6)
                    inccolor2line1 = 0;
                pbcolor2line1.BackColor = colors.ElementAt(inccolor2line1);
                inccolor2line1++;
            }
        }
        private void pbcolor3line1_Click(object sender, EventArgs e)
        {
            if (enablecheckline1)
            {
                if (inccolor3line1 > 6)
                    inccolor3line1 = 0;
                pbcolor3line1.BackColor = colors.ElementAt(inccolor3line1);
                inccolor3line1++;
            }
        }
        private void pbcolor4line1_Click(object sender, EventArgs e)
        {
            if (enablecheckline1)
            {
                if (inccolor4line1 > 6)
                    inccolor4line1 = 0;
                pbcolor4line1.BackColor = colors.ElementAt(inccolor4line1);
                inccolor4line1++;
            }
        }
        private void pbcolor1line2_Click(object sender, EventArgs e)
        {
            if (enablecheckline2 & !enablecheckline1)
            {
                if (inccolor1line2 > 6)
                    inccolor1line2 = 0;
                pbcolor1line2.BackColor = colors.ElementAt(inccolor1line2);
                inccolor1line2++;
            }
        }
        private void pbcolor2line2_Click(object sender, EventArgs e)
        {
            if (enablecheckline2 & !enablecheckline1)
            {
                if (inccolor2line2 > 6)
                    inccolor2line2 = 0;
                pbcolor2line2.BackColor = colors.ElementAt(inccolor2line2);
                inccolor2line2++;
            }
        }
        private void pbcolor3line2_Click(object sender, EventArgs e)
        {
            if (enablecheckline2 & !enablecheckline1)
            {
                if (inccolor3line2 > 6)
                    inccolor3line2 = 0;
                pbcolor3line2.BackColor = colors.ElementAt(inccolor3line2);
                inccolor3line2++;
            }
        }
        private void pbcolor4line2_Click(object sender, EventArgs e)
        {
            if (enablecheckline2 & !enablecheckline1)
            {
                if (inccolor4line2 > 6)
                    inccolor4line2 = 0;
                pbcolor4line2.BackColor = colors.ElementAt(inccolor4line2);
                inccolor4line2++;
            }
        }
        private void pbcolor1line3_Click(object sender, EventArgs e)
        {
            if (enablecheckline3 & !enablecheckline2)
            {
                if (inccolor1line3 > 6)
                    inccolor1line3 = 0;
                pbcolor1line3.BackColor = colors.ElementAt(inccolor1line3);
                inccolor1line3++;
            }
        }
        private void pbcolor2line3_Click(object sender, EventArgs e)
        {
            if (enablecheckline3 & !enablecheckline2)
            {
                if (inccolor2line3 > 6)
                    inccolor2line3 = 0;
                pbcolor2line3.BackColor = colors.ElementAt(inccolor2line3);
                inccolor2line3++;
            }
        }
        private void pbcolor3line3_Click(object sender, EventArgs e)
        {
            if (enablecheckline3 & !enablecheckline2)
            {
                if (inccolor3line3 > 6)
                    inccolor3line3 = 0;
                pbcolor3line3.BackColor = colors.ElementAt(inccolor3line3);
                inccolor3line3++;
            }
        }
        private void pbcolor4line3_Click(object sender, EventArgs e)
        {
            if (enablecheckline3 & !enablecheckline2)
            {
                if (inccolor4line3 > 6)
                    inccolor4line3 = 0;
                pbcolor4line3.BackColor = colors.ElementAt(inccolor4line3);
                inccolor4line3++;
            }
        }
        private void pbcolor1line4_Click(object sender, EventArgs e)
        {
            if (enablecheckline4 & !enablecheckline3)
            {
                if (inccolor1line4 > 6)
                    inccolor1line4 = 0;
                pbcolor1line4.BackColor = colors.ElementAt(inccolor1line4);
                inccolor1line4++;
            }
        }
        private void pbcolor2line4_Click(object sender, EventArgs e)
        {
            if (enablecheckline4 & !enablecheckline3)
            {
                if (inccolor2line4 > 6)
                    inccolor2line4 = 0;
                pbcolor2line4.BackColor = colors.ElementAt(inccolor2line4);
                inccolor2line4++;
            }
        }
        private void pbcolor3line4_Click(object sender, EventArgs e)
        {
            if (enablecheckline4 & !enablecheckline3)
            {
                if (inccolor3line4 > 6)
                    inccolor3line4 = 0;
                pbcolor3line4.BackColor = colors.ElementAt(inccolor3line4);
                inccolor3line4++;
            }
        }
        private void pbcolor4line4_Click(object sender, EventArgs e)
        {
            if (enablecheckline4 & !enablecheckline3)
            {
                if (inccolor4line4 > 6)
                    inccolor4line4 = 0;
                pbcolor4line4.BackColor = colors.ElementAt(inccolor4line4);
                inccolor4line4++;
            }
        }
        private void pbcolor1line5_Click(object sender, EventArgs e)
        {
            if (enablecheckline5 & !enablecheckline4)
            {
                if (inccolor1line5 > 6)
                    inccolor1line5 = 0;
                pbcolor1line5.BackColor = colors.ElementAt(inccolor1line5);
                inccolor1line5++;
            }
        }
        private void pbcolor2line5_Click(object sender, EventArgs e)
        {
            if (enablecheckline5 & !enablecheckline4)
            {
                if (inccolor2line5 > 6)
                    inccolor2line5 = 0;
                pbcolor2line5.BackColor = colors.ElementAt(inccolor2line5);
                inccolor2line5++;
            }
        }
        private void pbcolor3line5_Click(object sender, EventArgs e)
        {
            if (enablecheckline5 & !enablecheckline4)
            {
                if (inccolor3line5 > 6)
                    inccolor3line5 = 0;
                pbcolor3line5.BackColor = colors.ElementAt(inccolor3line5);
                inccolor3line5++;
            }
        }
        private void pbcolor4line5_Click(object sender, EventArgs e)
        {
            if (enablecheckline5 & !enablecheckline4)
            {
                if (inccolor4line5 > 6)
                    inccolor4line5 = 0;
                pbcolor4line5.BackColor = colors.ElementAt(inccolor4line5);
                inccolor4line5++;
            }
        }
        private void pbcolor1line6_Click(object sender, EventArgs e)
        {
            if (enablecheckline6 & !enablecheckline5)
            {
                if (inccolor1line6 > 6)
                    inccolor1line6 = 0;
                pbcolor1line6.BackColor = colors.ElementAt(inccolor1line6);
                inccolor1line6++;
            }
        }
        private void pbcolor2line6_Click(object sender, EventArgs e)
        {
            if (enablecheckline6 & !enablecheckline5)
            {
                if (inccolor2line6 > 6)
                    inccolor2line6 = 0;
                pbcolor2line6.BackColor = colors.ElementAt(inccolor2line6);
                inccolor2line6++;
            }
        }
        private void pbcolor3line6_Click(object sender, EventArgs e)
        {
            if (enablecheckline6 & !enablecheckline5)
            {
                if (inccolor3line6 > 6)
                    inccolor3line6 = 0;
                pbcolor3line6.BackColor = colors.ElementAt(inccolor3line6);
                inccolor3line6++;
            }
        }
        private void pbcolor4line6_Click(object sender, EventArgs e)
        {
            if (enablecheckline6 & !enablecheckline5)
            {
                if (inccolor4line6 > 6)
                    inccolor4line6 = 0;
                pbcolor4line6.BackColor = colors.ElementAt(inccolor4line6);
                inccolor4line6++;
            }
        }
        private void btcheckline1_Click(object sender, EventArgs e)
        {
            if (enablecheckline1)
            {
                pbcheck1line1.BackColor = Color.Silver;
                pbcheck2line1.BackColor = Color.Silver;
                pbcheck3line1.BackColor = Color.Silver;
                pbcheck4line1.BackColor = Color.Silver;
                checkcolors = new List<Color>();
                if (pbcolor1line1.BackColor == seecolors[0])
                {
                    pbcheck1line1.BackColor = Color.Black;
                    checkcolors.Add(seecolors[0]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor2line1.BackColor == seecolors[1])
                {
                    if (pbcheck1line1.BackColor != Color.Black)
                    {
                        pbcheck1line1.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck2line1.BackColor = Color.Black;
                    }
                    checkcolors.Add(seecolors[1]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor3line1.BackColor == seecolors[2])
                {
                    if (pbcheck1line1.BackColor != Color.Black)
                    {
                        pbcheck1line1.BackColor = Color.Black;
                    }
                    else if (pbcheck2line1.BackColor != Color.Black)
                    {
                        pbcheck2line1.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck3line1.BackColor = Color.Black;
                    }
                    checkcolors.Add(seecolors[2]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor4line1.BackColor == seecolors[3])
                {
                    if (pbcheck1line1.BackColor != Color.Black)
                    {
                        pbcheck1line1.BackColor = Color.Black;
                    }
                    else if (pbcheck2line1.BackColor != Color.Black)
                    {
                        pbcheck2line1.BackColor = Color.Black;
                    }
                    else if (pbcheck3line1.BackColor != Color.Black)
                    {
                        pbcheck3line1.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck4line1.BackColor = Color.Black;
                        MessageBox.Show("Congratulations, you win!");
                    }
                    checkcolors.Add(seecolors[3]);
                }
                else
                    checkcolors.Add(Color.Silver);
                List<Color> diffcolors = seecolors.Except(checkcolors).ToList();
                diffcolors.RemoveAll(item => item == Color.Silver);
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor1line1.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line1.BackColor == Color.Silver)
                        pbcheck1line1.BackColor = Color.White;
                    else if (pbcheck2line1.BackColor == Color.Silver)
                        pbcheck2line1.BackColor = Color.White;
                    else if (pbcheck3line1.BackColor == Color.Silver)
                        pbcheck3line1.BackColor = Color.White;
                    else if (pbcheck4line1.BackColor == Color.Silver)
                        pbcheck4line1.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor2line1.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line1.BackColor == Color.Silver)
                        pbcheck1line1.BackColor = Color.White;
                    else if (pbcheck2line1.BackColor == Color.Silver)
                        pbcheck2line1.BackColor = Color.White;
                    else if (pbcheck3line1.BackColor == Color.Silver)
                        pbcheck3line1.BackColor = Color.White;
                    else if (pbcheck4line1.BackColor == Color.Silver)
                        pbcheck4line1.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor3line1.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line1.BackColor == Color.Silver)
                        pbcheck1line1.BackColor = Color.White;
                    else if (pbcheck2line1.BackColor == Color.Silver)
                        pbcheck2line1.BackColor = Color.White;
                    else if (pbcheck3line1.BackColor == Color.Silver)
                        pbcheck3line1.BackColor = Color.White;
                    else if (pbcheck4line1.BackColor == Color.Silver)
                        pbcheck4line1.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor4line1.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line1.BackColor == Color.Silver)
                        pbcheck1line1.BackColor = Color.White;
                    else if (pbcheck2line1.BackColor == Color.Silver)
                        pbcheck2line1.BackColor = Color.White;
                    else if (pbcheck3line1.BackColor == Color.Silver)
                        pbcheck3line1.BackColor = Color.White;
                    else if (pbcheck4line1.BackColor == Color.Silver)
                        pbcheck4line1.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                enablecheckline1 = false;
                btcheckline1.Enabled = false;
            }
        }
        private void btcheckline2_Click(object sender, EventArgs e)
        {
            if (!enablecheckline1)
            {
                pbcheck1line2.BackColor = Color.Silver;
                pbcheck2line2.BackColor = Color.Silver;
                pbcheck3line2.BackColor = Color.Silver;
                pbcheck4line2.BackColor = Color.Silver;
                checkcolors = new List<Color>();
                if (pbcolor1line2.BackColor == seecolors[0])
                {
                    pbcheck1line2.BackColor = Color.Black;
                    checkcolors.Add(seecolors[0]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor2line2.BackColor == seecolors[1])
                {
                    if (pbcheck1line2.BackColor != Color.Black)
                    {
                        pbcheck1line2.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck2line2.BackColor = Color.Black;
                    }
                    checkcolors.Add(seecolors[1]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor3line2.BackColor == seecolors[2])
                {
                    if (pbcheck1line2.BackColor != Color.Black)
                    {
                        pbcheck1line2.BackColor = Color.Black;
                    }
                    else if (pbcheck2line2.BackColor != Color.Black)
                    {
                        pbcheck2line2.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck3line2.BackColor = Color.Black;
                    }
                    checkcolors.Add(seecolors[2]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor4line2.BackColor == seecolors[3])
                {
                    if (pbcheck1line2.BackColor != Color.Black)
                    {
                        pbcheck1line2.BackColor = Color.Black;
                    }
                    else if (pbcheck2line2.BackColor != Color.Black)
                    {
                        pbcheck2line2.BackColor = Color.Black;
                    }
                    else if (pbcheck3line2.BackColor != Color.Black)
                    {
                        pbcheck3line2.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck4line2.BackColor = Color.Black;
                        MessageBox.Show("Congratulations, you win!");
                    }
                    checkcolors.Add(seecolors[3]);
                }
                else
                    checkcolors.Add(Color.Silver);
                List<Color> diffcolors = seecolors.Except(checkcolors).ToList();
                diffcolors.RemoveAll(item => item == Color.Silver);
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor1line2.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line2.BackColor == Color.Silver)
                        pbcheck1line2.BackColor = Color.White;
                    else if (pbcheck2line2.BackColor == Color.Silver)
                        pbcheck2line2.BackColor = Color.White;
                    else if (pbcheck3line2.BackColor == Color.Silver)
                        pbcheck3line2.BackColor = Color.White;
                    else if (pbcheck4line2.BackColor == Color.Silver)
                        pbcheck4line2.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor2line2.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line2.BackColor == Color.Silver)
                        pbcheck1line2.BackColor = Color.White;
                    else if (pbcheck2line2.BackColor == Color.Silver)
                        pbcheck2line2.BackColor = Color.White;
                    else if (pbcheck3line2.BackColor == Color.Silver)
                        pbcheck3line2.BackColor = Color.White;
                    else if (pbcheck4line2.BackColor == Color.Silver)
                        pbcheck4line2.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor3line2.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line2.BackColor == Color.Silver)
                        pbcheck1line2.BackColor = Color.White;
                    else if (pbcheck2line2.BackColor == Color.Silver)
                        pbcheck2line2.BackColor = Color.White;
                    else if (pbcheck3line2.BackColor == Color.Silver)
                        pbcheck3line2.BackColor = Color.White;
                    else if (pbcheck4line2.BackColor == Color.Silver)
                        pbcheck4line2.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor4line2.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line2.BackColor == Color.Silver)
                        pbcheck1line2.BackColor = Color.White;
                    else if (pbcheck2line2.BackColor == Color.Silver)
                        pbcheck2line2.BackColor = Color.White;
                    else if (pbcheck3line2.BackColor == Color.Silver)
                        pbcheck3line2.BackColor = Color.White;
                    else if (pbcheck4line2.BackColor == Color.Silver)
                        pbcheck4line2.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                enablecheckline2 = false;
                btcheckline2.Enabled = false;
            }
        }
        private void btcheckline3_Click(object sender, EventArgs e)
        {
            if (!enablecheckline2)
            {
                pbcheck1line3.BackColor = Color.Silver;
                pbcheck2line3.BackColor = Color.Silver;
                pbcheck3line3.BackColor = Color.Silver;
                pbcheck4line3.BackColor = Color.Silver;
                checkcolors = new List<Color>();
                if (pbcolor1line3.BackColor == seecolors[0])
                {
                    pbcheck1line3.BackColor = Color.Black;
                    checkcolors.Add(seecolors[0]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor2line3.BackColor == seecolors[1])
                {
                    if (pbcheck1line3.BackColor != Color.Black)
                    {
                        pbcheck1line3.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck2line3.BackColor = Color.Black;
                    }
                    checkcolors.Add(seecolors[1]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor3line3.BackColor == seecolors[2])
                {
                    if (pbcheck1line3.BackColor != Color.Black)
                    {
                        pbcheck1line3.BackColor = Color.Black;
                    }
                    else if (pbcheck2line3.BackColor != Color.Black)
                    {
                        pbcheck2line3.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck3line3.BackColor = Color.Black;
                    }
                    checkcolors.Add(seecolors[2]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor4line3.BackColor == seecolors[3])
                {
                    if (pbcheck1line3.BackColor != Color.Black)
                    {
                        pbcheck1line3.BackColor = Color.Black;
                    }
                    else if (pbcheck2line3.BackColor != Color.Black)
                    {
                        pbcheck2line3.BackColor = Color.Black;
                    }
                    else if (pbcheck3line3.BackColor != Color.Black)
                    {
                        pbcheck3line3.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck4line3.BackColor = Color.Black;
                        MessageBox.Show("Congratulations, you win!");
                    }
                    checkcolors.Add(seecolors[3]);
                }
                else
                    checkcolors.Add(Color.Silver);
                List<Color> diffcolors = seecolors.Except(checkcolors).ToList();
                diffcolors.RemoveAll(item => item == Color.Silver);
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor1line3.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line3.BackColor == Color.Silver)
                        pbcheck1line3.BackColor = Color.White;
                    else if (pbcheck2line3.BackColor == Color.Silver)
                        pbcheck2line3.BackColor = Color.White;
                    else if (pbcheck3line3.BackColor == Color.Silver)
                        pbcheck3line3.BackColor = Color.White;
                    else if (pbcheck4line3.BackColor == Color.Silver)
                        pbcheck4line3.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor2line3.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line3.BackColor == Color.Silver)
                        pbcheck1line3.BackColor = Color.White;
                    else if (pbcheck2line3.BackColor == Color.Silver)
                        pbcheck2line3.BackColor = Color.White;
                    else if (pbcheck3line3.BackColor == Color.Silver)
                        pbcheck3line3.BackColor = Color.White;
                    else if (pbcheck4line3.BackColor == Color.Silver)
                        pbcheck4line3.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor3line3.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line3.BackColor == Color.Silver)
                        pbcheck1line3.BackColor = Color.White;
                    else if (pbcheck2line3.BackColor == Color.Silver)
                        pbcheck2line3.BackColor = Color.White;
                    else if (pbcheck3line3.BackColor == Color.Silver)
                        pbcheck3line3.BackColor = Color.White;
                    else if (pbcheck4line3.BackColor == Color.Silver)
                        pbcheck4line3.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor4line3.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line3.BackColor == Color.Silver)
                        pbcheck1line3.BackColor = Color.White;
                    else if (pbcheck2line3.BackColor == Color.Silver)
                        pbcheck2line3.BackColor = Color.White;
                    else if (pbcheck3line3.BackColor == Color.Silver)
                        pbcheck3line3.BackColor = Color.White;
                    else if (pbcheck4line3.BackColor == Color.Silver)
                        pbcheck4line3.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                enablecheckline3 = false;
                btcheckline3.Enabled = false;
            }
        }
        private void btcheckline4_Click(object sender, EventArgs e)
        {
            if (!enablecheckline3)
            {
                pbcheck1line4.BackColor = Color.Silver;
                pbcheck2line4.BackColor = Color.Silver;
                pbcheck3line4.BackColor = Color.Silver;
                pbcheck4line4.BackColor = Color.Silver;
                checkcolors = new List<Color>();
                if (pbcolor1line4.BackColor == seecolors[0])
                {
                    pbcheck1line4.BackColor = Color.Black;
                    checkcolors.Add(seecolors[0]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor2line4.BackColor == seecolors[1])
                {
                    if (pbcheck1line4.BackColor != Color.Black)
                    {
                        pbcheck1line4.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck2line4.BackColor = Color.Black;
                    }
                    checkcolors.Add(seecolors[1]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor3line4.BackColor == seecolors[2])
                {
                    if (pbcheck1line4.BackColor != Color.Black)
                    {
                        pbcheck1line4.BackColor = Color.Black;
                    }
                    else if (pbcheck2line4.BackColor != Color.Black)
                    {
                        pbcheck2line4.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck3line4.BackColor = Color.Black;
                    }
                    checkcolors.Add(seecolors[2]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor4line4.BackColor == seecolors[3])
                {
                    if (pbcheck1line4.BackColor != Color.Black)
                    {
                        pbcheck1line4.BackColor = Color.Black;
                    }
                    else if (pbcheck2line4.BackColor != Color.Black)
                    {
                        pbcheck2line4.BackColor = Color.Black;
                    }
                    else if (pbcheck3line4.BackColor != Color.Black)
                    {
                        pbcheck3line4.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck4line4.BackColor = Color.Black;
                        MessageBox.Show("Congratulations, you win!");
                    }
                    checkcolors.Add(seecolors[3]);
                }
                else
                    checkcolors.Add(Color.Silver);
                List<Color> diffcolors = seecolors.Except(checkcolors).ToList();
                diffcolors.RemoveAll(item => item == Color.Silver);
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor1line4.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line4.BackColor == Color.Silver)
                        pbcheck1line4.BackColor = Color.White;
                    else if (pbcheck2line4.BackColor == Color.Silver)
                        pbcheck2line4.BackColor = Color.White;
                    else if (pbcheck3line4.BackColor == Color.Silver)
                        pbcheck3line4.BackColor = Color.White;
                    else if (pbcheck4line4.BackColor == Color.Silver)
                        pbcheck4line4.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor2line4.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line4.BackColor == Color.Silver)
                        pbcheck1line4.BackColor = Color.White;
                    else if (pbcheck2line4.BackColor == Color.Silver)
                        pbcheck2line4.BackColor = Color.White;
                    else if (pbcheck3line4.BackColor == Color.Silver)
                        pbcheck3line4.BackColor = Color.White;
                    else if (pbcheck4line4.BackColor == Color.Silver)
                        pbcheck4line4.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor3line4.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line4.BackColor == Color.Silver)
                        pbcheck1line4.BackColor = Color.White;
                    else if (pbcheck2line4.BackColor == Color.Silver)
                        pbcheck2line4.BackColor = Color.White;
                    else if (pbcheck3line4.BackColor == Color.Silver)
                        pbcheck3line4.BackColor = Color.White;
                    else if (pbcheck4line4.BackColor == Color.Silver)
                        pbcheck4line4.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor4line4.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line4.BackColor == Color.Silver)
                        pbcheck1line4.BackColor = Color.White;
                    else if (pbcheck2line4.BackColor == Color.Silver)
                        pbcheck2line4.BackColor = Color.White;
                    else if (pbcheck3line4.BackColor == Color.Silver)
                        pbcheck3line4.BackColor = Color.White;
                    else if (pbcheck4line4.BackColor == Color.Silver)
                        pbcheck4line4.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                enablecheckline4 = false;
                btcheckline4.Enabled = false;
            }
        }
        private void btcheckline5_Click(object sender, EventArgs e)
        {
            if (!enablecheckline4)
            {
                pbcheck1line5.BackColor = Color.Silver;
                pbcheck2line5.BackColor = Color.Silver;
                pbcheck3line5.BackColor = Color.Silver;
                pbcheck4line5.BackColor = Color.Silver;
                checkcolors = new List<Color>();
                if (pbcolor1line5.BackColor == seecolors[0])
                {
                    pbcheck1line5.BackColor = Color.Black;
                    checkcolors.Add(seecolors[0]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor2line5.BackColor == seecolors[1])
                {
                    if (pbcheck1line5.BackColor != Color.Black)
                    {
                        pbcheck1line5.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck2line5.BackColor = Color.Black;
                    }
                    checkcolors.Add(seecolors[1]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor3line5.BackColor == seecolors[2])
                {
                    if (pbcheck1line5.BackColor != Color.Black)
                    {
                        pbcheck1line5.BackColor = Color.Black;
                    }
                    else if (pbcheck2line5.BackColor != Color.Black)
                    {
                        pbcheck2line5.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck3line5.BackColor = Color.Black;
                    }
                    checkcolors.Add(seecolors[2]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor4line5.BackColor == seecolors[3])
                {
                    if (pbcheck1line5.BackColor != Color.Black)
                    {
                        pbcheck1line5.BackColor = Color.Black;
                    }
                    else if (pbcheck2line5.BackColor != Color.Black)
                    {
                        pbcheck2line5.BackColor = Color.Black;
                    }
                    else if (pbcheck3line5.BackColor != Color.Black)
                    {
                        pbcheck3line5.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck4line5.BackColor = Color.Black;
                        MessageBox.Show("Congratulations, you win!");
                    }
                    checkcolors.Add(seecolors[3]);
                }
                else
                    checkcolors.Add(Color.Silver);
                List<Color> diffcolors = seecolors.Except(checkcolors).ToList();
                diffcolors.RemoveAll(item => item == Color.Silver);
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor1line5.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line5.BackColor == Color.Silver)
                        pbcheck1line5.BackColor = Color.White;
                    else if (pbcheck2line5.BackColor == Color.Silver)
                        pbcheck2line5.BackColor = Color.White;
                    else if (pbcheck3line5.BackColor == Color.Silver)
                        pbcheck3line5.BackColor = Color.White;
                    else if (pbcheck4line5.BackColor == Color.Silver)
                        pbcheck4line5.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor2line5.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line5.BackColor == Color.Silver)
                        pbcheck1line5.BackColor = Color.White;
                    else if (pbcheck2line5.BackColor == Color.Silver)
                        pbcheck2line5.BackColor = Color.White;
                    else if (pbcheck3line5.BackColor == Color.Silver)
                        pbcheck3line5.BackColor = Color.White;
                    else if (pbcheck4line5.BackColor == Color.Silver)
                        pbcheck4line5.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor3line5.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line5.BackColor == Color.Silver)
                        pbcheck1line5.BackColor = Color.White;
                    else if (pbcheck2line5.BackColor == Color.Silver)
                        pbcheck2line5.BackColor = Color.White;
                    else if (pbcheck3line5.BackColor == Color.Silver)
                        pbcheck3line5.BackColor = Color.White;
                    else if (pbcheck4line5.BackColor == Color.Silver)
                        pbcheck4line5.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor4line5.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line5.BackColor == Color.Silver)
                        pbcheck1line5.BackColor = Color.White;
                    else if (pbcheck2line5.BackColor == Color.Silver)
                        pbcheck2line5.BackColor = Color.White;
                    else if (pbcheck3line5.BackColor == Color.Silver)
                        pbcheck3line5.BackColor = Color.White;
                    else if (pbcheck4line5.BackColor == Color.Silver)
                        pbcheck4line5.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                enablecheckline5 = false;
                btcheckline5.Enabled = false;
            }
        }
        private void btcheckline6_Click(object sender, EventArgs e)
        {
            if (!enablecheckline5)
            {
                pbcheck1line6.BackColor = Color.Silver;
                pbcheck2line6.BackColor = Color.Silver;
                pbcheck3line6.BackColor = Color.Silver;
                pbcheck4line6.BackColor = Color.Silver;
                checkcolors = new List<Color>();
                if (pbcolor1line6.BackColor == seecolors[0])
                {
                    pbcheck1line6.BackColor = Color.Black;
                    checkcolors.Add(seecolors[0]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor2line6.BackColor == seecolors[1])
                {
                    if (pbcheck1line6.BackColor != Color.Black)
                    {
                        pbcheck1line6.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck2line6.BackColor = Color.Black;
                    }
                    checkcolors.Add(seecolors[1]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor3line6.BackColor == seecolors[2])
                {
                    if (pbcheck1line6.BackColor != Color.Black)
                    {
                        pbcheck1line6.BackColor = Color.Black;
                    }
                    else if (pbcheck2line6.BackColor != Color.Black)
                    {
                        pbcheck2line6.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck3line6.BackColor = Color.Black;
                    }
                    checkcolors.Add(seecolors[2]);
                }
                else
                    checkcolors.Add(Color.Silver);
                if (pbcolor4line6.BackColor == seecolors[3])
                {
                    if (pbcheck1line6.BackColor != Color.Black)
                    {
                        pbcheck1line6.BackColor = Color.Black;
                    }
                    else if (pbcheck2line6.BackColor != Color.Black)
                    {
                        pbcheck2line6.BackColor = Color.Black;
                    }
                    else if (pbcheck3line6.BackColor != Color.Black)
                    {
                        pbcheck3line6.BackColor = Color.Black;
                    }
                    else
                    {
                        pbcheck4line6.BackColor = Color.Black;
                        MessageBox.Show("Congratulations, you win!");
                    }
                    checkcolors.Add(seecolors[3]);
                }
                else
                    checkcolors.Add(Color.Silver);
                List<Color> diffcolors = seecolors.Except(checkcolors).ToList();
                diffcolors.RemoveAll(item => item == Color.Silver);
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor1line6.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line6.BackColor == Color.Silver)
                        pbcheck1line6.BackColor = Color.White;
                    else if (pbcheck2line6.BackColor == Color.Silver)
                        pbcheck2line6.BackColor = Color.White;
                    else if (pbcheck3line6.BackColor == Color.Silver)
                        pbcheck3line6.BackColor = Color.White;
                    else if (pbcheck4line6.BackColor == Color.Silver)
                        pbcheck4line6.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor2line6.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line6.BackColor == Color.Silver)
                        pbcheck1line6.BackColor = Color.White;
                    else if (pbcheck2line6.BackColor == Color.Silver)
                        pbcheck2line6.BackColor = Color.White;
                    else if (pbcheck3line6.BackColor == Color.Silver)
                        pbcheck3line6.BackColor = Color.White;
                    else if (pbcheck4line6.BackColor == Color.Silver)
                        pbcheck4line6.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor3line6.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line6.BackColor == Color.Silver)
                        pbcheck1line6.BackColor = Color.White;
                    else if (pbcheck2line6.BackColor == Color.Silver)
                        pbcheck2line6.BackColor = Color.White;
                    else if (pbcheck3line6.BackColor == Color.Silver)
                        pbcheck3line6.BackColor = Color.White;
                    else if (pbcheck4line6.BackColor == Color.Silver)
                        pbcheck4line6.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                color = Color.Empty;
                if ((color = diffcolors.FirstOrDefault(colorToCheck => colorToCheck == pbcolor4line6.BackColor)) != Color.Empty)
                {
                    if (pbcheck1line6.BackColor == Color.Silver)
                        pbcheck1line6.BackColor = Color.White;
                    else if (pbcheck2line6.BackColor == Color.Silver)
                        pbcheck2line6.BackColor = Color.White;
                    else if (pbcheck3line6.BackColor == Color.Silver)
                        pbcheck3line6.BackColor = Color.White;
                    else if (pbcheck4line6.BackColor == Color.Silver)
                        pbcheck4line6.BackColor = Color.White;
                    diffcolors.RemoveAll(item => item == color);
                }
                enablecheckline6 = false;
                btcheckline6.Enabled = false;
            }
        }
    }
}