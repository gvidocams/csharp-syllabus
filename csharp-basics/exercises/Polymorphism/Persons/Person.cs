using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public abstract class Person
    {
        string firstName;
        string lastName;
        string address;
        int id = 0;

        public Person(string firstName, string lastName, string address, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;   
            this.address = address; 
            this.id = id;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public abstract void Display();
    }
}
