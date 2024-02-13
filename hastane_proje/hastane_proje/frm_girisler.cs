using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_proje
{
    public partial class frm_girisler : Form
    {
        public frm_girisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_hastagiris hasta = new frm_hastagiris();
            hasta.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dr_giris dr = new dr_giris();
            dr.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sekreter_giris sr = new sekreter_giris();
            sr.Show();
            this.Hide();

        }
    }
}
