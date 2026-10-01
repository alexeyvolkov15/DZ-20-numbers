using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int hour = 0;
        int minutte = 0;
        while (n > 3600)
        {
            n -= 3600;
            hour = hour + 1;
        }
        while (n > 60)
        {
            n -= 60;
            minutte = minutte + 1;
        }
        Console.WriteLine(hour + "часа");
        Console.WriteLine(minutte + "минут");
        Console.WriteLine(n + "секунд");
    }
}