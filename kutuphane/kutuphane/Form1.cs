using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//Veri Tabanı Türü

namespace kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/kutuphane.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adaptor = new OleDbDataAdapter();
        DataSet veriseti = new DataSet();

        private void turleryenile()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                if (veriseti.Tables.IndexOf("turler") != -1) veriseti.Tables["turler"].Clear();
                adaptor.SelectCommand = new OleDbCommand("select * from turler", baglanti);
                adaptor.Fill(veriseti, "turler");
                baglanti.Close();
                datatur.DataSource = veriseti.Tables["turler"];
                cmbkitapturu.DataSource = veriseti.Tables["turler"];
                cmbkitapturu.DisplayMember = "tur";
                cmbkitapturu.ValueMember = "sirano";
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void yazaryenile()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                if (veriseti.Tables.IndexOf("yazarlar") != -1) veriseti.Tables["yazarlar"].Clear();
                adaptor.SelectCommand = new OleDbCommand("select * from yazarlar", baglanti);
                adaptor.Fill(veriseti, "yazarlar");
                baglanti.Close();
                datayazar.DataSource = veriseti.Tables["yazarlar"];
                cmbkitapyazar.DataSource = veriseti.Tables["yazarlar"];
                cmbkitapyazar.DisplayMember = "adisoyadi";
                cmbkitapyazar.ValueMember = "sirano";
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void yayineviyenile()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                if (veriseti.Tables.IndexOf("yayinevleri") != -1) veriseti.Tables["yayinevleri"].Clear();
                adaptor.SelectCommand = new OleDbCommand("select * from yayinevleri", baglanti);
                adaptor.Fill(veriseti, "yayinevleri");
                baglanti.Close();
                datayayinevi.DataSource = veriseti.Tables["yayinevleri"];
                cmbkitapyayinevi.DataSource = veriseti.Tables["yayinevleri"];
                cmbkitapyayinevi.DisplayMember = "ad";
                cmbkitapyayinevi.ValueMember = "sirano";
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void kitapyenile()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                if (veriseti.Tables.IndexOf("kitaplar") != -1) veriseti.Tables["kitaplar"].Clear();
                adaptor.SelectCommand = new OleDbCommand("SELECT kitaplar.sirano, kitaplar.kitapadi, yazarlar.adisoyadi, yayinevleri.ad, kitaplar.yayinyili, turler.tur, kitaplar.fiyati FROM yazarlar INNER JOIN (yayinevleri INNER JOIN (turler INNER JOIN kitaplar ON turler.sirano = kitaplar.turu) ON yayinevleri.sirano = kitaplar.yayinevi) ON yazarlar.sirano = kitaplar.yazari", baglanti);
                adaptor.Fill(veriseti, "kitaplar");
                baglanti.Close();
                datakitap.DataSource = veriseti.Tables["kitaplar"];
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            turleryenile();
            yazaryenile();
            yayineviyenile();
            kitapyenile();
        }

        private void datatur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int satirno = e.RowIndex;
                txttursirano.Text = datatur.Rows[satirno].Cells[0].Value.ToString();
                txtturtur.Text = datatur.Rows[satirno].Cells[1].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnturkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                komut = new OleDbCommand("INSERT INTO turler(tur) VALUES('" + txtturtur.Text.ToUpper() + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                turleryenile();
                MessageBox.Show("Tür Eklendi.");
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btntursil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                komut = new OleDbCommand("DELETE FROM turler WHERE sirano=" + txttursirano.Text, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                turleryenile();
                MessageBox.Show("Tür Silindi.");
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnyazarkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                komut = new OleDbCommand("INSERT INTO yazarlar(adisoyadi) VALUES('" + txtyazaradisoyadi.Text.ToUpper() + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                yazaryenile();
                MessageBox.Show("Yazar Eklendi.");
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void datayazar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int satirno = e.RowIndex;
                txtyazarsirano.Text = datayazar.Rows[satirno].Cells[0].Value.ToString();
                txtyazaradisoyadi.Text = datayazar.Rows[satirno].Cells[1].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnyazarsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                komut = new OleDbCommand("DELETE FROM yazarlar WHERE sirano=" + txtyazarsirano.Text, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                yazaryenile();
                MessageBox.Show("Yazar Silindi.");
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnyayinevikaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                komut = new OleDbCommand("INSERT INTO yayinevleri(ad) VALUES('" + txtyayineviad.Text.ToUpper() + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                yayineviyenile();
                MessageBox.Show("Yayinevi Eklendi.");
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void datayayinevi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int satirno = e.RowIndex;
                txtyayinevisirano.Text = datayayinevi.Rows[satirno].Cells[0].Value.ToString();
                txtyayineviad.Text = datayayinevi.Rows[satirno].Cells[1].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnyayinevisil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                komut = new OleDbCommand("DELETE FROM yayinevleri WHERE sirano=" + txtyayinevisirano.Text, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                yayineviyenile();
                MessageBox.Show("Yayinevi Silindi.");
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void datakitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int satirno = e.RowIndex;
                txtkitapsirano.Text = datakitap.Rows[satirno].Cells[0].Value.ToString();
                txtkitapadi.Text = datakitap.Rows[satirno].Cells[1].Value.ToString();
                cmbkitapyazar.Text = datakitap.Rows[satirno].Cells[2].Value.ToString();
                cmbkitapyayinevi.Text = datakitap.Rows[satirno].Cells[3].Value.ToString();
                txtkitapyayinyili.Text = datakitap.Rows[satirno].Cells[4].Value.ToString();
                cmbkitapturu.Text = datakitap.Rows[satirno].Cells[5].Value.ToString();
                txtkitapfiyati.Text = datakitap.Rows[satirno].Cells[6].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnkitapkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                komut = new OleDbCommand("INSERT INTO kitaplar(kitapadi,yazari,yayinevi,yayinyili,turu,fiyati) VALUES('" + txtkitapadi.Text.ToUpper() + "'," + cmbkitapyazar.SelectedValue.ToString() + "," + cmbkitapyayinevi.SelectedValue.ToString() + ",'" + txtkitapyayinyili.Text + "'," + cmbkitapturu.SelectedValue.ToString() + "," + txtkitapfiyati.Text + ")", baglanti);
                komut.ExecuteNonQuery();
                kitapyenile();
                MessageBox.Show("Kitap Eklendi.");
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void btnkitapsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                komut = new OleDbCommand("DELETE FROM kitaplar WHERE sirano=" + txtkitapsirano.Text, baglanti);
                komut.ExecuteNonQuery();
                kitapyenile();
                MessageBox.Show("Kitap Silindi.");
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
