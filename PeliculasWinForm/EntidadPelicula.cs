using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasWinForm
{
    public class EntidadPelicula
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }

        public EntidadPelicula() { }

        public EntidadPelicula(int pId, string pCodigo, string pNombre, string pDescripcion, string pFecha)
        {
            this.Id = pId;
            this.Codigo = pCodigo;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.Fecha = pFecha;
        }

    }
}
