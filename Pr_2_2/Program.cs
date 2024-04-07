using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть довжини сторін трикутника: ");

        double side1, side2, side3;
        Console.Write("Сторона 1: ");
        side1 = double.Parse(Console.ReadLine());
        Console.Write("Сторона 2: ");
        side2 = double.Parse(Console.ReadLine());
        Console.Write("Сторона 3: ");
        side3 = double.Parse(Console.ReadLine());

        if (!IsTriangle(side1, side2, side3))
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
            return;
        }

        double perimeter = side1 + side2 + side3;
        Console.WriteLine($"Периметр трикутника: {perimeter}");

        double halfPerimeter = perimeter / 2;
        double area = Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
        Console.WriteLine($"Площа трикутника: {area}");

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("Трикутник рівносторонній.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("Трикутник рівнобедрений.");
        }
        else
        {
            Console.WriteLine("Трикутник різносторонній.");
        }
    }

    static bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}