using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static project_3_2_.program;
using static project_3_2_.program.Circle;

namespace project_3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("choose what you want to calculate");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2.Rectangle");
                choice = Convert.ToInt16(Console.ReadLine());
                if (choice <= 0 || choice > 2)
                {
                    Console.WriteLine("Error: Invalid Input!");
                }
            } while (choice <= 0 || choice > 2);


            switch (choice)
            {
                case 1:
                    Circle cr = new Circle();
                    Console.WriteLine("Enter radius of the circle: ");
                    cr.radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of the Circle: " + cr.calculateArea());
                    Console.WriteLine("Perimeter of the Circle: " + cr.calculatePerimeter());
                    break;
                case 2:
                    rectangle rc = new rectangle();
                    Console.WriteLine("Enter Length of the Rectangle: ");
                    rc.length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter width of the Rectangle: ");
                    rc.width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of the Rectangle: " + rc.calculateArea());
                    Console.WriteLine("Perimeter of the Rectangle: " + rc.calculatePerimeter());
                    break;
            }
            Console.ReadKey();
        }
    }
    internal class program
    {
        public abstract class shape
        {
            public abstract double calculateArea();
            public abstract double calculatePerimeter();
        }

        public class Circle : shape
        {
            public double radius;
            static double PI = 3.14;
            
            public override double calculateArea()
            {
                return PI * radius * radius;
            }

            public override double calculatePerimeter()
            {
                return 2 * PI * radius;
            }

            public class rectangle : shape
            {
                public double length { get; set; }
                public double width  { get; set; }

                public override double calculateArea()
                {
                    return length * width;
                }

                public override double calculatePerimeter()
                {
                    return 2*length + width;
                }
            }
        }
    }
   
}
