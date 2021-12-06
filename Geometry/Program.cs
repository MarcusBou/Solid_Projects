using System;
using System.Collections.Generic;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape square1 = new Square(4);
            Shape rec1 = new Rectangle(5, 10);
            Shape paralel = new Parallelogram(3, 32, 20);
            Shape trapez = new Trapez(15,10,8,10);
            Shape triangle = new Triangle(10,5);
            List<Shape> shapes = new List<Shape>();
            shapes.Add(square1);
            shapes.Add(rec1);
            shapes.Add(paralel);
            shapes.Add(trapez);
            shapes.Add(triangle);
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area());
                Console.WriteLine(shape.Circumference());
            }
        }
    }
}
