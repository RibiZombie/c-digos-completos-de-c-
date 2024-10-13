//Plantear un programa que permita jugar a los dados. las reglas del juego son; se tiran tres dades, si los tres salen con el mismop valor
//mostrar un mensaje que diga "Ganó", si no, mostrar "Perdió".
//Lo primero que hacemos es identificar las claces:
//Luego los atributos y los metodos de cada clase:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados2024
{
    class Dado
    {
        private int valor;
        private static Random random = new Random(); // Instancia única de Random

        // Método para tirar el dado
        public void Tirar()
        {
            valor = random.Next(1, 7); // Genera un número aleatorio entre 1 y 6
        }

        // Método para obtener el valor del dado
        public int ObtenerValor()
        {
            return valor;
        }
    }

    class JuegoDados
    {
        private Dado dado1 = new Dado();
        private Dado dado2 = new Dado();
        private Dado dado3 = new Dado();

        // Método para jugar tirando los tres dados
        public void Jugar()
        {
            Console.Clear();

            dado1.Tirar();
            dado2.Tirar();
            dado3.Tirar();

            MostrarResultado();
        }

        // Método para mostrar si ganó o perdió
        public void MostrarResultado()
        {
            int valor1 = dado1.ObtenerValor();
            int valor2 = dado2.ObtenerValor();
            int valor3 = dado3.ObtenerValor();

            Console.WriteLine($"Dado 1: {valor1}, Dado 2: {valor2}, Dado 3: {valor3}");

            if (valor1 == valor2 && valor2 == valor3)
            {
                Console.WriteLine("¡Ganó! Todos los dados son iguales.");
            }
            else
            {
                Console.WriteLine("Perdió. Los dados no son iguales.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            JuegoDados juego = new JuegoDados();
            bool seguirJugando = true;

            while (seguirJugando)
            {
                juego.Jugar();

                // Preguntar si el jugador quiere seguir jugando
                Console.WriteLine("\n¿Desea jugar otra vez? (S/N): ");
                string respuesta = Console.ReadLine().ToUpper();

                if (respuesta == "N")
                {
                    seguirJugando = false;
                    Console.WriteLine("¡Gracias por jugar!");
                }
            }

            // Para mantener la consola abierta
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}