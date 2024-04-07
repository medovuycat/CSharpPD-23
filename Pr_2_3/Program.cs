using System;

class Program
{
    static void Main(string[] args)
    {
        int[] X = new int[14] { 5, 10, 3, 8, 15, 7, 21, 12, 6, 18, 4, 9, 11, 4 };

        Console.WriteLine("Масив X:");
        PrintArray(X);

        int min = FindMin(X);
        int max = FindMax(X);

        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static int FindMin(int[] array)
    {
        int min = array[0];
        foreach (var element in array)
        {
            if (element < min)
            {
                min = element;
            }
        }
        return min;
    }

    static int FindMax(int[] array)
    {
        int max = array[0];
        foreach (var element in array)
        {
            if (element > max)
            {
                max = element;
            }
        }
        return max;
    }
}
