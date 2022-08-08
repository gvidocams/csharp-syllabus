using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Student : Person
    {
        double gpa;

        public Student(string firstName, string lastName, string address, int id ,double gpa) : base(firstName, lastName, address, id)
        {
            this.gpa = gpa;
        }

        public void SetGpa(double gpa)
        {
            this.gpa = gpa;
        }

        public double GetGpa()
        {
            return gpa;
        }

        public override void Display()
        {
            Console.WriteLine($"First name: {GetFirstName()} Last name: {GetLastName()} GPA: {GetGpa()} Address: {GetAddress()} ID: {GetId()}");
        }
    }
}
