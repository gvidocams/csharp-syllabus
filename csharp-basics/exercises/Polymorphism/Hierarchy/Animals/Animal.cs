using Hierarchy.Foods;

namespace Hierarchy.Animals
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
            _animalType = animalType;
            _animalName = animalName;
            _animalWeight = animalWeight;
            _foodEaten = foodEaten;
        }

        public abstract string MakeSound();

        public abstract string Eat(Food food);

        public abstract string Display();
    }
}
