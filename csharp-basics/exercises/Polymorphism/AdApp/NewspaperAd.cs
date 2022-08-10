namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int column;
        private int rate;

        public NewspaperAd(int fee, int rate, int column) : base(fee)
        {
            this.rate = rate;
            this.column = column;
        }

        public override int Cost()
        {
            return base.Cost() + (column * rate);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}