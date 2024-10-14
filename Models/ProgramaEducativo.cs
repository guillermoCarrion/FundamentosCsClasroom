
namespace Models;

class ProgramaEducativo
{
    private List<Estudiante> estudiantes;
    private List<Asignatura> asignaturas;



    public ProgramaEducativo()
    {
        estudiantes = new List<Estudiante>();
        asignaturas = new List<Asignatura>();
    }


    public void AñadirAsigantura (Asignatura asignatura){
        if (estudiantes.Exists(e => e.Nombre == asignatura.Nombre))
            {
                Console.WriteLine($"La asignatura {asignatura.Nombre} ya existe en el programa.");
            }
            else
            {
                // Añadir la asignatura a la lista global
                asignaturas.Add(asignatura);
                Console.WriteLine($"La asignatura {asignatura.Nombre} ha sido añadida.");
            }
    }


    public void AñadirEstudiante(Estudiante estudiante)
    {
        if (estudiantes.Exists(e => e.Nombre == estudiante.Nombre))
            {
                Console.WriteLine($"El estudiante {estudiante.Nombre} ya existe en el programa.");
            }
            else
            {
                // Añadir la asignatura a la lista global
                estudiantes.Add(estudiante);
                Console.WriteLine($"El estudiante {estudiante.Nombre} ha sido añadido.");
            }
    }




    public void MostrarEstudiantes()
    {
        Console.WriteLine("\n--- Lista de Estudiantes ---");
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"Estudiante: {estudiante.Nombre}");
        }
    }





    public Estudiante ObtenerEstudiante(string nombre)
    {
        foreach (var estudiante in estudiantes)
        {
            if (estudiante.Nombre == nombre)
            {
                return estudiante;
            }
        }
        return null;
    }




    public List<Estudiante> BuscarEstudiantesPorNombre(string parteDelNombre)
    {
        List<Estudiante> resultados = estudiantes.FindAll(e => e.Nombre.ToLower().Contains(parteDelNombre.ToLower()));
        return resultados;
    }




    public void EliminarEstudiante(string nombre)
    {
        Estudiante estudiante = ObtenerEstudiante(nombre);
        if (estudiante != null)
        {
            estudiantes.Remove(estudiante);
            Console.WriteLine($"El estudiante {nombre} ha sido eliminado.");
        }
        else
        {
            Console.WriteLine($"El estudiante {nombre} no fue encontrado.");
        }
    }

    public double CalcularPromedioGlobal()
    {
        double sumaPromedios = 0;
        int contadorEstudiantes = 0;

        foreach (var estudiante in estudiantes)
        {
            sumaPromedios += estudiante.CalcularPromedio();
            contadorEstudiantes++;
        }


        return contadorEstudiantes > 0 ? sumaPromedios / contadorEstudiantes : 0;
    }

    public void GenerarReporteEstudiante(Estudiante estudiante)
    {
        Console.WriteLine($"\n--- Reporte para {estudiante.Nombre} ---");
        estudiante.MostrarAsignaturas();
        estudiante.MostrarCalificaciones();
        double promedio = estudiante.CalcularPromedio();
        Console.WriteLine($"Promedio final: {promedio:F2}");
    }


    // ordenar estudiantes por nota
    public void MostrarRankingPorNotas (){
        estudiantes.Sort((e1, e2) =>e2.CalcularPromedio().CompareTo(e1.CalcularPromedio()));
        Console.WriteLine($"\n Ranking de alumnos");
        foreach(var estudadiante in estudiantes){
            Console.WriteLine(estudadiante.Nombre + ": " + estudadiante.CalcularPromedio() );
        }
    }

    //Listar alumnos en riesgo de suspenso
    public void ListaDeRiesgo (){
        Console.WriteLine($"\n Lista de riesgo de reprobar");
        foreach (var estudiante in estudiantes)
        {
            if(estudiante.CalcularPromedio()<5){
                Console.WriteLine(estudiante.Nombre + ": " + estudiante.CalcularPromedio());
            }
        }
    }

    // Mostrar asignaturas
    public void MostrarAsignaturas()
    {
        Console.WriteLine("\n--- Lista de Asignaturas ---");
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine($"Nombre de la asignatura: {asignatura.Nombre}   Creditos: {asignatura.Creditos}");
        }
    }
}