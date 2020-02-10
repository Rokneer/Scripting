using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese su salario");
            double sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de contrato: 1-Dependiente / 2-Independiente");
            int contrato = int.Parse(Console.ReadLine());
            double salMin = 877803, arl = 0, eps = 0, pension = 0, prima = 0;
            double baseCot = sal * 0.4;
            if (baseCot < salMin) baseCot = salMin;
            switch(contrato)
            {
                case 1:
                    eps = 0.04 * baseCot;
                    pension = 0.04 * baseCot;
                    prima = sal;
                    break;
                case 2:
                    eps = 0.125 * baseCot;
                    pension = 0.16 * baseCot;
                    int riesgo = int.Parse(Console.ReadLine());
                        switch(riesgo)
                    {
                        case 1: arl = 0.522 / 100; break;
                        case 2: arl = 1.044 / 100; break;
                        case 3: arl = 2.463 / 100; break;
                        case 4: arl = 4.35 / 100; break;
                        case 5: arl = 6.96 / 100; break;
                    }
                    break;
                default:
                    Console.WriteLine("Tipo de contrato no valido");
                    break;
            }
            double salReal = sal - (arl * baseCot + pension + eps);
            double salAnual = salReal * 12 + prima;
            Console.WriteLine("Salario Real= " + salReal);
            Console.WriteLine("Salario Anual= " + salAnual);
        }
    }
}
