using System;

namespace DragRace
{
    public class Lexus : Car, IBoost
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