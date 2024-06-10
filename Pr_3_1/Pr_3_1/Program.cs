using System;

class Point
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public string Label { get; set; }

    public Point(int x, int y, string label)
    {
        X = x;
        Y = y;
        Label = label;
    }

    public void Show()
    {
        Console.WriteLine($"Point {Label}: ({X}, {Y})");
    }
}

class Figure
{
    public Point[] Points { get; private set; }

    public Figure(params Point[] points)
    {
        if (points.Length < 3 || points.Length > 5)
            throw new ArgumentException("Малюнок повинен мати від 3 до 5 поінтів.");

        Points = points;
    }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public double PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < Points.Length; i++)
        {
            perimeter += LengthSide(Points[i], Points[(i + 1) % Points.Length]);
        }
        return perimeter;
    }

    public void Show()
    {
        foreach (var point in Points)
        {
            point.Show();
        }
        Console.WriteLine("Периметр багатокутника: " + PerimeterCalculator());
    }
}

class Program
{
    static void Main()
    {
        Point A = new Point(0, 0, "A");
        Point B = new Point(0, 3, "B");
        Point C = new Point(4, 0, "C");

        Figure triangle = new Figure(A, B, C);
        triangle.Show();
    }
}
