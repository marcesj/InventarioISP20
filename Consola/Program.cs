


using Consola.Class;

public class Program
{
    private static void Main(string[] args)
    {
        // CreamosVariables();
        // CreamosMatricesYVectores();

        // Console.WriteLine("probando imprimir algo en la pantalla");

        // ImpresionDeParametros(args);

        // CapturaValoresUsuario();
        // CreamosAlumnosEImprimimosSuFichaDeDatos();
        // CreamosEstudiantesEImprimimosSuSaludo();
        // ProbamosMetodosConDiferentesValoresDeRetorno();

        Ejercicio1();
        Bicicleta bici = new();
        bici.velocidad = 20;
        bici.tieneCampanilla = true;
        Console.WriteLine($"La bicicleta tiene una velocidad de {bici.velocidad} km/h y {(bici.tieneCampanilla ? "tiene" : "no tiene")} campanilla.");
        Ejercicio3();

    }

    private static void Ejercicio3()
    {
        Persona[] grupo = new Persona[2];
        Persona persona1 = new();
        Estudiante estudiante1 = new();
        grupo[0] = persona1;
        grupo[1] = estudiante1;
        estudiante1.Nombre = "Marcelo Javier";
        foreach (Persona persona in grupo)
        {
            persona.Hablar();
        }
        object prueba=new object();
        Console.WriteLine(Environment.NewLine+"probando");
        DateTime ahora=new DateTime();
        ahora=DateTime.Now;
        Console.WriteLine(ahora);
        Console.WriteLine(estudiante1.ToString());
    }

    private static void Ejercicio1()
    {
        Persona persona1 = new();
        persona1.nombre = "Marcelo Javier";
        Console.WriteLine($"La edad de {persona1.nombre}"/* es: {persona1.edad}"*/);
        persona1.CumplirAnios();
    }

    private static void ProbamosMetodosConDiferentesValoresDeRetorno()
    {
        AlumnoCurso alumno1 = new AlumnoCurso("Lucía", "Gómez", 19);

        alumno1.AgregarNota(8);
        alumno1.AgregarNota(7.5);
        alumno1.AgregarNota(9);
        alumno1.AgregarNota(3);
        alumno1.AgregarNota(2);

        string nombreCompleto = alumno1.ObtenerNombreCompleto();
        int cantidadNotas = alumno1.ObtenerCantidadDeNotas();
        double promedio = alumno1.CalcularPromedio();
        bool aprobado = alumno1.EstaAprobado();
        char inicial = alumno1.ObtenerInicial();
        int materiasDesaprobadas = alumno1.ContarMateriasDesaprobadas();
        int materiasAprobadas = alumno1.ContarMateriasAprobadas();
        DateTime fechaConsulta = alumno1.ObtenerFechaConsulta();
        List<double> notas = alumno1.ObtenerNotas();

        Console.WriteLine("Nombre completo: " + nombreCompleto);
        Console.WriteLine("Cantidad de notas: " + cantidadNotas);
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("¿Está aprobado?: " + aprobado);
        Console.WriteLine("Inicial: " + inicial);
        Console.WriteLine("Fecha de consulta: " + fechaConsulta);
        Console.WriteLine("Materias desaprobadas:"+ materiasDesaprobadas);
        Console.WriteLine("Materias aprobadas:" + materiasAprobadas);
    }

    private static void CreamosEstudiantesEImprimimosSuSaludo()
    {
        Estudiante estudiante1 = new Estudiante();
        estudiante1.Nombre = "Marcelo Albertissi";
        estudiante1.Edad = 49;
        //estudiante1.Saludar();
        Console.WriteLine(estudiante1.DatosCompletos);
    }

    private static void CreamosAlumnosEImprimimosSuFichaDeDatos()
    {
        Alumno alumno=new Alumno("Marcelo", "Albertissi", 12345678, new DateOnly(2000, 1, 1));
        Console.WriteLine(alumno.ImpresionFichadeDatos());

        Alumno alumno2 = new Alumno("Juan", "Agúero", 12345677, new DateOnly(2001, 1, 1));
        Console.WriteLine(alumno2.ImpresionFichadeDatos());

        Alumno alumno3 = new Alumno("Majo", "Longoni", 12345676, new DateOnly(2002, 1, 1));
        Console.WriteLine(alumno3.ImpresionFichadeDatos());

        Console.WriteLine(Alumno.ImprimirCantidadDeAlumnos()); 


    }

    private static void CreamosMatricesYVectores()
    {
        //creamos un vector de tipo string de 12 elementos
        string[] meses = new string[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        meses[0] = "Enero";
        meses[11] = "Diciembre";
        //creamos una matriza de string de 3 filas y 2 columnas
        string[,] nosotros = new string[3, 2] { { "Alejandro", "Ramirez" }, { "Marcelo", "Albertissi" }, { "Juan", "Marcelo" } };
        nosotros[0, 0] = "Tobias";
        nosotros[2, 1] = "Pedro";
        int[] edades = new int[3] { 20, 21, 22 };
    }

    private static void CapturaValoresUsuario()
    {
        Console.Write("Ingrese el año de su nacimiento: ");
        string anio_nacimiento = Console.ReadLine();
        int anio = Convert.ToInt32(anio_nacimiento);
        int edad = DateTime.Now.Year - anio; 
        Console.WriteLine($"Usted tiene {edad} años aproximadamente"); 



    }

    private static void ImpresionDeParametros(string[] args )
    {
        if (args.Length > 1)
            Console.WriteLine($"Hola {args[0]} {args[1]}");
    }

    private static void CreamosVariables()
    {
        // creamos una variable de entrada int y le asignamos un valor
        int numero = 10;
        // declaración de una variable de tipo string
        int numero2;
        // asignación un valor a la variable numero2
        numero2 = 20;
        int numero3 = 30;
    }
}