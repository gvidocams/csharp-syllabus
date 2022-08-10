using System;
namespace AdApp
{
    public class Hoarding: Advert
    {
        private int rate;
        private int numDays;

        public Hoarding(int fee, int rate, int numDays) : base(fee)
        {
            this.rate = rate;
            this.numDays = numDays;
        }
        
        public override int Cost() 
        {
            return base.Cost() + (numDays * rate);
        }
        
        public override string ToString() 
        {
            return base.ToString();
        }
    }
}