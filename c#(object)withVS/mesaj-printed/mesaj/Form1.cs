using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mesaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
        }

        Font yazitipi = new Font("Arial", 12, FontStyle.Regular);

        private void button4_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                yazitipi = fontDialog1.Font;
        }

        Color zeminrengi=Color.Yellow, yazirengi=Color.Red;

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                zeminrengi = colorDialog1.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                yazirengi = colorDialog1.Color;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string mesaj1 = textBox1.Text;
            string mesaj2 = textBox2.Text;
            int genislik1, genislik2, buyukgenislik, yukseklik;
            if (printDocument1.DefaultPageSettings.Landscape == false) 
            {
                genislik1 = Convert.ToInt32(e.Graphics.MeasureString(mesaj1, yazitipi).Width);
                genislik2 = Convert.ToInt32(e.Graphics.MeasureString(mesaj2, yazitipi).Width);
                yukseklik = Convert.ToInt32(e.Graphics.MeasureString(mesaj1, yazitipi).Height);
                e.Graphics.Clear(zeminrengi);
                e.Graphics.DrawString(mesaj1, yazitipi, new SolidBrush(yazirengi), (printDocument1.DefaultPageSettings.PaperSize.Width - genislik1) / 2, (printDocument1.DefaultPageSettings.PaperSize.Height - (2 * yukseklik + 20)) / 2);
                e.Graphics.DrawString(mesaj2, yazitipi, new SolidBrush(yazirengi), (printDocument1.DefaultPageSettings.PaperSize.Width - genislik2) / 2, ((printDocument1.DefaultPageSettings.PaperSize.Height - (2 * yukseklik + 20)) / 2) + yukseklik + 20);
                if (genislik1 > genislik2) buyukgenislik = genislik1;
                else buyukgenislik = genislik2;
                int sol = ((printDocument1.DefaultPageSettings.PaperSize.Width - buyukgenislik) / 2 - 50);
                int ust = (printDocument1.DefaultPageSettings.PaperSize.Height - (yukseklik * 2 + 20)) / 2 - 100;
                e.Graphics.DrawRectangle(new Pen(yazirengi), sol, ust, buyukgenislik + 100, (yukseklik * 2 + 20) + 200);
                e.Graphics.DrawRectangle(new Pen(yazirengi), sol-5, ust-5, buyukgenislik + 110, (yukseklik * 2 + 20) + 210);
            }
        }
    }
}
