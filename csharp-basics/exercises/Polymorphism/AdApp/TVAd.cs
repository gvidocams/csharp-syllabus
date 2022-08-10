namespace AdApp
{
    public class TVAd: Advert
    {
        int seconds;
        int rate;
        bool isPeakTime;
        private const int _peakTimeMultiplier = 2;
        public TVAd(int fee, int seconds, int rate, bool isPeakTime) : base(fee)
        {
            this.seconds = seconds;
            this.rate = rate;
            this.isPeakTime = isPeakTime;
        }

        public new int Cost() 
        {
            int cost = seconds * rate;

            return base.Cost() + (isPeakTime ? cost * _peakTimeMultiplier : cost);
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}