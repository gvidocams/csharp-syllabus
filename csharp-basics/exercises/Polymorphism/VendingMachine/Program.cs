using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var VendingMachine = new VendingMachine("LG");


            Console.WriteLine(VendingMachine.HasProducts);
            
            var Icecream = new Product();
            Icecream.Name = "Tio";
            Icecream.Available = 15;

            var Change = new Money();
            Change.Euros = 5;
            Change.Cents = 25;

            VendingMachine.AddProduct("Chocolate", Change, 12);

            Console.WriteLine(VendingMachine.HasProducts);

            Console.ReadKey();
        }
    }
}
