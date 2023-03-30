using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Model
{
    public class ShopComputerModel
    {
        Generator generator = new Generator();
        Random random = new Random();

        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<Check> Checks { get; set; } = new List<Check>();
        public List<Sell> Sells { get; set; } = new List<Sell>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();

        public ShopComputerModel()
        {
            var sellers = generator.GetNewSellers(20);
            generator.GetNewProducts(1000);
            generator.GetNewCustomers(100);

            foreach (var s in sellers)
            {
                Sellers.Enqueue(s);
            }

            for (int i = 0; i < 3; i++)
            {
                if (Sellers.Count > 0)
                {
                    CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue()));
                }
            }
        }

        public void Start()
        {
            var customers = generator.GetNewCustomers(10);

            var carts = new Queue<Cart>();
            foreach (var item in customers)
            {
                var cart = new Cart(item);
                foreach(var product in generator.GetRandomProducts(10,30))
                {
                    cart.Add(product);
                }
                carts.Enqueue(cart);
            }

            while(carts.Count > 0)
            { 
                var cash = CashDesks[random.Next(CashDesks.Count - 1)]; //TODO:
                cash.Enqueue(carts.Dequeue());
            }

            while(true)
            {
                var cash = CashDesks[random.Next(CashDesks.Count - 1)]; //TODO:
                var money =cash.Dequeue();
            }
        }
    }
}
