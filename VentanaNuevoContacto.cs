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
    public partial class VentanaNuevoContacto : Form
    {
        // Constructor de la ventana
        public VentanaNuevoContacto()
        {
            InitializeComponent();
            CargarOpcionesRol();
        }

        private void AceptarContacto_Click(object sender, EventArgs e)
        {
            // Obtener los valores de las cajas de texto
            string nombre = txtNuevoNombre.Text;
            string telefono = txtNuevoTelefono.Text;
            string correo = txtNuevoCorreo.Text;
            
            // Obtener el rol seleccionado del ComboBox
            Rol rolSeleccionado = (Rol)cmbRol.SelectedItem;

            // Verificar si se han ingresado valores en todas las cajas de texto
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(correo))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe ingresar un nombre, teléfono y correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (telefono.Length >= 15) // Verificar si el teléfono tiene más de 15 caracteres
            {
                // Mostrar un mensaje de error
                MessageBox.Show("El teléfono debe tener menos de 15 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!correo.Contains("@") || !correo.Contains(".")) // Verificar si el correo tiene un arroba y un punto
            {
                // Mostrar un mensaje de error
                MessageBox.Show("El correo electrónico debe tener un arroba y un punto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                // Crear un nuevo Miembro con el rol seleccionado
                Miembro trabajador = Miembro.CrearTrabajador(nombre, telefono, correo, rolSeleccionado);
                Catalogo.Empleados.Add(trabajador);


                txtNuevoNombre.Clear();
                txtNuevoTelefono.Clear();
                txtNuevoCorreo.Clear();
                cmbRol.SelectedIndex = -1;

                this.Close();
            }

        }

        private void CargarOpcionesRol()
        {
            cmbRol.Items.Add(Rol.Miembro);
            cmbRol.Items.Add(Rol.Administrador);
        }

        private void txtNuevoNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnSalirNuevoContacto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
