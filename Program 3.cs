using System;

interface IShape
{
    double GetArea();
}

abstract class Shape : IShape
{
    public abstract double GetArea();
}

class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double w, double h)
    {
        width = w;
        height = h;
    }

    public override double GetArea()
    {
        return width * height;
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(5, 10);
        Circle circle = new Circle(7);

        Console.WriteLine("Rectangle area: {0}", rect.GetArea());
        Console.WriteLine("Circle area: {0}", circle.GetArea());

        Console.ReadKey();
    }
}
