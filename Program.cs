using Models;

ProgramaEducativo programa = new ProgramaEducativo();

// Crear asignaturas
Asignatura servidor = new Asignatura("Servidor", 6);

// Añadir asignaturas al programa
programa.AñadirAsigantura(servidor);


// Crear estudiantes
Estudiante estudiante1 = new ("Guillermo");
Estudiante estudiante2 = new ("Guillermoss");
Estudiante estudiante3 = new ("Guille");

// Añadir estudiantes al programa educativo
programa.AñadirEstudiante(estudiante1);
programa.AñadirEstudiante(estudiante2);
programa.AñadirEstudiante(estudiante3);

// Asignar calificaciones
estudiante1.AñadirCalificacion(servidor, 9.5);
estudiante3.AñadirCalificacion(servidor, 6);

// Mostrar estudiantes
programa.MostrarEstudiantes();

//Modificar calificacion
estudiante1.ModificarCalificacion(servidor, 9.8);

//Eliminar estudadiante
programa.EliminarEstudiante("Guillermoss");

//Buscar estudiantes por parte del nombre
List<Estudiante> busqueda = programa.BuscarEstudiantesPorNombre("Guille");
  Console.WriteLine("\n--- Estudiantes filtrado por nombre ---");
        foreach (var res in busqueda)
        {
            Console.WriteLine($"Estudiante: {res.Nombre}");
        }

// Mostrar calificaciones de un estudiante específico
Estudiante estudianteSeleccionado = programa.ObtenerEstudiante("Guillermo");
if (estudianteSeleccionado != null)
{
    estudianteSeleccionado.MostrarCalificaciones();
    double promedio = estudianteSeleccionado.CalcularPromedio();
    Console.WriteLine($"Promedio de {estudianteSeleccionado.Nombre}: {promedio:F2}");
}


// Calcular promedio de estudiantes
Console.WriteLine("Promedio de los estudiantes: " + programa.CalcularPromedioGlobal());


// Informe estudiante
programa.GenerarReporteEstudiante(estudiante1);