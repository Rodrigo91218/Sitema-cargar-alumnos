using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Alumnos_y_materias
{
    internal class Validacion
    {
        public static int LeerInt(int min, int max)
        {
            bool pudo = false;
            int val = 0;
            while (!pudo)
            {
                pudo = int.TryParse(Console.ReadLine(), out val);
                if (!pudo || val < min || val > max)
                {
                    pudo = false; /*si bien es un INT, no está en el rango esperado*/
                    Console.WriteLine(string.Concat("Valor incorrecto, solo números enteros entre ", min, " y ", max, ".\nIntente nuevamente: "));
                }
            }
            return val;
        }

        public static bool AprobadoSiNo()
        {
            bool aprobado = false;
            while (!aprobado)
            {
                string tmp = Console.ReadLine();
                if (tmp.Trim().ToLower().Replace('í', 'i') == "si" || tmp.Trim().ToLower() == "s" || tmp.Trim().ToLower() == "yes" || tmp.Trim().ToLower() == "y")
                {
                    return true;
                }
                else
                {
                    if (tmp.Trim().ToLower() == "no" || tmp.Trim().ToLower() == "n")
                    {
                        return false;
                    }
                }

                if (!aprobado)
                    Console.WriteLine("Valor incorrecto, ingrese si o no");
            }
            return false;
        }
    }
}
