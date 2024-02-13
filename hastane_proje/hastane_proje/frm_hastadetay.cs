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
    public partial class frm_hastadetay : Form
    {
        public frm_hastadetay()
        {
            InitializeComponent();
        }
        public string tc;
        sql_baglanti bgl = new sql_baglanti();
        private void frm_hastadetay_Load(object sender, EventArgs e)
        {
            //Ad-Soyad-Tc Çekme
            lbl_tc.Text = tc;
            SqlCommand komut = new SqlCommand("select hasta_ad,hasta_soyad from tbl_hasta where hasta_tc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lbl_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_ad_soyad.Text = dr[0] + "" + dr[1];
            }
            bgl.baglanti().Close();
            //Randevu Görüntüleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where hasta_tc="+tc,bgl.baglanti());
            da.Fill(dt);
            gr_gecmis_r.DataSource = dt;
            //Branşları Çekme

            SqlCommand komut2 = new SqlCommand("select brans_ad from tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();




        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select doktor_ad,doktor_soyad from tbl_doktor where doktor_brans=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",cmb_brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmb_doktor.Items.Add(dr3[0]+" "+dr3[1]);
            }
            bgl.baglanti().Close();


        }

        private void cmb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where randevu_brans='"+cmb_brans.Text+ "'and +randevu_doktor='"+cmb_doktor.Text+"' and randevu_durum=0", bgl.baglanti());
            da.Fill(dt);
            gr_aktif_r.DataSource = dt;

        }

        private void lnk_bilgi_duzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hasta_duzenle frm = new hasta_duzenle();
            frm.tcno = lbl_tc.Text;
            
            frm.Show();
        }

        private void gr_aktif_r_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = gr_aktif_r.SelectedCells[0].RowIndex;
            txt_id.Text = gr_aktif_r.Rows[secilen].Cells[0].Value.ToString();

        }
        private void btn_randevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_randevu set randevu_durum=1,hasta_tc=@p1,hasta_sikayet=@p2 where randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_tc.Text);
            komut.Parameters.AddWithValue("@p2", richTextBox1.Text);
            komut.Parameters.AddWithValue("@p3", txt_id.Text);
            MessageBox.Show("Kayıt İşlemi Yapıldı");
            komut.ExecuteNonQuery();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_hastagiris frm = new frm_hastagiris();
            frm.Show();
            this.Hide();
        }
    }
}
