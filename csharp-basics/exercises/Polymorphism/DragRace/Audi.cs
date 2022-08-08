using System;

namespace DragRace
{
    public class Audi : Car
    {
        private int currentSpeed = 0;

        public override void SpeedUp() 
        {
            currentSpeed += 4;
        }

        public override void SlowDown() 
        {
            currentSpeed -= 4;
        }

        public override void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}