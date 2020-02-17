using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dado1 = 0, total = 0, contadorDoce = 0, contadorDiez = 0, contadorTurnos = 0;
            string continuar = "s";

            while (continuar == "s")
            {
                dado1 = random.Next(1, 13);
                total += dado1;
                Console.WriteLine("Dado 1:" + dado1);
                Console.WriteLine("Total= " + total);
                bool A = (dado1 % 2 != 0);
                if (dado1 == 10)
                {
                    contadorDiez++;
                    if (dado1 == 12) contadorDoce++;
                }
                else
                {
                    contadorDoce = 0;
                    contadorDiez = 0;
                }
                if (total >= 100 || (contadorDoce == 1 && contadorDiez == 1))
                {
                    Console.WriteLine("Ganador!");
                    continuar = "n";
                }
                else
                {
                    Console.WriteLine("Desea continuar? (s/n): ");
                    continuar = Console.ReadLine();
                    contadorTurnos++;
                }
                if (contadorTurnos > 3)
                {
                    if (A == true)
                    {
                        Console.WriteLine("Eliminado");
                        continuar = "n";
                    }
                }
            }
            Console.WriteLine("Su total fue " + total + " puntos");
            Console.WriteLine("Gracias por jugar");
        }
    }
}
