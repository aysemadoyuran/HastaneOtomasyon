namespace hastane_proje
{
    partial class sekreter_detay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ad_soyad = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_duyuru_olustur = new System.Windows.Forms.Button();
            this.rctxt_duyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.chk_durum = new System.Windows.Forms.CheckBox();
            this.mtxt_tc = new System.Windows.Forms.MaskedTextBox();
            this.cmb_doktor = new System.Windows.Forms.ComboBox();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.mtxt_saat = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_tarih = new System.Windows.Forms.MaskedTextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grd_brans = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grd_doktor = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_duyuru = new System.Windows.Forms.Button();
            this.btn_randevu_liste = new System.Windows.Forms.Button();
            this.btn_brans_p = new System.Windows.Forms.Button();
            this.btn_doktor_p = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_brans)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_doktor)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ad_soyad);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lbl_ad_soyad
            // 
            this.lbl_ad_soyad.AutoSize = true;
            this.lbl_ad_soyad.Location = new System.Drawing.Point(107, 102);
            this.lbl_ad_soyad.Name = "lbl_ad_soyad";
            this.lbl_ad_soyad.Size = new System.Drawing.Size(76, 23);
            this.lbl_ad_soyad.TabIndex = 3;
            this.lbl_ad_soyad.Text = "Null Null";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(105, 57);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(120, 23);
            this.lbl_tc.TabIndex = 2;
            this.lbl_tc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_duyuru_olustur);
            this.groupBox2.Controls.Add(this.rctxt_duyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 388);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btn_duyuru_olustur
            // 
            this.btn_duyuru_olustur.Location = new System.Drawing.Point(59, 339);
            this.btn_duyuru_olustur.Name = "btn_duyuru_olustur";
            this.btn_duyuru_olustur.Size = new System.Drawing.Size(192, 29);
            this.btn_duyuru_olustur.TabIndex = 3;
            this.btn_duyuru_olustur.Text = "Oluştur";
            this.btn_duyuru_olustur.UseVisualStyleBackColor = true;
            this.btn_duyuru_olustur.Click += new System.EventHandler(this.btn_duyuru_olustur_Click);
            // 
            // rctxt_duyuru
            // 
            this.rctxt_duyuru.Location = new System.Drawing.Point(3, 27);
            this.rctxt_duyuru.Name = "rctxt_duyuru";
            this.rctxt_duyuru.Size = new System.Drawing.Size(304, 306);
            this.rctxt_duyuru.TabIndex = 0;
            this.rctxt_duyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_kaydet);
            this.groupBox3.Controls.Add(this.chk_durum);
            this.groupBox3.Controls.Add(this.mtxt_tc);
            this.groupBox3.Controls.Add(this.cmb_doktor);
            this.groupBox3.Controls.Add(this.cmb_brans);
            this.groupBox3.Controls.Add(this.mtxt_saat);
            this.groupBox3.Controls.Add(this.mtxt_tarih);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(331, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 587);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(116, 434);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(172, 44);
            this.btn_kaydet.TabIndex = 17;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // chk_durum
            // 
            this.chk_durum.AutoSize = true;
            this.chk_durum.Location = new System.Drawing.Point(116, 395);
            this.chk_durum.Name = "chk_durum";
            this.chk_durum.Size = new System.Drawing.Size(84, 27);
            this.chk_durum.TabIndex = 16;
            this.chk_durum.Text = "Durum";
            this.chk_durum.UseVisualStyleBackColor = true;
            // 
            // mtxt_tc
            // 
            this.mtxt_tc.Location = new System.Drawing.Point(116, 349);
            this.mtxt_tc.Mask = "00000000000";
            this.mtxt_tc.Name = "mtxt_tc";
            this.mtxt_tc.Size = new System.Drawing.Size(172, 31);
            this.mtxt_tc.TabIndex = 15;
            // 
            // cmb_doktor
            // 
            this.cmb_doktor.FormattingEnabled = true;
            this.cmb_doktor.Location = new System.Drawing.Point(116, 300);
            this.cmb_doktor.Name = "cmb_doktor";
            this.cmb_doktor.Size = new System.Drawing.Size(172, 31);
            this.cmb_doktor.TabIndex = 14;
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(116, 249);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(172, 31);
            this.cmb_brans.TabIndex = 13;
            this.cmb_brans.SelectedIndexChanged += new System.EventHandler(this.cmb_brans_SelectedIndexChanged);
            // 
            // mtxt_saat
            // 
            this.mtxt_saat.Location = new System.Drawing.Point(116, 207);
            this.mtxt_saat.Mask = "00:00";
            this.mtxt_saat.Name = "mtxt_saat";
            this.mtxt_saat.Size = new System.Drawing.Size(172, 31);
            this.mtxt_saat.TabIndex = 12;
            this.mtxt_saat.ValidatingType = typeof(System.DateTime);
            // 
            // mtxt_tarih
            // 
            this.mtxt_tarih.Location = new System.Drawing.Point(116, 156);
            this.mtxt_tarih.Mask = "00/00/0000";
            this.mtxt_tarih.Name = "mtxt_tarih";
            this.mtxt_tarih.Size = new System.Drawing.Size(172, 31);
            this.mtxt_tarih.TabIndex = 11;
            this.mtxt_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(116, 99);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(172, 31);
            this.txt_id.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Branş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Saat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tarih:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grd_brans);
            this.groupBox4.Location = new System.Drawing.Point(705, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(567, 351);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // grd_brans
            // 
            this.grd_brans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_brans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_brans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_brans.Location = new System.Drawing.Point(3, 27);
            this.grd_brans.Name = "grd_brans";
            this.grd_brans.Size = new System.Drawing.Size(561, 321);
            this.grd_brans.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grd_doktor);
            this.groupBox5.Location = new System.Drawing.Point(705, 412);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(567, 352);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar:";
            // 
            // grd_doktor
            // 
            this.grd_doktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_doktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_doktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_doktor.Location = new System.Drawing.Point(3, 27);
            this.grd_doktor.Name = "grd_doktor";
            this.grd_doktor.Size = new System.Drawing.Size(561, 322);
            this.grd_doktor.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_duyuru);
            this.groupBox6.Controls.Add(this.btn_randevu_liste);
            this.groupBox6.Controls.Add(this.btn_brans_p);
            this.groupBox6.Controls.Add(this.btn_doktor_p);
            this.groupBox6.Location = new System.Drawing.Point(12, 648);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(690, 116);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btn_duyuru
            // 
            this.btn_duyuru.Location = new System.Drawing.Point(538, 40);
            this.btn_duyuru.Name = "btn_duyuru";
            this.btn_duyuru.Size = new System.Drawing.Size(146, 41);
            this.btn_duyuru.TabIndex = 3;
            this.btn_duyuru.Text = "Duyurular";
            this.btn_duyuru.UseVisualStyleBackColor = true;
            this.btn_duyuru.Click += new System.EventHandler(this.btn_duyuru_Click);
            // 
            // btn_randevu_liste
            // 
            this.btn_randevu_liste.Location = new System.Drawing.Point(360, 40);
            this.btn_randevu_liste.Name = "btn_randevu_liste";
            this.btn_randevu_liste.Size = new System.Drawing.Size(172, 41);
            this.btn_randevu_liste.TabIndex = 2;
            this.btn_randevu_liste.Text = "Randevu Liste";
            this.btn_randevu_liste.UseVisualStyleBackColor = true;
            this.btn_randevu_liste.Click += new System.EventHandler(this.btn_randevu_liste_Click);
            // 
            // btn_brans_p
            // 
            this.btn_brans_p.Location = new System.Drawing.Point(182, 40);
            this.btn_brans_p.Name = "btn_brans_p";
            this.btn_brans_p.Size = new System.Drawing.Size(172, 41);
            this.btn_brans_p.TabIndex = 1;
            this.btn_brans_p.Text = "Branş Paneli";
            this.btn_brans_p.UseVisualStyleBackColor = true;
            this.btn_brans_p.Click += new System.EventHandler(this.btn_brans_p_Click);
            // 
            // btn_doktor_p
            // 
            this.btn_doktor_p.Location = new System.Drawing.Point(4, 40);
            this.btn_doktor_p.Name = "btn_doktor_p";
            this.btn_doktor_p.Size = new System.Drawing.Size(172, 43);
            this.btn_doktor_p.TabIndex = 0;
            this.btn_doktor_p.Text = "Doktor Paneli";
            this.btn_doktor_p.UseVisualStyleBackColor = true;
            this.btn_doktor_p.Click += new System.EventHandler(this.btn_doktor_p_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1128, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Oturumu Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sekreter_detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1279, 770);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "sekreter_detay";
            this.Text = "sekreter_detay";
            this.Load += new System.EventHandler(this.sekreter_detay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_brans)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_doktor)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grd_brans;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbl_ad_soyad;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_duyuru_olustur;
        private System.Windows.Forms.RichTextBox rctxt_duyuru;
        private System.Windows.Forms.DataGridView grd_doktor;
        private System.Windows.Forms.Button btn_randevu_liste;
        private System.Windows.Forms.Button btn_brans_p;
        private System.Windows.Forms.Button btn_doktor_p;
        private System.Windows.Forms.ComboBox cmb_doktor;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.MaskedTextBox mtxt_saat;
        private System.Windows.Forms.MaskedTextBox mtxt_tarih;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.CheckBox chk_durum;
        private System.Windows.Forms.MaskedTextBox mtxt_tc;
        private System.Windows.Forms.Button btn_duyuru;
        private System.Windows.Forms.Button button1;
    }
}