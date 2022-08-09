using System;

namespace DragRace
{
    public class Bmw : Car, IBoost
    {
        public string GetCarBrand()
        {
            return "BMW";
        }

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