using System;
using System.Collections.Generic;
using System.Linq; // Agregamos la referencia a LINQ

namespace Puntajes2
{
    class AlumnosPuntaje
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Puntaje { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicialización correcta de la lista de alumnos
            List<AlumnosPuntaje> alumnos = new List<AlumnosPuntaje>
            {
                new AlumnosPuntaje { Apellido = "Ramirez", Nombre = "Elson", Puntaje = 90 },
                new AlumnosPuntaje { Apellido = "Rios", Nombre = "Silvana", Puntaje = 95 },
                new AlumnosPuntaje { Apellido = "Leiva", Nombre = "Juan", Puntaje = 85 },
                new AlumnosPuntaje { Apellido = "Melgarejo", Nombre = "Ivan", Puntaje = 60 }
            };

            // Consulta utilizando LINQ con corrección
            var alumnosConsulta = from alumno in alumnos
                                  where alumno.Puntaje >= 60
                                  orderby alumno.Apellido, alumno.Nombre
                                  // orderby alumno.Puntaje descending... PARA ORDENAR DE FORMA DESENDENTE (LOS PUNTAJES)
                                  select alumno;

            // Imprimir tabla de puntajes
            Console.Clear();
            Console.WriteLine("+-------------------------+-------------------------+--------+");
            Console.WriteLine("| Apellido                | Nombre                  | Puntaje|");
            Console.WriteLine("+-------------------------+-------------------------+--------+");

            foreach (AlumnosPuntaje ap in alumnosConsulta)
            {
                Console.WriteLine($"| {ap.Apellido,-23} | {ap.Nombre,-23} | {ap.Puntaje,6} |");
            }

            Console.WriteLine("+-------------------------+-------------------------+--------+");

            Console.ReadKey();
        }
    }
}