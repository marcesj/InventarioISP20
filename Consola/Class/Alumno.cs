using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Class
{
    public partial class Alumno 
    {
        static int instancia_de_alumnos = 0; // variable de clase para contar el número de instancias de alumnos
        string nombre;
        string apellido;
        int dni;
        DateOnly fecha_nacimiento;

        //constructor de la Class Alumno

        public Alumno()
        { 
        
        }
        public Alumno(string nombre, string apellido, int 
            dni=0, DateOnly fecha_nacimiento=new DateOnly())
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fecha_nacimiento = fecha_nacimiento;
            instancia_de_alumnos++; // Incrementamos el contador de instancias cada vez que se crea un nuevo alumno
        }
        
         public string ImpresionFichadeDatos()
        {
            return $"Nombre: {nombre}\nApellido: {apellido}\nDNI: {dni}\nFecha de Nacimiento: {fecha_nacimiento}";
        }
        public override string ToString()
        {
            return apellido + "Albertissi Marcelo";
        }
       
    }
}