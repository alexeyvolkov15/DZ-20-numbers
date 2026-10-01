using System;
using System.Threading;

class Program
{
    static void Main()
    {
        string hello = Console.ReadLine();
        Console.WriteLine("Как тебя зовут?");
        string name = Console.ReadLine();
        Console.WriteLine("Привет, " + name);
        string secroom = Console.ReadLine();
        Console.WriteLine("Да");
        string question = Console.ReadLine();
        Console.WriteLine("Нет");
        Thread.Sleep(5000);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Но могу показать");
    }
}