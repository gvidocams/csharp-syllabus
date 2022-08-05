
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        public string title;
        public bool flag;
        public List<double> ratings;

        public Video(string title)
        {
            this.title = title;
            flag = true;
            ratings = new List<double>();
        }

        public void BeingCheckedOut()
        {
            flag = false;
        }

        public void BeingReturned()
        {
            flag = true;
        }

        public void ReceivingRating(double rating)
        {
            ratings.Add(rating);
        }

        public double AverageRating()
        {
            return ratings.Sum() / ratings.Count;
        }

        public bool Available()
        {
            return flag;
        }

        public string Title => this.title;

        public override string ToString()
        {
            return $"Title: \"{Title}\" | Average rating: {AverageRating()} | Is available: {Available()}";
        }
    }
}
