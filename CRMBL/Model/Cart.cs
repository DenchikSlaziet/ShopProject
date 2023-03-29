using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Model
{
    /// <summary>
    /// Сущность Корзины
    /// </summary>
    public class Cart:IEnumerable
    {
        /// <summary>
        /// Покупатель
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Продукты в корзине
        /// </summary>
        public Dictionary<Product, int> Products { get; set; }

        public Cart(Customer customer)
        {
            if(customer != null)
            {
                Customer = customer;
            }
            else
            {
                Customer = new Customer();
            }
            Products = new Dictionary<Product, int>();
        }
        
        public void Add(Product product)
        {
            if(Products.TryGetValue(product, out int count))
            {
                Products[product] = ++count;
            }
            else
            {
                Products.Add(product, 1);
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach(var item in Products.Keys)
            {
                for(int i = 0; i < Products[item]; i++)
                {
                    yield return item;
                }
            }
        }

        public List<Product> GetAll()
        {
            var result = new List<Product>();
            foreach(Product product in this)
            {
                result.Add(product);
            }
            return result;
        }

    }
}
