using System;

namespace DragRace
{
    public class Tesla : Car
    {
        public override void SpeedUp() 
        {
            currentSpeed += 10;
        }

        public override void SlowDown() 
        {
            currentSpeed -= 5;
        }

        public override void StartEngine() 
        {
            Console.WriteLine("-- silence ---");
        }
    }
}