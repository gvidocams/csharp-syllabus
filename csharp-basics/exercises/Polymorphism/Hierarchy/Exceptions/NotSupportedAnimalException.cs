using System;

namespace Hierarchy.Exceptions
{
    public class NotSupportedAnimalException : Exception
    {
        public NotSupportedAnimalException(string animalType)
            : base($"Not supported animal type: {animalType}") { }
    }
}
