using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's menu choice.
            GetMenu();
        }

        public static void GetMenu()
        {
            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine($"Enter your choice (1-4) : ");
            // get input from user

            ConsoleKeyInfo userChoice = Console.ReadKey();
            Console.Clear();

            // validate input
            switch (userChoice.KeyChar)
            {
                case '1':
                    CalculateCircleArea();
                    break;
                case '2':
                    CalculateRectangleArea();
                    break;
                case '3':
                    CalculateTriangleArea();
                    break;
                case '4':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input!!!\n");
                    GetMenu();
                    break;
            }
        }
        
        public static void CalculateCircleArea()
        {
            decimal radius = 0;
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");
            //todo
            radius = Convert.ToDecimal(Console.ReadLine());
            // Display output
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }
        
        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            // Get input from user

            // Get length
            Console.Write("Enter length: ");
            //todo
            length = Convert.ToInt16(Console.ReadLine());
            // Get width
            Console.Write("Enter width:  ");
            width = Convert.ToInt16(Console.ReadLine());
            //todo

            // Display output
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
        }
        
        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            ground = Convert.ToInt16(Console.ReadLine());

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            height = Convert.ToInt16(Console.ReadLine());

            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
        
    }
}
