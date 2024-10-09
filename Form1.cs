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
    public partial class Form1 : Form
    {
        // Creamos instancias de todas las ventanas secundarias que queremos abrir
        VentanaNuevoContacto FormNuevoContacto;
        VentanaEliminarContacto FormEliminarContacto;
        VentanaMostrarContactos FormMostrarContacto;
        VentanaNuevaCita FormNuevaCita;
        VentanaMostrarCitas FormMostrarCitas;
        VentanaBorrarCita FormBorrarCita;

        //Extras
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;


        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        public Form1()
        {
            InitializeComponent();
            // Inicializamos todas las instancias de las ventanas secundarias
            FormNuevoContacto = new VentanaNuevoContacto();
            FormEliminarContacto = new VentanaEliminarContacto();
            FormMostrarContacto = new VentanaMostrarContactos();
            FormNuevaCita = new VentanaNuevaCita();
            FormMostrarCitas = new VentanaMostrarCitas();
            FormBorrarCita = new VentanaBorrarCita();

            // Registra los eventos extras
            this.MouseDown += Form_MouseDown;
            this.MouseUp += Form_MouseUp;
            this.MouseMove += Form_MouseMove;
        }

        //Metodos extras

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                this.Location = new Point(
                    lastForm.X + (currentCursor.X - lastCursor.X),
                    lastForm.Y + (currentCursor.Y - lastCursor.Y));
                lastCursor = currentCursor;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Este método se llama cuando se carga la ventana principal
        }

        private void Btn_NuevoContacto_Click(object sender, EventArgs e)
        {
            // Mostramos la ventana para agregar un nuevo contacto cuando se hace clic en el botón correspondiente
            // FormNuevoContacto.ShowDialog();
            loadform(new VentanaNuevoContacto());

        }
        private void Btn_BorrarContacto_Click(object sender, EventArgs e)
        {
            // Mostramos la ventana para eliminar un contacto cuando se hace clic en el botón correspondiente
            // FormEliminarContacto.ShowDialog();
            loadform(new VentanaEliminarContacto());
        }
        private void Btn_NuevaCita_Click(object sender, EventArgs e)
        {
            // Mostramos la ventana para agregar una nueva cita cuando se hace clic en el botón correspondiente
            // FormNuevaCita.ShowDialog();
            loadform(new VentanaNuevaCita());
        }
        private void Btn_BorrarCita_Click(object sender, EventArgs e)
        {
            // Mostramos la ventana para eliminar una cita cuando se hace clic en el botón correspondiente
            // FormBorrarCita.ShowDialog();
            loadform(new VentanaBorrarCita());
        }
        private void Btn_MostrarCitas_Click(object sender, EventArgs e)
        {
            // Mostramos la ventana para mostrar las citas almacenadas cuando se hace clic en el botón correspondiente
            // FormMostrarCitas.ShowDialog();
            loadform(new VentanaMostrarCitas());
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            // Cerramos la ventana principal cuando se hace clic en el botón correspondiente
            this.Close();
        }

        private void Btn_MostrarContactos_Click(object sender, EventArgs e)
        {
            // Mostramos la ventana para mostrar los contactos almacenados cuando se hace clic en el botón correspondiente
            // FormMostrarContacto.ShowDialog();
            loadform(new VentanaMostrarContactos());
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MiPerfilBtn_Click(object sender, EventArgs e)
        {
            loadform(new VenanaMiPerfil());
        }

        private void Btn_Tutorial_Click_Click(object sender, EventArgs e)
        {
            loadform(new VentanaTutorial2());
        }

        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            loadform(new VentanaObservaciones());
        }
    }
}
