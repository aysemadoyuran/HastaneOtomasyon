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
    public partial class frm_doktor : Form
    {
        public frm_doktor()
        {
            InitializeComponent();
        }
        sql_baglanti bgl = new sql_baglanti();
        private void frm_doktor_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tbl_doktor ", bgl.baglanti()); 
            da2.Fill(dt2);
            dt_doktor.DataSource = dt2;
            SqlCommand komut2 = new SqlCommand("select brans_ad from tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text == "" || txt_soyad.Text == "" || txt_sifre.Text == "" || mtxt_tc.Text == "" || cmb_brans.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!");
            }
            else
            {
                SqlCommand kayit = new SqlCommand("insert into tbl_doktor(doktor_ad,doktor_soyad,doktor_brans,doktor_tc,doktor_sifre) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                kayit.Parameters.AddWithValue("@p1", txt_ad.Text);
                kayit.Parameters.AddWithValue("@p2", txt_soyad.Text);
                kayit.Parameters.AddWithValue("@p3", cmb_brans.Text);
                kayit.Parameters.AddWithValue("@p4", mtxt_tc.Text);
                kayit.Parameters.AddWithValue("@p5", txt_sifre.Text);
                kayit.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti! Şifreniz:" + txt_sifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ad.Text = "";
                txt_soyad.Text = "";
                cmb_brans.Text = "";
                mtxt_tc.Text = "";
                txt_sifre.Text = "";
            }
        }

        private void dt_doktor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dt_doktor.SelectedCells[0].RowIndex;
            txt_ad.Text = dt_doktor.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dt_doktor.Rows[secilen].Cells[2].Value.ToString();
            cmb_brans.Text = dt_doktor.Rows[secilen].Cells[3].Value.ToString();
            mtxt_tc.Text = dt_doktor.Rows[secilen].Cells[4].Value.ToString();
            txt_sifre.Text = dt_doktor.Rows[secilen].Cells[5].Value.ToString();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_doktor where doktor_tc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mtxt_tc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Kaydı Silindi!");
            txt_ad.Text = "";
            txt_soyad.Text = "";
            cmb_brans.Text = "";
            mtxt_tc.Text = "";
            txt_sifre.Text = "";
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            label4.Text = mtxt_tc.Text;
            SqlCommand komut2 = new SqlCommand("UPDATE tbl_doktor set doktor_ad=@p1,doktor_soyad=@p2,doktor_brans=@p3,doktor_sifre=@p4 where doktor_tc=@p5", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut2.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut2.Parameters.AddWithValue("@p3", cmb_brans.Text);
            komut2.Parameters.AddWithValue("@p4", txt_sifre.Text);
            komut2.Parameters.AddWithValue("@p5", label4.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Başarıyla Güncellendi!");
            txt_ad.Text = "";
            txt_soyad.Text = "";
            cmb_brans.Text = "";
            mtxt_tc.Text = "";
            txt_sifre.Text = "";
        }
    }
}
