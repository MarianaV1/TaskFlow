using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Agenda_RamirezBenjamin_MauricioChad
{
    internal static class Program
    {
        [STAThread] // Atributo que indica que el modelo de subproceso COM se usará en el subproceso que llama a este método.
        static void Main()
        {
            // Habilita los estilos visuales para la aplicación.
            Application.EnableVisualStyles();

            // Establece la compatibilidad con el renderizado de texto para la aplicación.
            Application.SetCompatibleTextRenderingDefault(false);

            // Ejecuta la aplicación iniciando el formulario principal (Form1).
            Application.Run(new VentanaLogIn());

        }
    }
}