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
    public partial class frm_randevu_liste : Form
    {
        public frm_randevu_liste()
        {
            InitializeComponent();
        }
        sql_baglanti bgl = new sql_baglanti();
        private void frm_randevu_liste_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
    }
}
