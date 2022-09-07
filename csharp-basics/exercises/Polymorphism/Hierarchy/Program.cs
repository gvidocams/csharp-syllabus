using System;
using System.Collections.Generic;
using Hierarchy.Animals;
using Hierarchy.Foods;
using Hierarchy.Exceptions;

namespace Hierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal Formater");

            List<Animal> animals = HierarchyLoop();

            Console.WriteLine("Animal list:");
            Console.WriteLine(animals[0].Display());
            Console.ReadKey();
        }

        static List<Animal> HierarchyLoop()
        {
            var animals = new List<Animal>();

            string animalInfo;
            string foodInfo;

            do
            {
                Console.WriteLine("Format: Animal_type Animal_name Cat_breed(if it's a cat) Animal_weight Living_region Food_eaten");
                
                Console.Write("\nEnter information about the animal:");
                animalInfo = Console.ReadLine();

                if (animalInfo == "End")
                {
                    break;
                }

                Animal Animal = FormatAnimal(animalInfo);
                Console.WriteLine(Animal.MakeSound());

                Console.WriteLine("\nEnter information about the food:");
                foodInfo = Console.ReadLine();

                if (foodInfo == "End")
                {
                    break;
                }

                Food Food = FormatFood(foodInfo);
                Console.WriteLine(Animal.Eat(Food));

                animals.Add(Animal);
            }
            while (true);

            return animals;
        }

        public static Animal FormatAnimal(string userInput)
        {
            string[] animalInfo = userInput.Split(' ');

            if (animalInfo[0] == "Mouse")
            {
                return new Mouse(animalInfo[0], animalInfo[1], Convert.ToDouble(animalInfo[2]), animalInfo[3], Convert.ToInt32(animalInfo[4]));
            }
            else if (animalInfo[0] == "Zebra")
            {
                return new Zebra(animalInfo[0], animalInfo[1], Convert.ToDouble(animalInfo[2]), animalInfo[3], Convert.ToInt32(animalInfo[4]));
            }
            else if (animalInfo[0] == "Cat")
            {
                return new Cat(animalInfo[0], animalInfo[1], animalInfo[2], Convert.ToDouble(animalInfo[3]), animalInfo[4], Convert.ToInt32(animalInfo[5]));
            }
            else if (animalInfo[0] == "Tiger")
            {
                return new Tiger(animalInfo[0], animalInfo[1], Convert.ToDouble(animalInfo[2]), animalInfo[3], Convert.ToInt32(animalInfo[4]));
            }
            else
            {
                throw new NotSupportedAnimalException(animalInfo[0]);
            }
        }

        public static Food FormatFood(string userInput)
        {
            string[] foodInfo = userInput.Split(' ');
            string foodType = foodInfo[0];
            int foodAmount = Convert.ToInt32(foodInfo[1]);

            if (foodType == "Vegetable")
            {
                return new Vegetable(foodAmount);
            }
            else if (foodType == "Meat")
            {
                return new Meat(foodAmount);
            }
            else
            {
                throw new InvalidFoodException(foodType);
            }
        }
    }
}