using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20, b = 16, blanco = 5, anulado = 36, n = 477, p = 24;
            int numeroV = a + b + blanco + anulado;
            int abstencion = (n * (p / 100)) - numeroV;

            bool A = numeroV > n;
            bool B = (a - b) < numeroV * 0.1;
            bool C = numeroV < n * 0.3;

            if ((A || B) && C)
            {
                Console.WriteLine("Las elecciones deben ser realizadas nuevamente");
            }
            else
            {
                Console.WriteLine("Las votaciones fueron exitosas");
                if (a > b) Console.WriteLine("Gana a");
                else Console.WriteLine("Gana b");
            }
        }
    }
}
