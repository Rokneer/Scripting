using System;

namespace Solución_1
{
    class Program
   {
        static void Main()
	{
        Console.WriteLine("Hipotenusa t: ");
        double t = double.Parse(Console.ReadLine());
        Console.WriteLine("Ángulo a: ");
        double aGrados = double.Parse(Console.ReadLine());

        double a = aGrados * (Math.PI / 180.0);

        double c = 90 - aGrados;
        double z = Math.Sin(a) * t;
        double y = Math.Cos(a) * t;
        

        Console.WriteLine("Cateto z: " + z);
        Console.WriteLine("Cateto y: " + y);
        Console.WriteLine("Ángulo c: " + c + "°");

    }
   }
}
