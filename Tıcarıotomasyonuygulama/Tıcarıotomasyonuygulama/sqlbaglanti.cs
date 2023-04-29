using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Tıcarıotomasyonuygulama
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0H9IOOS\\SQLEXPRESS;Initial Catalog=DBO_Tıcariotomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
