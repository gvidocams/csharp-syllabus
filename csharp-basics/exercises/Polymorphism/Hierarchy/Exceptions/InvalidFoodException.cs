using System;

namespace Hierarchy.Exceptions
{
    public class InvalidFoodException : Exception
    {
        public InvalidFoodException(string food)
            : base($"Cannot declare a food type with this name: {food}") { }
    }
}
