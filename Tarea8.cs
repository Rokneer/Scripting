using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int dadoBasico = 0, dadoEspecial = 0, total = 0, vidas = 3, turnos = 0;
            string continuar = "s";

            while (continuar == "s")
            {
                {
                    dadoBasico = random.Next(1, 7);
                    total += dadoBasico;
                    Console.WriteLine("Dado1:" + dadoBasico);
                    Console.WriteLine("Total= " + total);
                    if (turnos % 3 == 0 && turnos != 0)
                    {
                        dadoEspecial = random.Next(1, 13);
                        total += dadoEspecial;
                        Console.WriteLine("Dado2:" + dadoEspecial);
                        Console.WriteLine("Total= " + total);
                    }
                    if (turnos % 2 == 0 && turnos != 0)
                    {
                        vidas--;
                    }
                    if (total >= 100)
                    {
                        Console.WriteLine("Ganador!");
                        continuar = "n";
                    }
                    else if (vidas == 0)
                    {
                        Console.WriteLine("Eliminado");
                        continuar = "n";
                    }
                    else
                    {
                        if (dadoBasico == dadoEspecial)
                        {
                            vidas++;
                        }

                        Console.WriteLine("Vidas= " + vidas);
                        Console.WriteLine("Desea continuar? (s/n): ");
                        continuar = Console.ReadLine();
                        turnos++;
                    }
                }
            }
            Console.WriteLine("Su total fue " + total + " puntos");
            Console.WriteLine("Gracias por jugar");
        }
    }
}
