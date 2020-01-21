using System;

namespace Solución_1
{
    class Program
   {
        static void Main()
	{
        Console.WriteLine("Cateto z: ");
        double z = double.Parse(Console.ReadLine());
        Console.WriteLine("Ángulo c: ");
        double cGrados = double.Parse(Console.ReadLine());

        double c = cGrados * (Math.PI / 180.0);

        double a = 90 - cGrados;
        double y = z / (Math.Cos(c));
        double t = z / (Math.Sin(c));

        Console.WriteLine("Hipotenusa t: " + t);
        Console.WriteLine("Cateto y: " + y);
        Console.WriteLine("Ángulo a: " + a + "°");

        }
   }
}
