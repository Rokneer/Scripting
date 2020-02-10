using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int carta1 = 0, carta2 = 0, total = 0;
            string continuar = "s";

            while (continuar == "s")
            {
                if (total < 21)
                {
                    carta1 = random.Next(1, 11);
                    Console.WriteLine("Carta 1:" + carta1);
                    carta2 = random.Next(1, 11);
                    Console.WriteLine("Carta 2:" + carta2);
                    total += carta1 + carta2;
                    Console.WriteLine("Total= " + total);
                    Console.WriteLine("Desea continuar? (s/n): ");
                    continuar = Console.ReadLine();
                }
                else if (total == 21)
                {
                    continuar = "n";
                    Console.WriteLine("Ganador!");
                }
                else
                {
                    continuar = "n";
                    Console.WriteLine("Eliminado");
                }
            }
            Console.WriteLine("Su total fue " + total + " puntos");
            Console.WriteLine("Gracias por jugar");
        }
    }
}
