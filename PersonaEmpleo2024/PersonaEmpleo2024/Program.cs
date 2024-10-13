using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaEmpleo2024
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void Imprimir()
        {
            Console.WriteLine(Nombre + " tiene " + Edad + " años ");
        }
    }
    class Empleado : Persona
    {
        public int Sueldo { get; set; }
        public void ImprimirSueldo()
        {
            Console.WriteLine("El sueldo de " + Nombre + " es de " + Sueldo);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Persona persona = new Persona();
            persona.Nombre = "Elson Ramirez";
            persona.Edad = 25;
            persona.Imprimir();
            */

            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Elson Ramirez";
            empleado1.Edad = 25;
            empleado1.Sueldo = 3000000;
            empleado1.Imprimir();
            empleado1.ImprimirSueldo();

            //Creamos tro empleado
            Empleado empleado2 = new Empleado();
            empleado2.Nombre = "Juan Leiva";
            empleado2.Edad = 22;
            empleado2.Sueldo = 2500000;
            empleado2.Imprimir();
            empleado2.ImprimirSueldo();

            Console.WriteLine("Precione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
