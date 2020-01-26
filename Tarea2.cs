using System;


namespace Ejercicio_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese b° ,z, y:");

            double b1 = double.Parse(Console.ReadLine());
            double z1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
                       
            //Hipotenusa t1
            double t1 = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(z1, 2));

            // Angulos a1, c1, e1 y d1
            double aRad1 = Math.Atan(z1 / y1);
            double a1 = (aRad1 * 180.0) / Math.PI;
            double c1 = 90.0 - a1;
            double e1 = 180.0 - c1;
            double d1 = 180.0 - (b1 + e1);

            //Angulo b1 y d1 en Rad
            double dRad1 = d1 * (Math.PI / 180.0);
            double bRad1 = b1 * (Math.PI / 180.0);

            //Cateto x1
            double x1 = (t1 * Math.Sin(bRad1)) / Math.Sin(dRad1);
            Console.WriteLine("Cateto x1 es igual a :" + x1);

            //Fin 1
            
            Console.WriteLine("Ingrese d° ,b°, y:");

            double d2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            //Angulos e2, c2 y a2
            double e2 = 180.0 - (d2 + b2);
            double c2 = 180.0 - e2;
            double a2 = 180.0 - (c2 + 90);

            //Angulos c2 y a2 en Rad
            double cRad2 = c2 * (Math.PI / 180.0);
            double aRad2 = a2 * (Math.PI / 180.0);

            //Cateto z2
            double z2 = (y2 * Math.Sin(cRad2)) / Math.Sin(aRad2);
            Console.WriteLine("Cateto z2 es igual a :" + z2);

            //Fin 2

            Console.WriteLine("Ingrese w ,d°, x:");

            double w3 = double.Parse(Console.ReadLine());
            double d3 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());

            //Angulo d3 en Rad
            double dRad3 = d3 * (Math.PI / 180.0);

            //Lado t3
            double t3 = Math.Sqrt((Math.Pow(w3, 2) + Math.Pow(x3, 2)) - (2.0 * w3 * x3 * Math.Cos(dRad3)));

            //Angulos e3, c3, b3 y a3
            double eRad3 = Math.Asin((w3 * Math.Sin(d3)) / t3);
            double e3 = eRad3 * (180.0 / Math.PI);
            double c3 = 180.0 - e3;
            double a3 = 180.0 - (c3 + 90.0);

            //Angulos c3 y a3 en Rad
            double aRad3 = a3 * (Math.PI / 180.0);

            //Cateto y3
            double y3 = t3 * Math.Sin(aRad3);
            Console.WriteLine("Cateto y3 es igual a :" + y3);

            //Fin 3

            Console.WriteLine("Ingrese w ,t, c°:");
            double w4 = double.Parse(Console.ReadLine());
            double t4 = double.Parse(Console.ReadLine());
            double c4 = double.Parse(Console.ReadLine());

            //Angulos e4, d4 y b4
            double e4 = 180.0 - c4;
            double eRad4 = e4 * (Math.PI / 180.0);
            double dRad4 = Math.Asin((t4 * Math.Sin(eRad4)) / w4);
            double d4 = dRad4 * (180.0 / Math.PI);
            double b4 = 180.0 - (e4 + d4);
            double bRad4 = b4 * (Math.PI / 180.0);

            //Cateto x4
            double x4 = (w4 * Math.Sin(bRad4)) / Math.Sin(eRad4);
            Console.WriteLine("Cateto x4 es igual a :" + x4);

        }
    }
}
