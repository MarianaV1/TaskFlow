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
    public partial class VentanaNuevaCita : Form
    {
        // Declarar variables para almacenar la lista de contactos y citas, y las fechas de la cita
        private List<Miembro> contactos;
        private List<Tasks> citas;
        private DateTime fechaHora;
        private DateTime fechafin;

        public VentanaNuevaCita()
        {
            InitializeComponent();
            // Configurar el formato del control DateTimePicker para mostrar fecha y hora personalizadas
            dateTimePickerFechaHora.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaHora.CustomFormat = "dd/MM/yyyy hh:mm tt";
            // Inicializar la variable fechaHora con el valor predeterminado del DateTimePicker
            fechaHora = dateTimePickerFechaHora.Value;
            dateTimePickerFechaFin.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaFin.CustomFormat = "dd/MM/yyyy hh:mm tt";
            fechafin = dateTimePickerFechaFin.Value;

        }

        private void VentanaNuevaCita_Load(object sender, EventArgs e)
        {

            //Combobox se limpia cada vez que se abra la ventana
            comboBoxContactos.Items.Clear();

            foreach (Trabajador trabajador in Catalogo.Empleados)
            {
                comboBoxContactos.Items.Add(trabajador.Nombre);
            }

            // Establecer la fecha y hora actual como valor predeterminado en el control DateTimePicker
            dateTimePickerFechaHora.Value = DateTime.Now;

            dateTimePickerFechaFin.Value = DateTime.Now;

        }

        private void AceptarNuevaCita_Click(object sender, EventArgs e)
        {
            // Obtener el asunto de la cita desde el cuadro de texto correspondiente
            string asunto = txtNuevoAsunto.Text;
            
            // Validar que el cuadro de texto del asunto no esté vacío
            if (string.IsNullOrEmpty(asunto))
            {
                // Mostrar un mensaje de error si el cuadro de texto del asunto está vacío
                MessageBox.Show("Debe ingresar un asunto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                // Limpiar el cuadro de texto del asunto si contiene texto
                txtNuevoAsunto.Clear();
            }
            
            // Verificar si se ha seleccionado un contacto antes de crear una cita
            if (comboBoxContactos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un contacto antes de crear una cita.");
                return;
            }
            // Obtener el nombre del contacto seleccionado del ComboBox
            string nombreContacto = comboBoxContactos.SelectedItem.ToString();

            // Buscar el objeto Persona correspondiente en la lista Agenda.Contactos
            Trabajador trabajador = Catalogo.Empleados.Find(p => p.Nombre == nombreContacto);

            // Crear un nuevo objeto Cita con la Persona seleccionada y la fecha seleccionada
            Tasks cita = new Tasks(trabajador, asunto, fechaHora, fechafin);

            // Agregar la nueva cita a la lista de citas
            Catalogo.Tareas.Add(cita);

            // Actualizar la ListView de la ventana VentanaMostrarCitas
            Catalogo.VentanaMostrarCitas.ActualizarListViewCitas();

            // Deseleccionar cualquier elemento previamente seleccionado en el ComboBox
            comboBoxContactos.SelectedIndex = -1;

            this.Close();

        }

        private void comboBoxContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Este método se ejecuta cuando se selecciona un elemento en el ComboBox de contactos.
            // Actualmente no hace nada, ya que no se requiere ninguna acción al cambiar la selección del ComboBox.
        }

        private void dateTimePickerFechaHora_ValueChanged(object sender, EventArgs e)
        {
            // Este método se ejecuta cuando se cambia la fecha y hora seleccionada en el control DateTimePicker.
            // Actualizar la variable fechaHora con la nueva fecha y hora seleccionada
            fechaHora = dateTimePickerFechaHora.Value;
        }

        private void BtnRegresarNuevaCita_Click(object sender, EventArgs e)
        {
            // Este método se ejecuta cuando se hace clic en el botón "Regresar" de la ventana VentanaNuevaCita.
            // Cierra la ventana actual.
            this.Close();
        }

        private void dateTimePickerFechaFin_ValueChanged(object sender, EventArgs e)
        {
            // Este método se ejecuta cuando se cambia la fecha y hora seleccionada en el control DateTimePicker.
            // Actualiza la variable fechafin con el nuevo valor seleccionado.
            fechafin = dateTimePickerFechaFin.Value;
        }
    }
}
