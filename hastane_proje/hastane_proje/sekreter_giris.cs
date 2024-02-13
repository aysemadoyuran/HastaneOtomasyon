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
    public partial class sekreter_giris : Form
    {
        sql_baglanti bgl = new sql_baglanti();
        public sekreter_giris()
        {
            InitializeComponent();
        }

        private void btn_giris_yap_Click(object sender, EventArgs e)
        {
            if (txt_sifre.Text == "" || mtxt_kuladi.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun!");
            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from tbl_sekreter where sekreter_tc=@p1 and sekreter_sifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", mtxt_kuladi.Text);
                komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {

                    sekreter_detay frm = new sekreter_detay();
                    frm.TC_no = mtxt_kuladi.Text;
                    frm.Show();              
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş!");
                }
                bgl.baglanti().Close();
            }
        }

        private void ln_uye_ol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sekreter_detay frm = new sekreter_detay();
            frm.Show();
        }

        private void sekreter_giris_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_girisler frm = new frm_girisler();
            frm.Show();
            this.Hide();
        }
    }
}
