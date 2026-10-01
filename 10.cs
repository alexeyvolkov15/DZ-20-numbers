using System;
class Program
{
    static void Main()
    {
            Console.WriteLine("1 коэффицент");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("2 коэффицент");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("3 коэффицент");
            int c = int.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c;
        if (d < 0)
        {
            Console.WriteLine("нет корней");
        }
        else if (d == 0)
        {
        double x = -b / (2 * a);
        Console.WriteLine("1 корень: " + x);
        }
        else
        {
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("1 корень: " + x1);
            Console.WriteLine("2 корень: " + x2);
            Console. WriteLine(x2);
        }
    }
}
        