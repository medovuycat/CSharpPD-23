using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть три цілих числа: ");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Числа, які належать діапазону [1, 14]: ");

        if (IsInRange(number1, 1, 14))
        {
            Console.WriteLine(number1);
        }

        if (IsInRange(number2, 1, 14))
        {
            Console.WriteLine(number2);
        }

        if (IsInRange(number3, 1, 14))
        {
            Console.WriteLine(number3);
        }
    }

    static bool IsInRange(int number, int lowerNumber, int upperNumber)
    {
        return number >= lowerNumber && number <= upperNumber;
    }
}
