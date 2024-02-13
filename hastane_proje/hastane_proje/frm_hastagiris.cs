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
    public partial class frm_hastagiris : Form
    {
        public frm_hastagiris()
        {
            InitializeComponent();
        }
        sql_baglanti bgl = new sql_baglanti();

        private void btn_giris_yap_Click(object sender, EventArgs e)
        {
            if (txt_sifre.Text==""||mtxt_kuladi.Text=="")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun!");
            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from tbl_hasta where hasta_tc=@p1 and hasta_sifre=@p2",bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", mtxt_kuladi.Text);
                komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
                SqlDataReader dr= komut.ExecuteReader();
                if (dr.Read())
                {
                    
                    frm_hastadetay frm = new frm_hastadetay();
                    frm.tc = mtxt_kuladi.Text;
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
            frm_hastakayit frm = new frm_hastakayit();
            frm.Show();



        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_girisler frm = new frm_girisler();
            frm.Show();
            this.Hide();
        }

        private void frm_hastagiris_Load(object sender, EventArgs e)
        {

        }
    }
}
