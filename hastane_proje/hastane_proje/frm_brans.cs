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
    public partial class frm_brans : Form
    {
        public frm_brans()
        {
            InitializeComponent();
        }
        sql_baglanti bgl = new sql_baglanti();
        private void frm_brans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans ", bgl.baglanti());
            da.Fill(dt);
            dt_brans.DataSource = dt;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_brans (brans_ad) values(@p1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txt_brans.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti!");
            txt_brans.Text = "";
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_brans where brans_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_id.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Kaydı Silindi!");
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("UPDATE tbl_brans set brans_ad=@p1 where brans_id=@p5", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txt_brans.Text);
            komut2.Parameters.AddWithValue("@p5", txt_id.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Kaydınız Başarıyla Güncellendi!");
        }

        private void dt_brans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dt_brans.SelectedCells[0].RowIndex;
            txt_id.Text = dt_brans.Rows[secilen].Cells[0].Value.ToString();
            txt_brans.Text = dt_brans.Rows[secilen].Cells[1].Value.ToString();

        }
    }
}
