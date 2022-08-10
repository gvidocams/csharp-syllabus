using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        private const int _StorageLimit = 20;

        string manufacturer;
        Money money;
        Product[] products;

        public VendingMachine(string manufacturer)
        {
            this.manufacturer = manufacturer;
            this.money = new Money();
            this.products = new Product[_StorageLimit];
        }

        public string Manufacturer 
        {
            get { return manufacturer; }
        }

        public bool HasProducts
        {
            get { 
                for(int i = 0; i < products.Length; i++)
                {
                    if (products[i].Name != null)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public Money Amount
        {
            get { return money; }
        }

        public Product[] Products
        {
            get { return products; }
            set { products = value; }
        }

        public Money InsertCoin(Money amount)
        {
            money.Euros += amount.Euros;
            money.Cents += amount.Cents;

            return amount;
        }

        public Money ReturnMoney()
        {
            Money returnedMoney = money;
            money = new Money();

            return returnedMoney;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            var Product = new Product();
            Product.Name = name;
            Product.Price = price;
            Product.Available = count;

            for(int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == null)
                {
                    products[i] = Product;

                    return true;
                }
            }

            Console.WriteLine("Insuficient space!");
            return false;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if(productNumber < 0 || productNumber > _StorageLimit)
            {
                return false;
            }

            Product UpdatedProduct = new Product();
            UpdatedProduct.Name = name;
            UpdatedProduct.Price = (Money)price;
            UpdatedProduct.Available = amount;

            products[productNumber] = UpdatedProduct;

            return true;
        }
    }
}
