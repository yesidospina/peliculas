using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PeliculasWinForm
{
    public class DalPelicula
    {
        public static int Insertar(EntidadPelicula entidad)
        {
            int dato = 0;
            using (SqlConnection conn = DataConn.conexion())
            {
                SqlCommand cmd = new SqlCommand(string.Format("Insert into TB_PELICULAS (Codigo, Nombre, Descripcion, FechaCreacion, Imagen) values ('{0}','{1}','{2}','{3}','{4}')", entidad.Codigo, entidad.Nombre, entidad.Descripcion, entidad.Fecha, "null"), conn);
                dato = cmd.ExecuteNonQuery();
            }
            return dato;
        }
    }
}
