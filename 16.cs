using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int last = number % 10;
        int first = number / 10;
        Console.WriteLine(last * 100 + first);
    }
}