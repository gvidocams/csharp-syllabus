using System;

namespace DragRace
{
    public class Volkswagen : Car
    {
        private int currentSpeed = 0;

        public override void SpeedUp()
        {
            currentSpeed += 2;
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