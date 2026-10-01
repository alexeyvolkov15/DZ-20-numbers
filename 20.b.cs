using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] digits = new int[12];
        for (int i = 0; i < 12; i++)
        {
            digits[i] = random.Next(0, 10);
        }
        int sum = 0;
        for (int i = 0; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                sum = sum + digit;
            }
            else
            {
                sum = sum + digit * 3;
            }
        }
        int control = (10 - (sum % 10)) % 10;
        Console.WriteLine("Контрольное число: " + control);
    }
}