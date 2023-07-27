using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            circle.PrintInfo();

            Rectangle rectangle = new Rectangle(5, 2);
            rectangle.PrintInfo();

            Triangle triangle = new Triangle(3, 5, 9);
            triangle.PrintInfo();
            Console.ReadKey();
        }
    }
}