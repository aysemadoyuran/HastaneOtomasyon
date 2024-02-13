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
    public partial class hasta_duzenle : Form
    {
        public hasta_duzenle()
        {
            InitializeComponent();
        }
        public string tcno;

        sql_baglanti bgl = new sql_baglanti();
        private void hasta_duzenle_Load(object sender, EventArgs e)
        {
            mtxt_tc.Text = tcno;
            SqlCommand komut = new SqlCommand("select * from tbl_hasta where hasta_tc='"+mtxt_tc.Text+"'",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                mtxt_tel.Text = dr[4].ToString();
                txt_sifre.Text = dr[5].ToString();
                cmb_cinsiyet.Text = dr[6].ToString();
                
            }
            bgl.baglanti().Close();
            
        }
        

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            label7.Text = mtxt_tc.Text;
            SqlCommand komut2 = new SqlCommand("update tbl_hasta set hasta_ad=@p1,hasta_soyad=@p2,hasta_tc=@p3,hasta_telefon=@p4,hasta_sifre=@p5,hasta_cinsiyet=@p6 where hasta_tc=@p7",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",txt_ad.Text);
            komut2.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut2.Parameters.AddWithValue("@p3", mtxt_tc.Text);
            komut2.Parameters.AddWithValue("@p4", mtxt_tel.Text);
            komut2.Parameters.AddWithValue("@p5", txt_sifre.Text);
            komut2.Parameters.AddWithValue("@p6", cmb_cinsiyet.Text);
            komut2.Parameters.AddWithValue("@p7", label7.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Başarıyla Güncellendi!");
        }
    }
}
