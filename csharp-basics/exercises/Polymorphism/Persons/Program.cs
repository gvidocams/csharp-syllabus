using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var Student = new Student("Gvido", "Cams", "Riga", 0, 4.5);
            var Employee = new Employee("Not Gvido", "Not Cams", "Not in Riga", 1, "C#/.net developer");

            Student.Display();
            Employee.Display();
            Console.ReadKey();
        }
    }
}