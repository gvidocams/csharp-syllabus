using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Cat : Felime
    {
        string catBreed;

        public Cat(string animalType, string animalName, string catBreed, double animalWeight, string livingRegion, int foodEaten) : base(animalType, animalName, animalWeight, livingRegion, foodEaten)
        {
            this.catBreed = catBreed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meeeeooooooowwww");
        }

        public override void Eat(Food Food)
        {
            foodEaten += Food.quantity;
            Console.WriteLine("Chomp chomp");
        }

        public override void Display()
        {
            Console.WriteLine($"Animal type: {animalType} | Name: {animalName} | Cat breed: {catBreed} | Weight: {animalWeight} | Living region: {livingRegion} | Food eaten: {foodEaten}");
        }
    }
}
