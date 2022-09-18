using Hierarchy.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy.Animals
{
    public class Zebra : Mammal
    {
        public Zebra(string animalType, string animalName, double animalWeight, string livingRegion, int foodEaten) : base(animalType, animalName, animalWeight, livingRegion, foodEaten)
        {
        }

        public override string MakeSound()
        {
            return "Neigh";
        }

        public override string Eat(Food Food)
        {
            if (Food.GetType().Name == "Vegetable")
            {
                _foodEaten += Food.Quantity;

                return "Chomp chomp";
            }
            else
            {
                return "Zebra doesn't eat that type of food";
            }
        }

        public override string Display()
        {
            return $"Animal type: {_animalType} | Name: {_animalName} | Weight: {_animalWeight} | Living region: {livingRegion} | Food eaten: {_foodEaten}";
        }
    }
}
