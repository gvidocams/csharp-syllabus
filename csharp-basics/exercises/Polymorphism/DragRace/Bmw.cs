using System;

namespace DragRace
{
    public class Bmw : Car, IBoost
    {
        private int currentSpeed = 0;

        public override void SpeedUp() 
        {
            currentSpeed += 6;
        }

        public override void SlowDown() 
        {
            currentSpeed -= 2;
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 8;
        }

        public override void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}