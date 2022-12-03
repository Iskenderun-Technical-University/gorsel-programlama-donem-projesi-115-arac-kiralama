using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arac_kiralama
{
    internal class arac_kiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=BUSE-KUNU\\SQLEXPRESS;Initial Catalog=Arac-Kiralama-Otomasyonu;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut , string sorgu)
        {

        }
    }
}
