using System;

namespace CSharpAssignment3
{
    abstract class Shape
    {
        abstract public double calculateArea();
        abstract public double calculatePerimeter();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle() { }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        static readonly double PI = 3.14;
        public override double calculateArea()
        {
            return PI * Radius * Radius;
        }
        public override double calculatePerimeter()
        {
            return 2 * PI * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle() { }
        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }
        public override double calculateArea()
        {
            return Length * Width;
        }
        public override double calculatePerimeter()
        {
            return 2 * (Length * Width);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle { Radius = 100 };
            Console.WriteLine("Circle");
            Console.WriteLine("Radius: " + circle1.Radius);
            Console.WriteLine("Area: " + circle1.calculateArea());
            Console.WriteLine("Perimeter: " + circle1.calculatePerimeter());

            Console.WriteLine();

            Rectangle rectangle1 = new Rectangle();
            Console.WriteLine("Rectangle");
            Console.Write("Length: ");
            rectangle1.Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width: ");
            rectangle1.Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area: " + rectangle1.calculateArea());
            Console.WriteLine("Perimeter: " + rectangle1.calculatePerimeter());
        }
    }
}