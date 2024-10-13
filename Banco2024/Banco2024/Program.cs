using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco2024
{
    class Cliente
    {
        private string nombre;
        private int monto;

        public void Depositar(int impDeposito)
        {
            monto += impDeposito;
        }
        public void Extraer(int impExtraccion)
        {
            monto -= impExtraccion;
        }
        public int RetornarMonto()
        {
            return monto;
        }
    }

    class Banco
    {
        Cliente cliente1 = new Cliente();
        Cliente cliente2 = new Cliente();
        Cliente cliente3 = new Cliente();

        public void Operar()
        {
            cliente1.Depositar(1000);
            cliente2.Depositar(500);
            cliente3.Depositar(5000);
            cliente1.Extraer(500);
            cliente3.Extraer(3000);
        }

        public int DepositoTotales()
        {
            Console.WriteLine("El cliente 1 cuenta con: " + cliente1.RetornarMonto());
            Console.WriteLine("El cliente 2 cuenta con: " + cliente2.RetornarMonto());
            Console.WriteLine("El cliente 3 cuenta con: " + cliente3.RetornarMonto());
            return cliente1.RetornarMonto() + cliente2.RetornarMonto() + cliente3.RetornarMonto();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.Operar();
            Console.WriteLine("La suma total de los depósitos asciende a la suma de: " + banco.DepositoTotales()); // Cerrando el paréntesis
            Console.WriteLine();
        }
    }
}

