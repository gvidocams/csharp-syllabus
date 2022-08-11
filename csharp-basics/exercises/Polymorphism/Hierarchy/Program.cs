using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal Formater");

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

                

                Animal.MakeSound();

                Console.WriteLine("\nEnter information about the food");
                foodInfo = Console.ReadLine();

                if (foodInfo == "End")
                {
                    break;
                }

                Food Food = FormatFood(foodInfo);
                Animal.Eat(Food);

                animals.Add(Animal);
            }
            while (true);

            Console.WriteLine("Animal list:");

            animals[0].Display();

            Console.ReadKey();
        }

        static Animal FormatAnimal(string userInput)
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
            else
            {
                return new Tiger(animalInfo[0], animalInfo[1], Convert.ToDouble(animalInfo[2]), animalInfo[3], Convert.ToInt32(animalInfo[4]));
            }
        }

        static Food FormatFood(string userInput)
        {
            string[] foodInfo = userInput.Split(' ');

            while (true)
            {
                switch (foodInfo[0])
                {
                    case "Vegetable":
                        return new Vegetable(Convert.ToInt32(foodInfo[1]));

                    case "Meat":
                        return new Meat(Convert.ToInt32(foodInfo[1]));
                }
            }
        }
    }
}