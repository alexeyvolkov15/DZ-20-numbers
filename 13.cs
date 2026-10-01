using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = a;
        int e = b;
        b = c;
        a = e;
        c = d;
        Console.WriteLine("пункт а:");
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        int f = a;
        int g = b;
        int h = c;
        b = f;
        c = g;
        a = h;
        Console.WriteLine("пункт b:");
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}