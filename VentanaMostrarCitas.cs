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
    public partial class VentanaMostrarCitas : Form
    {
        public VentanaMostrarCitas()
        {
            InitializeComponent();
            ActualizarListViewCitas();
            Catalogo.VentanaMostrarCitas = this;
        }


        private void VentanaMostrarCitas_Load(object sender, EventArgs e)
        {
            ActualizarListViewCitas();
        }

        private void BtnRegresarCitas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Método que actualiza la lista de citas mostrada en la ListView de la ventana
        public void ActualizarListViewCitas()
        {
            // Limpiar la ListView antes de agregar los elementos
            ListViewCitas.Items.Clear();

            // Si las columnas aún no han sido agregadas, agregarlas
            if (ListViewCitas.Columns.Count == 0)
            {
                ListViewCitas.Columns.Add("Nombre", 100);
                ListViewCitas.Columns.Add("Teléfono", 100);
                ListViewCitas.Columns.Add("Correo electrónico", 150);
                ListViewCitas.Columns.Add("Asunto", 100);
                ListViewCitas.Columns.Add("Fecha y Hora de inicio", 150);               
                ListViewCitas.Columns.Add("Hora de finalización", 150);
            }

            // Iterar sobre la lista de citas de la Agenda
            foreach (Tasks cita in Catalogo.Tareas)
            {
                // Crear un nuevo item para la ListView de citas con los datos de la cita en el ciclo de iteración
                ListViewItem item = new ListViewItem(cita.Contacto.Nombre);
                item.SubItems.Add(cita.Contacto.Telefono);
                item.SubItems.Add(cita.Contacto.Correo);
                item.SubItems.Add(cita.Asunto);
                item.SubItems.Add(cita.Fecha.ToString());                
                item.SubItems.Add(cita.HoraFin.ToString());
                
                // Agregar el item a la ListView de citas
                ListViewCitas.Items.Add(item);
            }
        }

        private void ListViewCitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListViewCitas();
        }
    }
}
