using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public abstract class Car : ICar
    {
        private int currentSpeed;
        
        public abstract void SpeedUp();

        public abstract void SlowDown();

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public abstract void StartEngine();

        //abstract void UseNitrousOxideEngine();
    }
}
