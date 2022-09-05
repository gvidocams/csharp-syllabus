using System;
using System.Collections.Generic;
using System.Linq;
using VendingMachine.Exceptions;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        private int[] _validCents = { 0, 10, 20, 50 };
        private int[] _validEuros = { 0, 1, 2 };

        private const int _storageLimit = 20;

        private string _manufacturer;
        private List<Product> _productList;
        private Money _money;

        public VendingMachine(string manufacturer, Money money, List<Product> productList)
        {
            _manufacturer = manufacturer;
            _money = money;
            _productList = productList;
        }

        public string Manufacturer 
        {
            get => _manufacturer;
        }

        public bool HasProducts
        {
            get => _productList.Count > 0;
        }

        public Money Amount
        {
            get => _money;
        }

        public Product[] Products
        {
            get => _productList.ToArray();
            set => _productList = value.ToList();
        }

        public Money InsertCoin(Money amount)
        {
            if (!_validCents.Contains(amount.Cents) && !_validEuros.Contains(amount.Euros)) 
            {
                throw new InvalidMoneyException();
            }

            _money.Euros += amount.Euros;
            _money.Cents += amount.Cents;

            return amount;
        }

        public Money ReturnMoney()
        {
            var returnedMoney = _money;
            _money = new Money();

            return returnedMoney;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            Validate.Price(price);

            var Product = new Product()
            {
                Name = name,
                Price = price,
                Available = count
            };

            _productList.Add(Product);

            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if(productNumber < 0 || productNumber > _storageLimit)
            {
                throw new InvalidProductNumberException();
            }

            if(!price.HasValue)
            {
                price = _productList[productNumber].Price; 
            }

            Validate.Price((Money)price);

            Product UpdatedProduct = new Product()
            {
                Name = name,
                Price = (Money)price,
                Available = amount
            };

            _productList[productNumber] = UpdatedProduct;

            return true;
        }
    }
}
