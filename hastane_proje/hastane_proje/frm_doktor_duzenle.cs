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
    public partial class frm_doktor_duzenle : Form
    {
        public frm_doktor_duzenle()
        {
            InitializeComponent();
        }
        sql_baglanti bgl = new sql_baglanti();
        public string tc;
        private void frm_doktor_duzenle_Load(object sender, EventArgs e)
        {
            mtxt_tc.Text = tc;
            SqlCommand komut = new SqlCommand("select * from tbl_doktor where doktor_tc='" + mtxt_tc.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                cmb_brans.Text = dr[3].ToString();
                txt_sifre.Text = dr[5].ToString();

            }
            bgl.baglanti().Close();
        }
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            mtxt_tc.Text = tc;
            SqlCommand komut2 = new SqlCommand("update tbl_doktor set doktor_ad=@p1,doktor_soyad=@p2,doktor_brans=@p3,doktor_sifre=@p4 where doktor_tc=@p5", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut2.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut2.Parameters.AddWithValue("@p3", cmb_brans.Text);
            komut2.Parameters.AddWithValue("@p4", txt_sifre.Text);
            komut2.Parameters.AddWithValue("@p5", mtxt_tc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Başarıyla Güncellendi!");
        }
    }
}
