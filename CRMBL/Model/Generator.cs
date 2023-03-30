using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Model
{
    /// <summary>
    /// Сущность вспомогательного класса
    /// </summary>
    public class Generator
    {
        Random rnd = new Random();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Seller> Sellers { get; set; } = new List<Seller>();

        public List<Customer> GetNewCustomers(int count)
        {
            var result = new List<Customer>();

            for (int i = 0; i < count; i++)
            {
                var customer = new Customer()
                {
                    CustomerId = Customers.Count,
                    Name = GetRndText(),
                    NumberCard = GetRndText()
                };
                Customers.Add(customer);
                result.Add(customer);
            }
            return result;
        }

        public List<Seller> GetNewSellers(int count)
        {
            var result = new List<Seller>();

            for (int i = 0; i < count; i++)
            {
                var seller = new Seller()
                {
                    SellerId = Sellers.Count,
                    Name = GetRndText(),
                    Surname = GetRndText(),
                    CompanySeller = GetRndText(),
                    Age = rnd.Next(18, 99),
                    UniqueNumber = GetRndText()
                };
                Sellers.Add(seller);
                result.Add(seller);
            }
            return result;
        }

        public List<Product> GetNewProducts(int count)
        {
            var result = new List<Product>();

            for (int i = 0; i < count; i++)
            {
                var product = new Product()
                {
                    ProductId = Products.Count,
                    Name = GetRndText(),
                    Count = rnd.Next(10, 1000),
                    Price = Convert.ToDecimal(rnd.Next(5, 10000))
                };
                Products.Add(product);
                result.Add(product);
            }
            return result;
        }

        public List<Product> GetRandomProducts(int min,int max)
        {
            var result = new List<Product>();
            var count = rnd.Next(min, max);

            for (int i = 0; i < count; i++)
            {
                if (Products.Count > 0)
                {
                    result.Add(Products[rnd.Next(0, Products.Count - 1)]);
                }
            }
            return result;
            
        }

        private static string GetRndText()
        {
            return Guid.NewGuid().ToString().Substring(0, 7);
        }
    }
}
