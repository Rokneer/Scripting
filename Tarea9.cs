using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int jugador = 1, total = 0, totalGanador = 0;
            string continuar = "s";
            Console.WriteLine("Ingrese el número de jugadores: ");
            int jugadores = int.Parse(Console.ReadLine());

            while (jugadores <= 2 && jugadores >= 5) 
            {
                Console.WriteLine("Número no valido de jugadores.");
                jugadores = int.Parse(Console.ReadLine());
            }

            while (jugador <= 5 && continuar == "s")
            {
                Console.WriteLine("Inicio Del Juego");
                Console.WriteLine("Turno del jugador " + jugador);
                int carta1 = 0, carta2 = 0;
                
                while (true)
                {
                    if (total < 21)
                    {
                        carta1 = random.Next(1, 11);
                        Console.WriteLine("Carta 1:" + carta1);
                        carta2 = random.Next(1, 11);
                        Console.WriteLine("Carta 2:" + carta2);
                        total += carta1 + carta2;
                        if (total > totalGanador) total = totalGanador;
                        Console.WriteLine("Total= " + total);
                        break;
                    }
                    else if (total == 21)
                    {
                        continuar = "n";
                        break;
                    }
                    else
                    {
                        continuar = "n";
                        break;
                    }
                }
                Console.WriteLine("Desea continuar? (s/n): ");
                continuar = Console.ReadLine();
                jugador++;
            }
            while (continuar == "n")
            {
                Console.WriteLine("Retirado");
                Console.WriteLine("Su total fue " + total + " puntos");
                if (total == 21) Console.WriteLine("El jugador" + jugador + "gana!");
                break;
            }
            Console.WriteLine("Gracias por jugar");
        }
    }
}
