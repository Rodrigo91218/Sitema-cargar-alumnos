using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Alumnos_y_materias
{
    internal class Alumno
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int documento;
        private int legajo;
        #endregion

        #region Propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
        public int Documento { get { return documento; } set { documento = value; } }
        public int Legajo { get { return legajo; } set { legajo = value; } }
        #endregion

        #region Constructor
        public Alumnos(string nombre, string apellido, DateTime fechaNacimiento, int documento, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.documento = documento;
            this.legajo = legajo;
        }

        public Alumnos()
        {
            this.nombre = "";
            this.apellido = "";
            this.fechaNacimiento = DateTime.Today;
            this.documento = 0;
            this.legajo = 0;
        }
        #endregion
    }
}
