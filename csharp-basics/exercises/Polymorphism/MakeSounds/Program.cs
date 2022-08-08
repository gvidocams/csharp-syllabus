using System;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var Firework = new Firework();
            var Parrot = new Parrot();
            var Radio = new Radio();

            for (int i = 0; i < 10; i++)
            {
                Firework.PlaySound();
                Parrot.PlaySound();
                Radio.PlaySound();
            }

            Console.ReadKey();
        }
    }
}