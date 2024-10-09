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
    public partial class VentanaBorrarCita : Form
    {
        private List<Tasks> citas; // Lista de citas disponibles
        private List<string> nombresContactos; // Lista de nombres de contactos disponibles

        // Constructor de la ventana de borrado de citas
        public VentanaBorrarCita()
        {
            InitializeComponent();
            citas = Catalogo.Tareas; // Obtener la lista de citas de la agenda

        }

        private void BtnBorrarCita_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado una cita
            if (comboBoxCitas.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una cita para poder borrarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Obtener la cita seleccionada
            Tasks citaSeleccionada = (Tasks)comboBoxCitas.SelectedItem;

            // Remover la cita de la lista de citas de la Agenda
            citas.Remove(citaSeleccionada);

            // Llamar al método ActualizarListViewCitas() de VentanaMostrarCitas para actualizar la lista de citas
            Catalogo.VentanaMostrarCitas.ActualizarListViewCitas();

            // Desseleccionar la cita en el ComboBox
            comboBoxCitas.SelectedIndex = -1;

            // Cerrar la ventana
            this.Close();
        }
        private void comboBoxCitas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void VentanaBorrarCita_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con las citas disponibles
            comboBoxCitas.Items.Clear();
            foreach (Tasks cita in citas)
            {
                comboBoxCitas.Items.Add(cita); // Agregar la cita completa en lugar del nombre del contacto
            }
            // Especificar que se muestre el asunto de la cita en el ComboBox
            comboBoxCitas.DisplayMember = "Asunto";
            comboBoxCitas.SelectedIndex = -1;
        }

        // Evento que se dispara al hacer clic en el botón "Regresar", cierra la ventana
        private void BtnRegresarBorrarCita_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento que se dispara al cerrar la ventana
        private void VentanaBorrarCita_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Llamar al método ActualizarListViewCitas() de VentanaMostrarCitas para actualizar la lista de citas
            Catalogo.VentanaMostrarCitas.ActualizarListViewCitas();
        }
    }
}
