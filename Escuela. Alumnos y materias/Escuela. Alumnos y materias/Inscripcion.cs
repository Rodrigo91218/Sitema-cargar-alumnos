using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Alumnos_y_materias
{
    internal class Inscripcion
    {
        #region Atributos
        private int añoLectivo;
        private List<Materia> materia;
        private Alumno alumnos;
        private bool aprobado;
        #endregion

        #region Propiedades
        public int AñoLectivo { get { return añoLectivo; } set { añoLectivo = value; } }
        public List<Materia> Materias { get { return materia; } set { materia = value; } }
        public Alumno Alumnos { get { return alumnos; } set { alumnos = value; } }
        public bool Aprobado { get { return aprobado; } set { aprobado = value; } }
        #endregion

        #region Constructor
        public Inscripcion(int añoLectivo, List<Materia> materia, Alumno alumnos, bool aprobado)
        {
            this.añoLectivo = añoLectivo;
            this.materia = materia;
            this.alumnos = alumnos;
            this.aprobado = aprobado;
        }

        public Inscripcion()
        {
            this.añoLectivo = 2024;
            this.materia = null;
            this.alumnos = null;
            this.aprobado = false;
        }
        #endregion
    }
}
