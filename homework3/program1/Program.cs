using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {


             Shape rectangle;
             rectangle = ShapeFactory.GetShape("Rectangle");
            rectangle.SetParameters(5, 4);
            rectangle.Draw();
            Console.WriteLine("Rectangle area = " + rectangle.Area);

            Shape circle;
            circle = ShapeFactory.GetShape("Circle");
            circle.SetParameters(5);
            circle.Draw();
            Console.WriteLine("Circle area = " + circle.Area);

            Shape square;
            square = ShapeFactory.GetShape("Square");
            square.SetParameters(5);
            square.Draw();
            Console.WriteLine("Square area = " + square.Area);

            Shape triangle;
            triangle = ShapeFactory.GetShape("Triangle");
            triangle.SetParameters(5, 4);
            triangle.Draw();
            Console.WriteLine("Triangle area = " + triangle.Area);


        }
    }
}
