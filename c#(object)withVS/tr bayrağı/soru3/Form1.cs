using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics nesne = this.CreateGraphics();
            nesne.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nesne.Clear(Color.Red);
            Brush firca1 = new SolidBrush(Color.White);
            Brush firca2 = new SolidBrush(Color.Red);
            nesne.FillEllipse(firca1, 75, 75, 150, 150);
            nesne.FillEllipse(firca2, 110, 90, 120, 120);
        }
    }
}
