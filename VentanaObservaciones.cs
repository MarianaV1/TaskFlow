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
    public partial class VentanaObservaciones : Form
    {
        private List<Tasks> citas; // Lista de citas disponibles
        private List<string> nombresContactos; // Lista de nombres de contactos disponibles
        private static List<Observacion> listaObservaciones = new List<Observacion>();
        public VentanaObservaciones()
        {
            InitializeComponent();
            citas = Catalogo.Tareas; // Obtener la lista de citas de la agenda
        }

        private void VentanaObservaciones_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con las citas disponibles
            cmbListaTareas.Items.Clear();
            foreach (Tasks cita in citas)
            {
                cmbListaTareas.Items.Add(cita); // Agregar la cita completa en lugar del nombre del contacto
            }
            // Especificar que se muestre el asunto de la cita en el ComboBox
            cmbListaTareas.DisplayMember = "Asunto";
            cmbListaTareas.SelectedIndex = -1;

            listViewObservaciones.View = View.Details;
            listViewObservaciones.GridLines = true;

            // Agregar columnas a la ListView
            listViewObservaciones.Columns.Add("Asunto", 200);
            listViewObservaciones.Columns.Add("Observación", 300);
            MostrarObservacionesEnListView();
        }

        private void BtnSubirObservacion_Click(object sender, EventArgs e)
        {
            //Al hacer click en el boton de subir observacion, se verifica que se haya seleccionado una cita
            if (cmbListaTareas.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una cita para poder subir una observacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Obtener la cita seleccionada y la observacion escrita en el textbox de observaciones
            Tasks citaSeleccionada = (Tasks)cmbListaTareas.SelectedItem;
            string observacion = rchTxtObservaciones.Text;
            Observacion nuevaObservacion = new Observacion(citaSeleccionada.Asunto, observacion);
            // Agregar la observación a la lista
            listaObservaciones.Add(nuevaObservacion);

            // Mostrar las observaciones en la ListView
            MostrarObservacionesEnListView();

            // Limpiar los campos después de subir la observación
            cmbListaTareas.SelectedIndex = -1;
            rchTxtObservaciones.Text = "";
        }
        private void MostrarObservacionesEnListView()
        {
            // Limpiar la ListView antes de agregar nuevas observaciones
            listViewObservaciones.Items.Clear();

            // Agregar las observaciones a la ListView
            foreach (Observacion observacion in listaObservaciones)
            {
                ListViewItem item = new ListViewItem(observacion.Asunto);
                item.SubItems.Add(observacion.ObservacionTexto);
                listViewObservaciones.Items.Add(item);
            }
        }
    }
}
