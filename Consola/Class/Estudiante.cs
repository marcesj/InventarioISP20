//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Consola.Class
//{
//    public class Estudiante 
//    {
//        private string nombre=string.Empty;

//        public string Nombre
//        {
//            get { return nombre.ToUpper(); }
//            set { nombre = value; }
//        }
//        public string Domicilio { get; set; } = string.Empty;

//        public int Edad { get; set; }

//        //creamos una propiedad llamada datos completos que concatena todos los datos de estudiante y los devuelve al llamarla
//        public string DatosCompletos
//        {
//            get { return $"Nombre: {this.Nombre}, Domicilio: {this.Domicilio}, Edad: {this.Edad}"; }
//         // se puede prescindir del this o no, no afecta
//        }

//        public void Saludar()
//        {
//            Console.WriteLine($"Hola, soy el estudiante {this.Nombre} y tengo {this.Edad} años");
//        }
//    }
//}
namespace Consola.Class
{
    public class Estudiante : Persona
    {
        //public string Propiedad1 { get; set; } // Creada automáticamente una propiedad con un campo de respaldo privado

        //private string? nombre; // Campo privado que respalda la propiedad Nombre

        public string? Nombre // Propiedad con un campo de respaldo privado
        {
            get { return nombre?.ToUpper(); }
            set { nombre = value; }
        }

        public string Domicilio { get; set; } = string.Empty; // Propiedad con un valor predeterminado de cadena vacía
        public int Edad { get; set; }

        // Creamos una propiedad llamada DatosCompletos que concatena todos los datos del estudiante y los devuelve al llamarla
        public string DatosCompletos
        {
            get { return $"Hola, soy el estudiante {Nombre} y tengo {Edad} años."; }
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy el estudiante {Nombre} y tengo {Edad} años.");
        }

        public override void Hablar()
        {
            Console.WriteLine($"Hola, soy estudiante!!");
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}