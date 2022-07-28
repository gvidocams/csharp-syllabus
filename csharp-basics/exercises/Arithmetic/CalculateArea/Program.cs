using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMenu();
        }

        public static void GetMenu()
        {
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.Write($"Enter your choice (1-4) : ");

            ConsoleKeyInfo userChoice = Console.ReadKey();
            Console.Clear();

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
            Console.Write("What is the circle's radius? ");
            var r = Convert.ToDecimal(Console.ReadLine());

            bool isValidInput = ValidateInput(r);

            if (isValidInput)
            {
                Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(r));
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Only positive numbers are valid!\n");
                CalculateCircleArea();
            }
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            Console.Write("Enter length: ");
            length = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter width:  ");
            width = Convert.ToInt16(Console.ReadLine());

            bool isValidInput = ValidateInput(width) || ValidateInput(length);

            if (isValidInput)
            {
                Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Only positive numbers are valid!\n");
                CalculateRectangleArea();
            }
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            Console.WriteLine("Enter length of the triangle's base? ");
            ground = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter triangle's height? ");
            height = Convert.ToInt16(Console.ReadLine());

            bool isValidInput = ValidateInput(ground) || ValidateInput(height);

            if (isValidInput)
            {
                Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Only positive numbers are valid!\n");
                CalculateTriangleArea();
            }
        }

        public static bool ValidateInput(decimal usrInput)
        {
            return usrInput > 0;
        }
    }
}
