using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public abstract class Animal
    {
        public string _animalName;
        public string _animalType;
        public double _animalWeight;
        public int _foodEaten;

        public Animal() { }

        public Animal(string animalType, string animalName, double animalWeight, int foodEaten)
        {
            this._animalType = animalType;
            this._animalName = animalName;
            this._animalWeight = animalWeight;
            this._foodEaten = foodEaten;
        }
        
        public abstract void MakeSound();

        public abstract void Eat(Food food);

        public abstract void Display();
    }
}
