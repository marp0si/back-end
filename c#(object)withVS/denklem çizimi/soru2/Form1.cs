using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap resim = new Bitmap(400, 300);

        private void zeminciz()
        {
            Graphics nesne = Graphics.FromImage(resim);
            nesne.Clear(this.BackColor);
            Pen kalem = new Pen(Color.Black, 1);
            nesne.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nesne.TranslateTransform(200, 150);
            nesne.DrawLine(kalem, -200, 0, 200, 0);
            nesne.DrawLine(kalem, 0, -150, 0, 150);
            for (int i = -200; i <= 200; i = i + 10)
                nesne.DrawLine(kalem, i, -2, i, 2);
            for (int i = -150; i <= 150; i = i + 10)
                nesne.DrawLine(kalem, -2, i, 2, i);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zeminciz();            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics nesne2 = this.CreateGraphics();
            nesne2.DrawImage(resim, 0, 44);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zeminciz();
            Graphics nesne = Graphics.FromImage(resim);           
            Brush firca = new SolidBrush(Color.Blue);
            nesne.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nesne.TranslateTransform(200, 150);
            float a = Convert.ToSingle(textBox1.Text);
            float b=Convert.ToSingle(textBox2.Text);
            float y = 0;

            //1. Yöntem Değer Verme

            float x1, y1, x2, y2;
            x1 = 500;
            y1 = a * x1 + b * 10;
            x2 = -500;
            y2 = a * x2 + b * 10;
            nesne.DrawLine(new Pen(Color.Blue, 2), x1, -y1, x2, -y2);

            //2. Yöntem Döngü ve Noktasal Çizim
            /*
            for (float x = -200; x < 200; x += 0.05f) 
            {
                y = a * x + b * 10;
                nesne.FillRectangle(firca, Convert.ToInt32(x), -Convert.ToInt32(y), 1, 1);
            }
             */ 
            Graphics nesne2 = this.CreateGraphics();
            nesne2.DrawImage(resim, 0, 44);            
        }
    }
}
