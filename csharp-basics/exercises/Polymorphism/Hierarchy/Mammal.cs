﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        protected string livingRegion;

        public Mammal(string animalType, string animalName, double animalWeight, string livingRegion, int foodEaten) : base(animalType, animalName, animalWeight, foodEaten)
        {
            this.livingRegion = livingRegion;
        }

        public override void Display()
        {
            Console.WriteLine($"Animal type: {_animalType} | Name: {_animalName} | Weight: {_animalWeight} | Living region: {livingRegion} | Food eaten: {_foodEaten}");
        }
    }
}
