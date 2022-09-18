using Hierarchy.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy.Animals
{
    public class Cat : Felime
    {
        string catBreed;

        public Cat(string animalType, string animalName, string catBreed, double animalWeight, string livingRegion, int foodEaten) : base(animalType, animalName, animalWeight, livingRegion, foodEaten)
        {
            this.catBreed = catBreed;
        }

        public override string MakeSound()
        {
            return "Meeeeooooooowwww";
        }

        public override string Eat(Food Food)
        {
            _foodEaten += Food.Quantity;

            return "Chomp chomp";
        }

        public override string Display()
        {
            return $"Animal type: {_animalType} | Name: {_animalName} | Cat breed: {catBreed} | Weight: {_animalWeight} | Living region: {livingRegion} | Food eaten: {_foodEaten}";
        }
    }
}
