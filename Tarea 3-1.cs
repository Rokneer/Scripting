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
                Console.WriteLine("Aplica a tarifa A");
            }
            else if (2 <= salMin && salMin < 4)
            {
                Console.WriteLine("Aplica a tarifa B");
            }
            else
            {
                Console.WriteLine("Aplica a tarifa C");
            }
        }
    }
    
}
