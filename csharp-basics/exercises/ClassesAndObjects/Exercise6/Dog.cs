using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Dog
    {
        string name;
        string sex;
        string mother;
        string father;

        public Dog(string name, string sex)
        {
            this.name = name;
            this.sex = sex;
        }

        public Dog(string name, string sex, string mother, string father)
        {
            this.name = name;
            this.sex = sex;
            this.mother = mother;
            this.father = father;
        }
        
        public string FathersName()
        {
            if (this.father != null)
            {
                return this.father;
            }
            else
            {
                return "Unknown";
            }
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return otherDog.mother == this.mother;
        }
    }
}
