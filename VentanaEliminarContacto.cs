using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Agenda_RamirezBenjamin_MauricioChad;

namespace Proyecto_Agenda_RamirezBenjamin_MauricioChad
{
    public partial class VentanaEliminarContacto : Form
    {
        public VentanaEliminarContacto()
        {
            InitializeComponent();
        }

        private void txtNombreContacto_TextChanged(object sender, EventArgs e)
        {

        }
        public string GetNombre()
        {
            return txtNombreContacto.Text;
        }

        private void AceptarEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del contacto a eliminar
            string nombreContacto = txtNombreContacto.Text;

            if (!string.IsNullOrWhiteSpace(nombreContacto))
            {
                // Buscar el contacto en la lista de contactos
                Miembro contactoAEliminar = Catalogo.Empleados.FirstOrDefault(c => c.Nombre == nombreContacto) as Miembro;

                if (contactoAEliminar != null)
                {
                    // Si se encontró el contacto, se elimina de la lista
                    Catalogo.Empleados.Remove(contactoAEliminar);
                    txtNombreContacto.Clear();
                    // Cerrar la ventana
                    this.Close();
                }
                else
                {
                    // Si no se encontró el contacto, mostrar un mensaje de error
                    MessageBox.Show("No se encontró el trabajador a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si el campo de nombre está vacío, mostrar un mensaje de error
                MessageBox.Show("El campo de nombre está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegresarElimContacto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
