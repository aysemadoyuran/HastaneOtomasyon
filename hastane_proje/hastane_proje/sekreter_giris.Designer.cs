namespace hastane_proje
{
    partial class sekreter_giris
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
            this.ln_uye_ol = new System.Windows.Forms.LinkLabel();
            this.btn_giris_yap = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.mtxt_kuladi = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ln_uye_ol
            // 
            this.ln_uye_ol.AutoSize = true;
            this.ln_uye_ol.Location = new System.Drawing.Point(276, 334);
            this.ln_uye_ol.Name = "ln_uye_ol";
            this.ln_uye_ol.Size = new System.Drawing.Size(62, 23);
            this.ln_uye_ol.TabIndex = 13;
            this.ln_uye_ol.TabStop = true;
            this.ln_uye_ol.Text = "Üye Ol";
            this.ln_uye_ol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ln_uye_ol_LinkClicked);
            // 
            // btn_giris_yap
            // 
            this.btn_giris_yap.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris_yap.Location = new System.Drawing.Point(182, 304);
            this.btn_giris_yap.Name = "btn_giris_yap";
            this.btn_giris_yap.Size = new System.Drawing.Size(156, 25);
            this.btn_giris_yap.TabIndex = 12;
            this.btn_giris_yap.Text = "Giriş Yap";
            this.btn_giris_yap.UseVisualStyleBackColor = true;
            this.btn_giris_yap.Click += new System.EventHandler(this.btn_giris_yap_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(182, 256);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(156, 31);
            this.txt_sifre.TabIndex = 11;
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // mtxt_kuladi
            // 
            this.mtxt_kuladi.Location = new System.Drawing.Point(182, 200);
            this.mtxt_kuladi.Mask = "00000000000";
            this.mtxt_kuladi.Name = "mtxt_kuladi";
            this.mtxt_kuladi.Size = new System.Drawing.Size(156, 31);
            this.mtxt_kuladi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sekreter Giris Paneli";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(382, 430);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(79, 23);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Geri Dön";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // sekreter_giris
            // 
            this.AcceptButton = this.btn_giris_yap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(473, 462);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.ln_uye_ol);
            this.Controls.Add(this.btn_giris_yap);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.mtxt_kuladi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "sekreter_giris";
            this.Text = "sekreter_giris";
            this.Load += new System.EventHandler(this.sekreter_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ln_uye_ol;
        private System.Windows.Forms.Button btn_giris_yap;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.MaskedTextBox mtxt_kuladi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}