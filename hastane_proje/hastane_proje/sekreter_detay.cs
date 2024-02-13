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
    public partial class sekreter_detay : Form
    {
        public sekreter_detay()
        {
            InitializeComponent();
        }
        public string TC_no;
        sql_baglanti bgl = new sql_baglanti();
        private void sekreter_detay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = TC_no;
            SqlCommand komut = new SqlCommand("select sekreter_adsoyad from tbl_sekreter where sekreter_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_ad_soyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            SqlCommand komut2 = new SqlCommand("select brans_ad from tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans ", bgl.baglanti());
            da.Fill(dt);
            grd_brans.DataSource = dt;
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doktor_ad+' '+doktor_soyad) as 'Doktorlar',doktor_brans,doktor_tc from tbl_doktor ", bgl.baglanti());
            da2.Fill(dt2);
            grd_doktor.DataSource = dt2;


        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (mtxt_tc.Text == "" || mtxt_tarih.Text == "" || mtxt_saat.Text == "" || cmb_doktor.Text == "" || cmb_brans.Text == "" || chk_durum.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!");
            }
            else
            {
                SqlCommand kayit = new SqlCommand("insert into tbl_randevu(randevu_tarih,randevu_saat,randevu_brans,randevu_doktor) values(@p1,@p2,@p3,@p4)", bgl.baglanti());
                kayit.Parameters.AddWithValue("@p1", mtxt_tarih.Text);
                kayit.Parameters.AddWithValue("@p2", mtxt_saat.Text);
                kayit.Parameters.AddWithValue("@p3", cmb_brans.Text);
                kayit.Parameters.AddWithValue("@p4", cmb_doktor.Text);
                kayit.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Randevu Oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select doktor_ad,doktor_soyad from tbl_doktor where doktor_brans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmb_doktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void btn_duyuru_olustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_duyuru (duyuru_icerik) values (@p1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",rctxt_duyuru.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru Oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_doktor_p_Click(object sender, EventArgs e)
        {
            frm_doktor frm = new frm_doktor();
            frm.Show();

        }

        private void btn_brans_p_Click(object sender, EventArgs e)
        {
            frm_brans frm = new frm_brans();
            frm.Show();
        }

        private void btn_randevu_liste_Click(object sender, EventArgs e)
        {
            frm_randevu_liste frm = new frm_randevu_liste();
            frm.Show();
        }

        private void btn_duyuru_Click(object sender, EventArgs e)
        {
            frm_duyuru frm = new frm_duyuru();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sekreter_giris frm = new sekreter_giris();
            frm.Show();
            this.Hide();

        }
    }
}
