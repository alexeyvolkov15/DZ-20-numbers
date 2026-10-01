using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int hundreeds = (number / 100) % 10;
        int thousands = number / 1000;
        Console.WriteLine("Сотни: " + hundreeds);
        Console.WriteLine("Тысячи: " + thousands); 
    }
}