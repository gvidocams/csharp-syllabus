using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Employee : Person
    {
        string jobTitle;

        public Employee(string firstName, string lastName, string address, int id, string jobTitle) : base(firstName, lastName, address, id)
        {
            this.jobTitle = jobTitle;
        }

        public void SetJobTitle(string jobTitle)
        {
            this.jobTitle = jobTitle;
        }

        public string GetJobTitle()
        {
            return jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"First name: {GetFirstName()} Last name: {GetLastName()} GPA: {GetJobTitle()} Address: {GetAddress()} ID: {GetId()}");
        }
    }
}
