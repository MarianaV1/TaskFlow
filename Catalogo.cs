using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Agenda_RamirezBenjamin_MauricioChad
{
    public enum Rol
    {
        Miembro,
        Administrador
    }

    // Clase Observacion
    public class Observacion
    {
        public string Asunto { get; set; }
        public string ObservacionTexto { get; set; }

        public Observacion(string asunto, string observacionTexto)
        {
            Asunto = asunto;
            ObservacionTexto = observacionTexto;
        }
    }

    // Definición de la clase Catalogo
    public static class Catalogo
    {
        // Lista estática de objetos Trabajador para almacenar empleados
        public static List<Trabajador> Empleados = new List<Trabajador>();
        // Lista estática de objetos Tasks para almacenar citas
        public static List<Tasks> Tareas = new List<Tasks>();
        // Propiedad estática de tipo VentanaMostrarCitas para mostrar las citas almacenadas
        public static VentanaMostrarCitas VentanaMostrarCitas { get; set; }

    }

    // Definición de la clase Trabajador
    public class Trabajador
    {
        // Propiedades autoimplementadas para almacenar el nombre, el número de teléfono, la dirección de correo electrónico y el rol de una persona
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Rol Rol { get; set; }

        // Constructor para inicializar las propiedades
        protected Trabajador(string nombre, string telefono, string correo, Rol rol)
        {
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Rol = rol;
        }
    }

    public class Miembro : Trabajador
    {
        // Constructor privado para evitar la creación de objetos Contacto desde fuera de la clase
        private Miembro(string nombre, string telefono, string correo, Rol rol)
            : base(nombre, telefono, correo, rol)
        { }

        // Método estático para crear un nuevo objeto Trabajador
        public static Miembro CrearTrabajador(string nombre, string telefono, string correo, Rol rol)
        {
            return new Miembro(nombre, telefono, correo, rol);
        }
    }

    public class Tasks
    {
        // Propiedades automáticas para almacenar el objeto Persona correspondiente al contacto, la fecha, la hora de finalización y el asunto de una cita
        public Trabajador Contacto { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraFin { get; set; }
        public string Asunto { get; set; }

        // Constructor para inicializar las propiedades automáticas
        public Tasks(Trabajador contacto, string asunto, DateTime fecha, DateTime horafin)
        {
            Contacto = contacto;
            Fecha = fecha;
            HoraFin = horafin;
            Asunto = asunto;
        }
    }


}
