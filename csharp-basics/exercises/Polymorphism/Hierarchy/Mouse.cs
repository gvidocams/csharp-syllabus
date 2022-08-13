using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string animalType, string animalName, double animalWeight, string livingRegion, int foodEaten) : base(animalType, animalName, animalWeight, livingRegion, foodEaten)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Sqeak squek squeak...");
        }

        public override void Eat(Food Food)
        {
            if(Food.GetType().Name == "Vegetable")
            {
                _foodEaten += Food.quantity;
                Console.WriteLine("Chomp chomp");
            }
            else
            {
                Console.WriteLine("Mouse doesn't eat that type of food");
            }
        }

        public override void Display()
        {
            Console.WriteLine($"Animal type: {_animalType} | Name: {_animalName} | Weight: {_animalWeight} | Living region: {livingRegion} | Food eaten: {_foodEaten}");
        }
    }
}
