using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastane_proje
{
    class sql_baglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=***;Initial Catalog=hastane_proje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
