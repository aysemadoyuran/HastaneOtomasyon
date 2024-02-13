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
    public partial class dr_detay : Form
    {
        public dr_detay()
        {
            InitializeComponent();
        }
        public string tc;
        sql_baglanti bgl = new sql_baglanti();
        private void dr_detay_Load(object sender, EventArgs e)
        {
            label3.Text = tc;
            SqlCommand komut = new SqlCommand("select doktor_ad,doktor_soyad from tbl_doktor where doktor_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label3.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label4.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where randevu_doktor='"+label4.Text+"'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();


        }

        private void btn_bilgi_duzenle_Click(object sender, EventArgs e)
        {
            frm_doktor_duzenle frm = new frm_doktor_duzenle();
            frm.tc = label3.Text;
            frm.Show();
        }

        private void btn_duyuru_Click(object sender, EventArgs e)
        {
            frm_duyuru frm = new frm_duyuru();
            frm.Show();

        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dr_giris frm = new dr_giris();
            frm.Show();
            this.Hide();
        }
    }
}
