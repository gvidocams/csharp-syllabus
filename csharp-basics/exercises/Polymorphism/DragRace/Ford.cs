using System;

namespace DragRace
{
    public class Ford : Car
    {
        public override void SpeedUp()
        {
            currentSpeed += 3;
        }

        public override void SlowDown()
        {
            currentSpeed -= 2;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}