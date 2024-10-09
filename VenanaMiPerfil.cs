using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Agenda_RamirezBenjamin_MauricioChad
{
    public partial class VenanaMiPerfil : Form
    {
        private Trabajador miPerfil;  // Variable para almacenar el perfil actual

        public VenanaMiPerfil()
        {
            InitializeComponent();
        }

        private void VenanaMiPerfil_Load(object sender, EventArgs e)
        {
            // Verificar si ya existe el trabajador "Mariana Vega"
            miPerfil = Catalogo.Empleados.Find(t => t.Nombre == "Mariana Vega");

            // Si no existe, crear un nuevo objeto Trabajador y agregarlo a la lista
            if (miPerfil == null)
            {
                miPerfil = Miembro.CrearTrabajador("Mariana Vega", "9933941230", "Mariana_Vega@anahuac.mx", Rol.Administrador);
                Catalogo.Empleados.Add(miPerfil);
            }

            // Actualizar los campos del formulario con la información del trabajador
            txtNombre1.Text = miPerfil.Nombre;
            txtTelefono2.Text = miPerfil.Telefono;
            txtCorreo3.Text = miPerfil.Correo;
        }

        private void txtNombre1_TextChanged(object sender, EventArgs e)
        {
            // Puedes actualizar el nombre del trabajador en el objeto miPerfil si es necesario
            miPerfil.Nombre = txtNombre1.Text;
        }

        private void txtTelefono2_TextChanged(object sender, EventArgs e)
        {
            // Puedes actualizar el teléfono del trabajador en el objeto miPerfil si es necesario
            miPerfil.Telefono = txtTelefono2.Text;
        }

        private void txtCorreo3_TextChanged(object sender, EventArgs e)
        {
            // Puedes actualizar el correo del trabajador en el objeto miPerfil si es necesario
            miPerfil.Correo = txtCorreo3.Text;
        }

        private void btnActualizarInfo_Click(object sender, EventArgs e)
        {
            // Actualizar la información del trabajador en la lista de empleados
            Catalogo.Empleados[Catalogo.Empleados.FindIndex(t => t.Nombre == miPerfil.Nombre)] = miPerfil;
            MessageBox.Show("Información actualizada correctamente", "Información actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}


