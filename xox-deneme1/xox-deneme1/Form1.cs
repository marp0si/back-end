using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace xox_deneme1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[] butonlar = new Button[9];
       
        Label text = new Label();
        Label text2 = new Label();
        Label text3 = new Label();
        Label text4 = new Label();
        
        Pen firca1 = new Pen(Color.Red,3);
        Graphics grafik;
        private void Form1_Load(object sender, EventArgs e)
        { text4.Location = new System.Drawing.Point(140, 467);
            text4.Text = "";
            text4.Name = "label";
            text4.TabIndex = 44;
            text4.TextChanged += label1_TextChanged;
            grafik = this.CreateGraphics();          
            text.Location = new System.Drawing.Point(70, 5);
            text.Text = "XOX";
            text.Name = "text";
            text.TabIndex = 10;
            text2.Location = new System.Drawing.Point(120, 5);
            text2.Text = "sayaç=";
            text2.Name = "text2";
            text2.TabIndex = 11;
            text3.Location = new System.Drawing.Point(10, 5);
            text3.Text = "sıra-->";
            text3.Name = "text3";
            text.Width = 40;
            text2.Width = 60;
            text3.Width = 60;
            text3.TabIndex = 12;
            Controls.Add(text);
            Controls.Add(text2);
            Controls.Add(text3);
            Controls.Add(text4);
            int a = 0, cizilcekX = 10, cizilcekY = 30;
            
            for (int i = 0; i <9; i++)
            {  
                butonlar[i] = new Button();
                butonlar[i].Size = new System.Drawing.Size(genişlik, yükseklik);                   
                butonlar[i].Name = i+".buton";
                butonlar[i].TabIndex = i+1;
                butonlar[i].Text = ""; 
                butonlar[i].Enabled = true;
                cizilcekX += genişlik+10 ;
                if (i % 3 ==0 && i > 0)   { a = 0; cizilcekX = 10; cizilcekY += yükseklik+10; }
                if (i == 0) cizilcekX = 10;        
                butonlar[i].Location = new System.Drawing.Point(cizilcekX,cizilcekY);
                this.Controls.Add(butonlar[i]);              
                a++;
                butonlar[i].Visible = false;
                               
            }//hangi butona tıklandığını anlamak için hepsine olay açıldı
            butonlar[0].Click += tıkla_1;
            butonlar[1].Click += tıkla_2;
            butonlar[2].Click += tıkla_3;
            butonlar[3].Click += tıkla_4;
            butonlar[4].Click += tıkla_5;
            butonlar[5].Click += tıkla_6;
            butonlar[6].Click += tıkla_7;
            butonlar[7].Click += tıkla_8;
            butonlar[8].Click += tıkla_9;
            text3.Text = "sıra--> X";           
        }
        int tık;
        int sayaç = 0;
        int genişlik=50,yükseklik=80;
        string kazanan="";
        int çizgi_Baş_x,çizgi_son_x;
        private void tıkla()
        {
           ciz();
   
           text2.Text = "sayaç="+sayaç.ToString();
           if (sayaç % 2 == 0)
           { text3.Text = "sıra-->  O"; butonlar[tık].Text = "X"; X_denetle(); butonlar[tık].Enabled = false; }
           else { text3.Text = "sıra-->  X"; butonlar[tık].Text = "O"; O_denetle(); butonlar[tık].Enabled = false; }      
            sayaç++;
            if (sayaç == 9) { for (int i = 0; i < 9; i++) butonlar[i].Text = ""; sayaç = 0; }
            text4.Text = kazanan;
        }
        private void tıkla_1(object sender, EventArgs e) { tık = 0; tıkla(); }
        private void tıkla_2(object sender, EventArgs e) { tık = 1; tıkla(); }
        private void tıkla_3(object sender, EventArgs e) { tık = 2; tıkla(); }
        private void tıkla_4(object sender, EventArgs e) { tık = 3; tıkla(); }
        private void tıkla_5(object sender, EventArgs e) { tık = 4; tıkla(); }
        private void tıkla_6(object sender, EventArgs e) { tık = 5; tıkla(); }
        private void tıkla_7(object sender, EventArgs e) { tık = 6; tıkla(); }
        private void tıkla_8(object sender, EventArgs e) { tık = 7; tıkla(); }
        private void tıkla_9(object sender, EventArgs e) { tık = 8; tıkla(); }
        private void X_denetle()
        {
            if (butonlar[0].Text == butonlar[1].Text && butonlar[1].Text == butonlar[2].Text && butonlar[2].Text == "X") { kazanan = "X kazandı"; butonlar[0].BackColor = Color.Red; butonlar[1].BackColor = Color.Red; butonlar[2].BackColor = Color.Red; }
            else if (butonlar[3].Text == butonlar[4].Text && butonlar[4].Text == butonlar[5].Text && butonlar[4].Text == "X") { kazanan = "X kazandı"; butonlar[3].BackColor = Color.Red; butonlar[4].BackColor = Color.Red; butonlar[5].BackColor = Color.Red; }
            else if (butonlar[6].Text == butonlar[7].Text && butonlar[6].Text == butonlar[8].Text && butonlar[6].Text == "X") { kazanan = "X kazandı"; butonlar[6].BackColor = Color.Red; butonlar[7].BackColor = Color.Red; butonlar[8].BackColor = Color.Red; }
            else if (butonlar[0].Text == butonlar[3].Text && butonlar[0].Text == butonlar[6].Text && butonlar[0].Text == "X") { kazanan = "X kazandı"; butonlar[3].BackColor = Color.Red; butonlar[0].BackColor = Color.Red; butonlar[6].BackColor = Color.Red; }
            else if (butonlar[1].Text == butonlar[4].Text && butonlar[7].Text == butonlar[4].Text && butonlar[4].Text == "X") { kazanan = "X kazandı"; butonlar[1].BackColor = Color.Red; butonlar[4].BackColor = Color.Red; butonlar[7].BackColor = Color.Red; }
            else if (butonlar[2].Text == butonlar[5].Text && butonlar[8].Text == butonlar[5].Text && butonlar[8].Text == "X") { kazanan = "X kazandı"; butonlar[2].BackColor = Color.Red; butonlar[5].BackColor = Color.Red; butonlar[8].BackColor = Color.Red; }
            else if (butonlar[0].Text == butonlar[4].Text && butonlar[0].Text == butonlar[8].Text && butonlar[0].Text == "X") { kazanan = "X kazandı"; butonlar[0].BackColor = Color.Red; butonlar[4].BackColor = Color.Red; butonlar[8].BackColor = Color.Red; }
            else if (butonlar[2].Text == butonlar[4].Text && butonlar[6].Text == butonlar[4].Text && butonlar[2].Text == "X") { kazanan = "X kazandı"; butonlar[2].BackColor = Color.Red; butonlar[4].BackColor = Color.Red; butonlar[6].BackColor = Color.Red; }
        }
        private void O_denetle()
        {
            if (butonlar[0].Text == butonlar[1].Text && butonlar[1].Text == butonlar[2].Text && butonlar[2].Text == "O") { kazanan = "O kazandı"; butonlar[0].BackColor = Color.Blue; butonlar[1].BackColor = Color.Blue; butonlar[2].BackColor = Color.Red; }
            else if (butonlar[3].Text == butonlar[4].Text && butonlar[4].Text == butonlar[5].Text && butonlar[4].Text == "O") { kazanan = "O kazandı"; butonlar[3].BackColor = Color.Blue; butonlar[4].BackColor = Color.Blue; butonlar[5].BackColor = Color.Blue; }
            else if (butonlar[6].Text == butonlar[7].Text && butonlar[6].Text == butonlar[8].Text && butonlar[6].Text == "O") { kazanan = "O kazandı"; butonlar[6].BackColor = Color.Blue; butonlar[7].BackColor = Color.Blue; butonlar[8].BackColor = Color.Blue; }
            else if (butonlar[0].Text == butonlar[3].Text && butonlar[0].Text == butonlar[6].Text && butonlar[0].Text == "O") { kazanan = "O kazandı"; butonlar[3].BackColor = Color.Blue; butonlar[0].BackColor = Color.Blue; butonlar[6].BackColor = Color.Blue; }
            else if (butonlar[1].Text == butonlar[4].Text && butonlar[7].Text == butonlar[4].Text && butonlar[4].Text == "O") { kazanan = "O kazandı"; butonlar[1].BackColor = Color.Blue; butonlar[4].BackColor = Color.Blue; butonlar[7].BackColor = Color.Blue; }
            else if (butonlar[2].Text == butonlar[5].Text && butonlar[8].Text == butonlar[5].Text && butonlar[8].Text == "O") { kazanan = "O kazandı"; butonlar[2].BackColor = Color.Blue; butonlar[5].BackColor = Color.Blue; butonlar[8].BackColor = Color.Blue; }
            else if (butonlar[0].Text == butonlar[4].Text && butonlar[0].Text == butonlar[8].Text && butonlar[0].Text == "O") { kazanan = "O kazandı"; butonlar[0].BackColor = Color.Blue; butonlar[4].BackColor = Color.Blue; butonlar[8].BackColor = Color.Blue; }
            else if (butonlar[2].Text == butonlar[4].Text && butonlar[6].Text == butonlar[4].Text && butonlar[2].Text == "O") { kazanan = "O kazandı"; butonlar[2].BackColor = Color.Blue; butonlar[4].BackColor = Color.Blue; butonlar[6].BackColor = Color.Blue; }
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++) butonlar[i].Enabled = false; 
        }
        private void ciz()
        {
            grafik.DrawLine(firca1, genişlik + 15, 25, genişlik + 15, 3 * (yükseklik + 20));
            grafik.DrawLine(firca1, 2*(genişlik + 12), 25, 2*(genişlik + 12), 3 * (yükseklik + 20));
            grafik.DrawLine(firca1, 5, yükseklik + 31, 3*(genişlik+10),yükseklik+31);
            grafik.DrawLine(firca1, 5, 2*(yükseklik + 22), 3 * (genişlik + 10), 2*(yükseklik + 22));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                butonlar[i].Text = ""; sayaç = 0; butonlar[i].Enabled = true; butonlar[i].Visible = true; butonlar[i].BackColor = button1.BackColor; ciz();
            }            
        }
        
    }
}
