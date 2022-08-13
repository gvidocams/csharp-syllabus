using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdApp
{
    public class Poster : Advert
    {
        private int _width;
        private int _height;
        private int _numOfCopies;
        private int _rate;

        public Poster(int fee, int width, int height, int numOfCopies, int rate) : base(fee)
        {
            this._width = width;
            this._height = height;
            this._numOfCopies = numOfCopies;
            this._rate = rate;
        }

        public new int Cost()
        {
            int cost = (_width * _height) * _rate * _numOfCopies;

            return base.Cost() + cost;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}