using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> billetes = new List<int>();
            billetes.Add(100000);
            billetes.Add(50000);
            billetes.Add(20000);
            billetes.Add(10000);
            billetes.Add(5000);
            billetes.Add(2000);
            billetes.Add(1000);
            billetes.Add(500);
            billetes.Add(100);
            billetes.Add(50);
            billetes.Add(10);
            billetes.Add(5);
            billetes.Add(1);

            int monto;
            int cantidad;
            Console.Write("Ingrese un monto: ");
            monto = int.Parse(Console.ReadLine());
            Console.WriteLine("Para " + monto + "Gs. se nesecita: ");

            foreach (int billete in billetes)
            {
                cantidad = monto / billete;
                if (cantidad > 0)
                {
                    Console.WriteLine(cantidad + (billete < 2000 ? " moneda(s) " : " billete(s) de ") + billete + " Gs. ");
                }
                monto = monto - (billete * cantidad);
            }

                Console.ReadKey();
        }
    }
}
