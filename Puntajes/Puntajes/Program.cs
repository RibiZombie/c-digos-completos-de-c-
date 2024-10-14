using System;
using System.Collections.Generic;

namespace Puntajes
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
            List<AlumnosPuntaje> alumnos = new List<AlumnosPuntaje>();

            // Primer alumno
            AlumnosPuntaje alumno1 = new AlumnosPuntaje();
            alumno1.Apellido = "Ramirez";
            alumno1.Nombre = "Elson";
            alumno1.Puntaje = 90;
            alumnos.Add(alumno1);

            // Segundo alumno
            AlumnosPuntaje alumno2 = new AlumnosPuntaje();
            alumno2.Apellido = "Rios";
            alumno2.Nombre = "Silvana";
            alumno2.Puntaje = 95;
            alumnos.Add(alumno2);

            // Imprimir tabla de puntajes
            Console.Clear();
            Console.WriteLine("+-------------------------+-------------------------+--------+");
            Console.WriteLine("| Apellido                | Nombre                  | Puntaje|");
            Console.WriteLine("+-------------------------+-------------------------+--------+");

            foreach (AlumnosPuntaje ap in alumnos)
            {
                Console.WriteLine($"| {ap.Apellido,-23} | {ap.Nombre,-23} | {ap.Puntaje,6} |");
            }

            Console.WriteLine("+-------------------------+-------------------------+--------+");

            Console.ReadKey();
        }
    }
}
