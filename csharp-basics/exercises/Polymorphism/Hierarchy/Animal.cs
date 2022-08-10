using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public abstract class Animal
    {
        protected string animalName;
        protected string animalType;
        protected double animalWeight;
        protected int foodEaten;

        public Animal() { }

        public Animal(string animalType, string animalName, double animalWeight, int foodEaten)
        {
            this.animalType = animalType;
            this.animalName = animalName;
            this.animalWeight = animalWeight;
            this.foodEaten = foodEaten;
        }
        
        public abstract void MakeSound();

        public abstract void Eat(Food food);

        public abstract void Display();
    }
}
