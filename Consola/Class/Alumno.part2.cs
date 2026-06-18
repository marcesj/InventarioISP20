using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Class
{
    partial class Alumno
    {
        public static string ImprimirCantidadDeAlumnos()
        {
            return $"Cantidad de instancias de la clase Alumos: {instancia_de_alumnos}";
        }
    }
}
