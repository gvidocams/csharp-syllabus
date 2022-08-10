using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdApp
{
    public class Poster : Advert
    {
        int width;
        int height;
        int numOfCopies;
        int rate;

        public Poster(int fee, int width, int height, int numOfCopies, int rate) : base(fee)
        {
            this.width = width;
            this.height = height;
            this.numOfCopies = numOfCopies;
            this.rate = rate;
        }

        public new int Cost()
        {
            int cost = (width * height) * rate * numOfCopies;

            return base.Cost() + cost;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}