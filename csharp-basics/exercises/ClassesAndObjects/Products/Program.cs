using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Product
    {
        string name;
        double priceAtStart;
        int amountAtStart;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            this.name = name;
            this.priceAtStart = priceAtStart;
            this.amountAtStart = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"\"{this.name}\", {this.priceAtStart} EUR, {this.amountAtStart} units");
        }

        public void ChangeQuantity(int newQuantity)
        {
            this.amountAtStart = newQuantity;
        }

        public void ChangePrice(double newPrice)
        {
            this.priceAtStart = newPrice;
        }

        static void Main(string[] args)
        {
            Product LogitechMouse = new Product("Logitech mouse", 70.00, 14);
            Product IPhone5s = new Product("IPhone5s", 999.99, 3);
            Product EpsonEbU05 = new Product("Epson EB-U05", 70.00, 14);

            Console.WriteLine("Constructed products:\n");

            LogitechMouse.PrintProduct();
            IPhone5s.PrintProduct();
            EpsonEbU05.PrintProduct();

            LogitechMouse.ChangePrice(5.50);
            IPhone5s.ChangePrice(2000.00);
            IPhone5s.ChangeQuantity(200);
            EpsonEbU05.ChangeQuantity(0);

            Console.WriteLine("Slightly altered products:\n");

            LogitechMouse.PrintProduct();
            IPhone5s.PrintProduct();
            EpsonEbU05.PrintProduct();
        }
    }
}
