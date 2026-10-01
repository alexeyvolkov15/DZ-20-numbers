using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите меньшее основание трапеции:");
        int osn1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите большее основание трапеции:");
        int osn2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите высоту трапеции:");
        int high = int.Parse(Console.ReadLine());

        if (osn1 < osn2)
        {
            double side = Math.Sqrt(high*high + (osn2 - osn1) * (osn2 - osn1) / 4);
            double perimeter = Math.Round(osn1 + osn2 + 2 * side);
            Console.WriteLine("периметр трапеции: " + perimeter);
        }
    }
}