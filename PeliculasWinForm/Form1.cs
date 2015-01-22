using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliculasWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntidadPelicula entidad = new EntidadPelicula();

            entidad.Codigo = txtCodigo.Text;
            entidad.Nombre = txtNombre.Text;
            entidad.Descripcion = txtDescripcion.Text;
            entidad.Fecha = txtFecha.Text;
            
                int resultado = DalPelicula.Insertar(entidad);
                if (resultado > 0)
                {
                    MessageBox.Show("Guardado Exitoso", "Guardar Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtDescripcion.Text = "";
                    txtFecha.Text = "";

                    Form2 formDos = new Form2();
                    formDos.Show();
                }
                else
                {
                    MessageBox.Show("Problema al Guardar", "Guardar Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFecha.Text = "";
                }
            
            

            

        }
    }
}
