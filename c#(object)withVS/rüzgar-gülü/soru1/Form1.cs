using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap resim = new Bitmap(350, 350);

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics nesne = Graphics.FromImage(resim);            
            Brush firca1 = new SolidBrush(Color.Red);
            Brush firca2 = new SolidBrush(Color.Yellow);
            Brush firca3 = new SolidBrush(Color.Blue);
            Brush firca4 = new SolidBrush(Color.Pink);
            Brush firca5 = new SolidBrush(Color.Black);
            nesne.Clear(this.BackColor);
            nesne.FillPie(firca1, 0, 0, 350, 350, 0, 45);
            nesne.FillPie(firca2, 0, 0, 350, 350, 90, 45);
            nesne.FillPie(firca3, 0, 0, 350, 350, 180, 45);
            nesne.FillPie(firca4, 0, 0, 350, 350, 270, 45);
            nesne.FillEllipse(firca5,150,150,50,50);            
            timer1.Interval = 110;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0) timer1.Stop();
            else timer1.Start();
            timer1.Interval = 110 - trackBar1.Value;
        }

        int aci = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics nesne = this.CreateGraphics();
            nesne.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nesne.TranslateTransform(this.ClientSize.Width / 2, this.ClientSize.Height / 2 + 30);
            nesne.RotateTransform(aci);
            aci += 5;
            if (aci == 360) aci = 0;
            //nesne.Clear(this.BackColor);
            nesne.DrawImage(resim, -175, -175);
        }
    }
}
