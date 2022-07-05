using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KutuphaneOtomasyonu
{
    class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan=new SqlConnection("Data Source=LAPTOP-9IQ5NO3T\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");

            baglan.Open();
            return baglan;
        }
    }
}
