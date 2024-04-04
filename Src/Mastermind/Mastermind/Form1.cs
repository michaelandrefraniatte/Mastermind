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
            gp = new GraphicsPath();
            gp.AddEllipse(pbcheck1line1.DisplayRectangle);
            rg = new Region(gp);
            pbcheck1line1.Region = rg;
            pbcheck2line1.Region = rg;
            pbcheck3line1.Region = rg;
            pbcheck4line1.Region = rg;
        }
    }
}