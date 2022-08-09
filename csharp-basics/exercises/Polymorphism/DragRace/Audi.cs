using System;

namespace DragRace
{
    public class Audi : Car
    {
        public string GetCarBrand()
        {
            return "Audi";
        }

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