using System;

namespace Solución_1
{
    class Program
    {
        static void Main()
	{
        Console.WriteLine("Ingrese cateto y: ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese cateto z: ");
        double z = double.Parse(Console.ReadLine());


        double t = Math.Sqrt((y * y) + (z * z));
        double a = Math.Atan(z / y);
        double c = 90 - a;

        Console.WriteLine("Hipotenusa t: " + t);
        Console.WriteLine("Ángulo a: " + a + "°");
        Console.WriteLine("Ángulo c: " + c + "°");

    }
    }
}
