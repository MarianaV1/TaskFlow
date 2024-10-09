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
    public partial class VentanaMostrarContactos : Form
    {


        // Constructor de la ventana
        public VentanaMostrarContactos()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListViewContactos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VentanaMostrarContactos_Load(object sender, EventArgs e)
        {
            // Limpiar la ListView antes de agregar los elementos
            ListViewContactos.Items.Clear();

            // Agregar las columnas necesarias solo si no existen ya
            if (ListViewContactos.Columns.Count == 0)
            {
                ListViewContactos.Columns.Add("Nombre", 150);
                ListViewContactos.Columns.Add("Teléfono", 150);
                ListViewContactos.Columns.Add("Correo electrónico", 150);
                ListViewContactos.Columns.Add("Rol", 150);
            }

            // Iterar sobre la lista de contactos de la Agenda, y agregar cada contacto a la ListView
            foreach (Miembro contacto in Catalogo.Empleados)
            {
                ListViewItem item = new ListViewItem(contacto.Nombre);
                item.SubItems.Add(contacto.Telefono);
                item.SubItems.Add(contacto.Correo);
                item.SubItems.Add(contacto.Rol.ToString());
                ListViewContactos.Items.Add(item);
            }
        }
    }
}
