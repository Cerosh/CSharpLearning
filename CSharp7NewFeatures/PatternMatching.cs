using System;
namespace CSharp7NewFeatures
{
    public class PatternMatching
    {
        public const float PI = 3.14f;

    }

    public class Circle : PatternMatching
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    public class Rectangle : PatternMatching
    {
        public double Length { get; }
        public double Height { get; }
        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }

    public class Triangle : PatternMatching
    {
        public double Base { get; }
        public double Height { get; }
        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
    }
    public class DisplayAreaClass
    {
        public void DisplayAreaMethod(PatternMatching shape)
        {
            if (shape is Circle c)
            {
                Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * PatternMatching.PI);
            }
            else if (shape is Rectangle r)
            {
                Console.WriteLine("Area of Rectangle is : " + r.Length * r.Height);
            }
            else if (shape is Triangle t)
            {
                Console.WriteLine("Area of Triangle is : " + 0.5 * t.Base * t.Height);
            }
            else
            {
                throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }
        }
    }

}
