using Models;

ProgramaEducativo programa = new ProgramaEducativo();

// Crear asignaturas
Asignatura servidor = new Asignatura("Servidor", 6);

// Crear estudiantes
Estudiante estudiante1 = new ("Guillermo");
Estudiante estudiante2 = new ("Guillermoss");

// Añadir estudiantes al programa educativo
programa.AñadirEstudiante(estudiante1);
programa.AñadirEstudiante(estudiante2);

// Asignar calificaciones
estudiante1.AñadirCalificacion(servidor, 9.5);

// Mostrar estudiantes
programa.MostrarEstudiantes();

//Modificar calificacion
estudiante1.ModificarCalificacion(servidor, 9.8);

//Eliminar estudadiante
programa.EliminarEstudiante("Guillermoss");

// Mostrar calificaciones de un estudiante específico
Estudiante estudianteSeleccionado = programa.ObtenerEstudiante("Guillermo");
if (estudianteSeleccionado != null)
{
    estudianteSeleccionado.MostrarCalificaciones();
    double promedio = estudianteSeleccionado.CalcularPromedio();
    Console.WriteLine($"Promedio de {estudianteSeleccionado.Nombre}: {promedio:F2}");
}

