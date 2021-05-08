namespace kutuphane
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datatur = new System.Windows.Forms.DataGridView();
            this.btntursil = new System.Windows.Forms.Button();
            this.btnturkaydet = new System.Windows.Forms.Button();
            this.txtturtur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttursirano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.datayazar = new System.Windows.Forms.DataGridView();
            this.btnyazarsil = new System.Windows.Forms.Button();
            this.btnyazarkaydet = new System.Windows.Forms.Button();
            this.txtyazaradisoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyazarsirano = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datayayinevi = new System.Windows.Forms.DataGridView();
            this.btnyayinevisil = new System.Windows.Forms.Button();
            this.btnyayinevikaydet = new System.Windows.Forms.Button();
            this.txtyayineviad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtyayinevisirano = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtkitapsirano = new System.Windows.Forms.TextBox();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbkitapyazar = new System.Windows.Forms.ComboBox();
            this.cmbkitapyayinevi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtkitapyayinyili = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbkitapturu = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtkitapfiyati = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnkitapkaydet = new System.Windows.Forms.Button();
            this.btnkitapsil = new System.Windows.Forms.Button();
            this.datakitap = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatur)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datayazar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datayayinevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datakitap)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 365);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datatur);
            this.tabPage1.Controls.Add(this.btntursil);
            this.tabPage1.Controls.Add(this.btnturkaydet);
            this.tabPage1.Controls.Add(this.txtturtur);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txttursirano);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(469, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tür Tanımlama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // datatur
            // 
            this.datatur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatur.Location = new System.Drawing.Point(9, 59);
            this.datatur.Name = "datatur";
            this.datatur.ReadOnly = true;
            this.datatur.Size = new System.Drawing.Size(454, 274);
            this.datatur.TabIndex = 6;
            this.datatur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datatur_CellClick);
            // 
            // btntursil
            // 
            this.btntursil.Location = new System.Drawing.Point(354, 9);
            this.btntursil.Name = "btntursil";
            this.btntursil.Size = new System.Drawing.Size(75, 23);
            this.btntursil.TabIndex = 5;
            this.btntursil.Text = "Sil";
            this.btntursil.UseVisualStyleBackColor = true;
            this.btntursil.Click += new System.EventHandler(this.btntursil_Click);
            // 
            // btnturkaydet
            // 
            this.btnturkaydet.Location = new System.Drawing.Point(241, 9);
            this.btnturkaydet.Name = "btnturkaydet";
            this.btnturkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnturkaydet.TabIndex = 4;
            this.btnturkaydet.Text = "Kaydet";
            this.btnturkaydet.UseVisualStyleBackColor = true;
            this.btnturkaydet.Click += new System.EventHandler(this.btnturkaydet_Click);
            // 
            // txtturtur
            // 
            this.txtturtur.Location = new System.Drawing.Point(93, 32);
            this.txtturtur.Name = "txtturtur";
            this.txtturtur.Size = new System.Drawing.Size(100, 20);
            this.txtturtur.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tür";
            // 
            // txttursirano
            // 
            this.txttursirano.Enabled = false;
            this.txttursirano.Location = new System.Drawing.Point(93, 6);
            this.txttursirano.Name = "txttursirano";
            this.txttursirano.Size = new System.Drawing.Size(100, 20);
            this.txttursirano.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sıra No";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.datayazar);
            this.tabPage2.Controls.Add(this.btnyazarsil);
            this.tabPage2.Controls.Add(this.btnyazarkaydet);
            this.tabPage2.Controls.Add(this.txtyazaradisoyadi);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtyazarsirano);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(469, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yazar Tanımlama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.datayayinevi);
            this.tabPage3.Controls.Add(this.btnyayinevisil);
            this.tabPage3.Controls.Add(this.btnyayinevikaydet);
            this.tabPage3.Controls.Add(this.txtyayineviad);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtyayinevisirano);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(469, 339);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Yayınevi Tanımlama";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.datakitap);
            this.tabPage4.Controls.Add(this.btnkitapsil);
            this.tabPage4.Controls.Add(this.btnkitapkaydet);
            this.tabPage4.Controls.Add(this.txtkitapfiyati);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.cmbkitapturu);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.txtkitapyayinyili);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.cmbkitapyayinevi);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.cmbkitapyazar);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txtkitapadi);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txtkitapsirano);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(469, 339);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kitap Tanımlama";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // datayazar
            // 
            this.datayazar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datayazar.Location = new System.Drawing.Point(9, 59);
            this.datayazar.Name = "datayazar";
            this.datayazar.ReadOnly = true;
            this.datayazar.Size = new System.Drawing.Size(454, 274);
            this.datayazar.TabIndex = 13;
            this.datayazar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datayazar_CellClick);
            // 
            // btnyazarsil
            // 
            this.btnyazarsil.Location = new System.Drawing.Point(354, 9);
            this.btnyazarsil.Name = "btnyazarsil";
            this.btnyazarsil.Size = new System.Drawing.Size(75, 23);
            this.btnyazarsil.TabIndex = 12;
            this.btnyazarsil.Text = "Sil";
            this.btnyazarsil.UseVisualStyleBackColor = true;
            this.btnyazarsil.Click += new System.EventHandler(this.btnyazarsil_Click);
            // 
            // btnyazarkaydet
            // 
            this.btnyazarkaydet.Location = new System.Drawing.Point(241, 9);
            this.btnyazarkaydet.Name = "btnyazarkaydet";
            this.btnyazarkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnyazarkaydet.TabIndex = 11;
            this.btnyazarkaydet.Text = "Kaydet";
            this.btnyazarkaydet.UseVisualStyleBackColor = true;
            this.btnyazarkaydet.Click += new System.EventHandler(this.btnyazarkaydet_Click);
            // 
            // txtyazaradisoyadi
            // 
            this.txtyazaradisoyadi.Location = new System.Drawing.Point(93, 32);
            this.txtyazaradisoyadi.Name = "txtyazaradisoyadi";
            this.txtyazaradisoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtyazaradisoyadi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adı Soyadı";
            // 
            // txtyazarsirano
            // 
            this.txtyazarsirano.Enabled = false;
            this.txtyazarsirano.Location = new System.Drawing.Point(93, 6);
            this.txtyazarsirano.Name = "txtyazarsirano";
            this.txtyazarsirano.Size = new System.Drawing.Size(100, 20);
            this.txtyazarsirano.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sıra No";
            // 
            // datayayinevi
            // 
            this.datayayinevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datayayinevi.Location = new System.Drawing.Point(9, 59);
            this.datayayinevi.Name = "datayayinevi";
            this.datayayinevi.ReadOnly = true;
            this.datayayinevi.Size = new System.Drawing.Size(454, 274);
            this.datayayinevi.TabIndex = 20;
            this.datayayinevi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datayayinevi_CellClick);
            // 
            // btnyayinevisil
            // 
            this.btnyayinevisil.Location = new System.Drawing.Point(354, 9);
            this.btnyayinevisil.Name = "btnyayinevisil";
            this.btnyayinevisil.Size = new System.Drawing.Size(75, 23);
            this.btnyayinevisil.TabIndex = 19;
            this.btnyayinevisil.Text = "Sil";
            this.btnyayinevisil.UseVisualStyleBackColor = true;
            this.btnyayinevisil.Click += new System.EventHandler(this.btnyayinevisil_Click);
            // 
            // btnyayinevikaydet
            // 
            this.btnyayinevikaydet.Location = new System.Drawing.Point(241, 9);
            this.btnyayinevikaydet.Name = "btnyayinevikaydet";
            this.btnyayinevikaydet.Size = new System.Drawing.Size(75, 23);
            this.btnyayinevikaydet.TabIndex = 18;
            this.btnyayinevikaydet.Text = "Kaydet";
            this.btnyayinevikaydet.UseVisualStyleBackColor = true;
            this.btnyayinevikaydet.Click += new System.EventHandler(this.btnyayinevikaydet_Click);
            // 
            // txtyayineviad
            // 
            this.txtyayineviad.Location = new System.Drawing.Point(93, 32);
            this.txtyayineviad.Name = "txtyayineviad";
            this.txtyayineviad.Size = new System.Drawing.Size(100, 20);
            this.txtyayineviad.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ad";
            // 
            // txtyayinevisirano
            // 
            this.txtyayinevisirano.Enabled = false;
            this.txtyayinevisirano.Location = new System.Drawing.Point(93, 6);
            this.txtyayinevisirano.Name = "txtyayinevisirano";
            this.txtyayinevisirano.Size = new System.Drawing.Size(100, 20);
            this.txtyayinevisirano.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sıra No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sıra No";
            // 
            // txtkitapsirano
            // 
            this.txtkitapsirano.Enabled = false;
            this.txtkitapsirano.Location = new System.Drawing.Point(92, 6);
            this.txtkitapsirano.Name = "txtkitapsirano";
            this.txtkitapsirano.Size = new System.Drawing.Size(100, 20);
            this.txtkitapsirano.TabIndex = 1;
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Location = new System.Drawing.Point(92, 32);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(100, 20);
            this.txtkitapadi.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kitap Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Yazarı";
            // 
            // cmbkitapyazar
            // 
            this.cmbkitapyazar.FormattingEnabled = true;
            this.cmbkitapyazar.Location = new System.Drawing.Point(92, 58);
            this.cmbkitapyazar.Name = "cmbkitapyazar";
            this.cmbkitapyazar.Size = new System.Drawing.Size(100, 21);
            this.cmbkitapyazar.TabIndex = 5;
            // 
            // cmbkitapyayinevi
            // 
            this.cmbkitapyayinevi.FormattingEnabled = true;
            this.cmbkitapyayinevi.Location = new System.Drawing.Point(92, 85);
            this.cmbkitapyayinevi.Name = "cmbkitapyayinevi";
            this.cmbkitapyayinevi.Size = new System.Drawing.Size(100, 21);
            this.cmbkitapyayinevi.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Yayınevi";
            // 
            // txtkitapyayinyili
            // 
            this.txtkitapyayinyili.Location = new System.Drawing.Point(92, 112);
            this.txtkitapyayinyili.Name = "txtkitapyayinyili";
            this.txtkitapyayinyili.Size = new System.Drawing.Size(100, 20);
            this.txtkitapyayinyili.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Yayın Yılı";
            // 
            // cmbkitapturu
            // 
            this.cmbkitapturu.FormattingEnabled = true;
            this.cmbkitapturu.Location = new System.Drawing.Point(92, 138);
            this.cmbkitapturu.Name = "cmbkitapturu";
            this.cmbkitapturu.Size = new System.Drawing.Size(100, 21);
            this.cmbkitapturu.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Türü";
            // 
            // txtkitapfiyati
            // 
            this.txtkitapfiyati.Location = new System.Drawing.Point(92, 165);
            this.txtkitapfiyati.Name = "txtkitapfiyati";
            this.txtkitapfiyati.Size = new System.Drawing.Size(100, 20);
            this.txtkitapfiyati.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Fiyatı";
            // 
            // btnkitapkaydet
            // 
            this.btnkitapkaydet.Location = new System.Drawing.Point(63, 191);
            this.btnkitapkaydet.Name = "btnkitapkaydet";
            this.btnkitapkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkitapkaydet.TabIndex = 14;
            this.btnkitapkaydet.Text = "Kaydet";
            this.btnkitapkaydet.UseVisualStyleBackColor = true;
            this.btnkitapkaydet.Click += new System.EventHandler(this.btnkitapkaydet_Click);
            // 
            // btnkitapsil
            // 
            this.btnkitapsil.Location = new System.Drawing.Point(63, 220);
            this.btnkitapsil.Name = "btnkitapsil";
            this.btnkitapsil.Size = new System.Drawing.Size(75, 24);
            this.btnkitapsil.TabIndex = 15;
            this.btnkitapsil.Text = "Sil";
            this.btnkitapsil.UseVisualStyleBackColor = true;
            this.btnkitapsil.Click += new System.EventHandler(this.btnkitapsil_Click);
            // 
            // datakitap
            // 
            this.datakitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datakitap.Location = new System.Drawing.Point(198, 6);
            this.datakitap.Name = "datakitap";
            this.datakitap.ReadOnly = true;
            this.datakitap.Size = new System.Drawing.Size(265, 327);
            this.datakitap.TabIndex = 16;
            this.datakitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datakitap_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 389);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Kütüphane Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatur)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datayazar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datayayinevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datakitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView datatur;
        private System.Windows.Forms.Button btntursil;
        private System.Windows.Forms.Button btnturkaydet;
        private System.Windows.Forms.TextBox txtturtur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttursirano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView datayazar;
        private System.Windows.Forms.Button btnyazarsil;
        private System.Windows.Forms.Button btnyazarkaydet;
        private System.Windows.Forms.TextBox txtyazaradisoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyazarsirano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView datayayinevi;
        private System.Windows.Forms.Button btnyayinevisil;
        private System.Windows.Forms.Button btnyayinevikaydet;
        private System.Windows.Forms.TextBox txtyayineviad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtyayinevisirano;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView datakitap;
        private System.Windows.Forms.Button btnkitapsil;
        private System.Windows.Forms.Button btnkitapkaydet;
        private System.Windows.Forms.TextBox txtkitapfiyati;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbkitapturu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtkitapyayinyili;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbkitapyayinevi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbkitapyazar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtkitapsirano;
        private System.Windows.Forms.Label label7;
    }
}

