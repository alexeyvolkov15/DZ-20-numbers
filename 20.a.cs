using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int sum = 0;

        for (int i = 0; i < 12; i++)
        {
            int digit = random.Next(0, 10);

            if (i % 2 == 0)
            {
                sum += digit;
            }
            else
            {
                sum += digit * 3;
            }
        }

        int control = (10 - sum % 10) % 10;

        Console.WriteLine("Контрольная цифра: " + control);
    }
}
