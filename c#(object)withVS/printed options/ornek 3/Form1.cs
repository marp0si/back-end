using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ornek_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pageSetupDialog1.EnableMetric = true; //PageSetupDialog penceresi metrik değerleri kullansın
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Brush firca = new SolidBrush(Color.Black);
            Font yazitipi = new Font("Times New Roman", 14, FontStyle.Regular);
            int ustkenarboslugu = printDocument1.DefaultPageSettings.Margins.Top; 
            int altkenarboslugu = printDocument1.DefaultPageSettings.Margins.Bottom;
            int solkenarboslugu = printDocument1.DefaultPageSettings.Margins.Left;
            int sagkenarboslugu = printDocument1.DefaultPageSettings.Margins.Right;
            int satiryuksekligi = (int)e.Graphics.MeasureString("Herhangi Bir String İfade", yazitipi).Height;
            e.Graphics.DrawString("Bu Sayfanın Yönlendirmesi :" + printDocument1.DefaultPageSettings.Landscape.ToString(), yazitipi, firca, solkenarboslugu, ustkenarboslugu);
            e.Graphics.DrawString("Bu Belgenin Kağıt Kaynağı :" + printDocument1.DefaultPageSettings.PaperSource.SourceName.ToString(), yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi);            
            e.Graphics.DrawString("Belge Renk Durumu :" + printDocument1.DefaultPageSettings.Color.ToString(), yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi * 2);
            e.Graphics.DrawString("Yazıcının Çözünürlüğü Yatay :" + printDocument1.DefaultPageSettings.PrinterResolution.X.ToString(), yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi * 3);
            e.Graphics.DrawString("Yazıcının Çözünürlüğü Dikey :" + printDocument1.DefaultPageSettings.PrinterResolution.Y.ToString(), yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi * 4);
            e.Graphics.DrawString("Belgenin Üst Kenar Boşluğu :" + printDocument1.DefaultPageSettings.Margins.Top.ToString(), yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi * 5);
            e.Graphics.DrawString("Belgenin Alt Kenar Boşluğu :" + printDocument1.DefaultPageSettings.Margins.Bottom.ToString(), yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi * 6);
            e.Graphics.DrawString("Belgenin Sol Kenar Boşluğu :" + printDocument1.DefaultPageSettings.Margins.Left.ToString(), yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi * 7);
            e.Graphics.DrawString("Belgenin Sağ Kenar Boşluğu :" + printDocument1.DefaultPageSettings.Margins.Right.ToString(), yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi * 8);
            e.Graphics.DrawString("Kağıt Boyutu Yükseklik :" + printDocument1.DefaultPageSettings.PaperSize.Height.ToString(), yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi * 9);
            e.Graphics.DrawString("Kağıt Boyutu Genişlik :" + printDocument1.DefaultPageSettings.PaperSize.Width.ToString(), yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi * 10);
            e.Graphics.DrawString("Kağıt Türü :" + printDocument1.DefaultPageSettings.PaperSize.Kind.ToString(), yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi * 11);
            int satirsayisi = (printDocument1.DefaultPageSettings.PaperSize.Height - ustkenarboslugu - altkenarboslugu) / satiryuksekligi;
            e.Graphics.DrawString("Yazdırılabilecek Satır Sayısı :" + satirsayisi.ToString(), yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi * 12);
            e.Graphics.DrawString("DefaultPageSettings ve PageSettings İfadelerinde Tüm Değerler 1/100 inch cinsindendir", yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi * 14);
            e.Graphics.DrawString("Değerler 2,54/100 değeri ile çarpılarak santimetreye çevrilebilir.", yazitipi, firca, solkenarboslugu, ustkenarboslugu + satiryuksekligi * 15);
            e.Graphics.DrawString("TEKNİK 12 F", new Font("Calibri", 24, FontStyle.Bold), new SolidBrush(Color.DeepPink), (printDocument1.DefaultPageSettings.PaperSize.Width - e.Graphics.MeasureString("TEKNİK 12 F", new Font("Calibri", 24)).Width) / 2, ustkenarboslugu + satiryuksekligi * 20);
        }       
    }
}
