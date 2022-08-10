using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    internal class Commision : Hourly
    {
        double totalSales;
        double commisionRate;

        public Commision(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commisionRate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            this.commisionRate = commisionRate;
        }

        public void AddSales(double totalSales)
        {
            this.totalSales += totalSales;
        }

        public override double Pay()
        {
            double currentSales = totalSales;
            totalSales = 0;

            return base.Pay() + currentSales * commisionRate;
        }

        public override string ToString()
        {
            return base.ToString() + " Total sales: " + totalSales;
        }
    }
}
