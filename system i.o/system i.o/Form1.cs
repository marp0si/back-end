using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace system_i.o
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(textBox1.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(textBox1.Text) == true)
                    MessageBox.Show("var");
                else
                    MessageBox.Show("yok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
               MessageBox.Show(Directory.GetCreationTime(textBox1.Text).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
               MessageBox.Show( Directory.GetCurrentDirectory().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                string[] dosya = Directory.GetDirectories(textBox1.Text);
                dosya = Directory.GetFiles(textBox1.Text, "*.*");
                listBox1.Items.AddRange(dosya);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string[] hepsi = Directory.GetFileSystemEntries(textBox1.Text, "*.*");
                listBox2.Items.AddRange(hepsi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] sürücüler = Directory.GetLogicalDrives();
                listBox1.Items.AddRange(sürücüler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

  
    }
}
