using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        Console.WriteLine(random.Next(1, 101));
        Console.WriteLine(random.Next(1, 101));
        Console.WriteLine(random.Next(1, 101));
        Console.WriteLine(random.Next(1, 101));
    }
}