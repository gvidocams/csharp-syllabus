namespace AdApp
{
    public class TVAd: Advert
    {
        private int _seconds;
        private int _rate;
        private bool _isPeakTime;
        private const int _peakTimeMultiplier = 2;
        public TVAd(int fee, int seconds, int rate, bool isPeakTime) : base(fee)
        {
            this._seconds = seconds;
            this._rate = rate;
            this._isPeakTime = isPeakTime;
        }

        public new int Cost() 
        {
            int cost = _seconds * _rate;

            return base.Cost() + (_isPeakTime ? cost * _peakTimeMultiplier : cost);
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}