using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        private const int _storageLimit = 20;

        private string _manufacturer;
        Money money;
        Product[] products;

        public VendingMachine(string manufacturer)
        {
            this._manufacturer = manufacturer;
            this.money = new Money();
            this.products = new Product[_storageLimit];
        }

        public string Manufacturer 
        {
            get => _manufacturer;
        }

        public bool HasProducts
        {
            get => products.Length > 0;
            /*
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
            */
        }

        public Money Amount
        {
            get => money;
        }

        public Product[] Products
        {
            get => products;
            set => products = value;
        }

        public Money InsertCoin(Money amount)
        {
            if(amount.Cents % 10 == 0 || amount.Cents % 20 == 0 || amount.Cents % 50 == 0 || amount.Euros % 2 == 0)
            {
                money.Euros += amount.Euros;
                money.Cents += amount.Cents;
            }

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
            if(productNumber < 0 || productNumber > _storageLimit)
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
