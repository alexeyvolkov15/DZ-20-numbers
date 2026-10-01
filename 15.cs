using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длину прямоугольника");
        int side1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите ширину прямоугольника");
        int side2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите сторону квадрата");
        int sidesquare = int.Parse(Console.ReadLine());
        int area = side1 * side2;
        int count = (side1 / sidesquare) * (side2 / sidesquare);
        Console.WriteLine("поместится "  + count + " квадратов");
    }
}