namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;

        public NewspaperAd(int fee, int rate, int column) : base(fee)
        {
            this._rate = rate;
            this._column = column;
        }

        public override int Cost()
        {
            return base.Cost() + (_column * _rate);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}