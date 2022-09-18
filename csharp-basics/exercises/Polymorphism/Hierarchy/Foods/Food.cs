using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy.Foods
{
    public abstract class Food
    {
        public int Quantity;

        public Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}
