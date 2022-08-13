using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public abstract class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id = 0;

        public Person(string firstName, string lastName, string address, int id)
        {
            this._firstName = firstName;
            this._lastName = lastName;   
            this._address = address; 
            this._id = id;
        }

        public void SetFirstName(string firstName)
        {
            this._firstName = firstName;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public void SetLastName(string lastName)
        {
            this._lastName = lastName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public void setAddress(string address)
        {
            this._address = address;
        }

        public string GetAddress()
        {
            return _address;
        }

        public void SetId(int id)
        {
            this._id = id;
        }

        public int GetId()
        {
            return _id;
        }

        public abstract void Display();
    }
}
