using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hastane_proje
{
    public partial class frm_hastakayit : Form
    {
        public frm_hastakayit()
        {
            InitializeComponent();
        }
        sql_baglanti bgl = new sql_baglanti();
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text==""||txt_soyad.Text==""||txt_sifre.Text==""||mtxt_tc.Text==""||mtxt_tel.Text==""||cmb_cinsiyet.Text=="")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!");
            }
            else
            {
                SqlCommand kayit = new SqlCommand("insert into tbl_hasta(hasta_ad,hasta_soyad,hasta_tc,hasta_telefon,hasta_sifre,hasta_cinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                kayit.Parameters.AddWithValue("@p1", txt_ad.Text);
                kayit.Parameters.AddWithValue("@p2", txt_soyad.Text);
                kayit.Parameters.AddWithValue("@p3", mtxt_tc.Text);
                kayit.Parameters.AddWithValue("@p4", mtxt_tel.Text);
                kayit.Parameters.AddWithValue("@p5", txt_sifre.Text);
                kayit.Parameters.AddWithValue("@p6", cmb_cinsiyet.Text);
                kayit.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti! Şifreniz:" + txt_sifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        private void frm_hastakayit_Load(object sender, EventArgs e)
        {

        }
    }
}
