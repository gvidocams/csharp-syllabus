using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Tiger : Felime
    {
        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion, int foodEaten) : base(animalType, animalName, animalWeight, livingRegion, foodEaten)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Rawr");
        }

        public override void Eat(Food Food)
        {
            if (Food.GetType().Name == "Meat")
            {
                foodEaten += Food.quantity;
                Console.WriteLine("Chomp chomp");
            }
            else
            {
                Console.WriteLine("Mouse doesn't eat that type of food");
            }
        }

        public override void Display()
        {
            Console.WriteLine($"Animal type: {animalType} | Name: {animalName} | Weight: {animalWeight} | Living region: {livingRegion} | Food eaten: {foodEaten}");
        }
    }
}
