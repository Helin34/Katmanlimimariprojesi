using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer1
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection("Data Source=LAPTOP-MFSA08GG\\MYDATABASESERVER;Initial Catalog=DbKatmanliMimari;Integrated Security=True");
    }
}
