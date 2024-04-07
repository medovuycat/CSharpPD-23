using System;

class Program
{
    static void Main(string[] args)
    {
        int[] X = new int[14] { 5, -19, 3, 8, -17, 7, 11, -14, 6, -10, 4, 9, -11, 0 };

        Console.WriteLine("Масив X:");
        PrintArray(X);

        Console.Write("Введіть число M: ");
        int M = int.Parse(Console.ReadLine());

        int[] Y = FormArray(X, M);

        Console.WriteLine($"Число M: {M}");

        Console.WriteLine("Масив Y:");
        PrintArray(Y);
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static int[] FormArray(int[] array, int M)
    {
        int count = 0;
        foreach (var element in array)
        {
            if (Math.Abs(element) > M)
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;
        foreach (var element in array)
        {
            if (Math.Abs(element) > M)
            {
                result[index] = element;
                index++;
            }
        }

        return result;
    }
}
