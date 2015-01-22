//https://www.youtube.com/watch?v=uhkvlWskv-M
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PeliculasWinForm
{
    public class DataConn
    {
        public static SqlConnection conexion()
        {
            SqlConnection conn = new SqlConnection(@"Data source=Developer\SQLEXPRESS; Initial Catalog=DBPELICULAS;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
