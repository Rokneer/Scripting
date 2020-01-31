using System;

namespace Tarea_3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese su salario: ");
            double sal = double.Parse(Console.ReadLine());
            double salMin = (sal / 877803.0);

            if (salMin < 2)
            {
                Console.WriteLine("Aplica a tarifa A y por consulta cancela $3.400");
            }
            else if (2 <= salMin && salMin < 5)
            {
                Console.WriteLine("Aplica a tarifa B por consulta cancela $13.500");
            }
            else
            {
                Console.WriteLine("Aplica a tarifa C por consulta cancela $35.600");
            }
        }
    }
}
