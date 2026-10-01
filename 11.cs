using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Среднее арифметическое: " + (a + b) / 2);
        Console.WriteLine("Среднее геометрическое: " + Math.Sqrt(a * b));
    }
}