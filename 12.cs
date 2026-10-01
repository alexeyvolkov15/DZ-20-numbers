using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите x1:");
        int x1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите y1:");
        int y1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите x2:");
        int x2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите y2:");
        int y2 = int.Parse(Console.ReadLine());

        double d = Math.Round(Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1)), 2);
        Console.WriteLine(d);
        
    }
}