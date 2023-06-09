﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CRMBL.Model
{
    public class ShopComputerModel
    {
        Generator generator = new Generator();
        Random random = new Random();
        bool isWorking = false;

        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<Check> Checks { get; set; } = new List<Check>();
        public List<Sell> Sells { get; set; } = new List<Sell>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();
        public int CustomerSpeed { get; set; } = 100;
        public int CashDeskSpeed { get; set; } = 1000;

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
                    CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue(),null));
                }
            }
        }

        public void Start()
        {
            isWorking = true;
            Task.Run(()=>CreateCards(10));

            var cashDeskTasks = CashDesks.Select(x => new Task(() => CashDeskWork(x)));
            foreach(var task in cashDeskTasks)
            {
                task.Start();
            }
        }

        private void CashDeskWork(CashDesk cashDesk)
        {
            while (isWorking)
            {
                if (cashDesk.Count > 0)
                {
                    cashDesk.Dequeue();
                    Thread.Sleep(CashDeskSpeed);
                }
            }
        }

        public void Stop()
        {
            isWorking = false;
        }

        private void CreateCards(int customerCounts)
        {
            while (isWorking)
            {
                var customers = generator.GetNewCustomers(customerCounts);

                foreach (var item in customers)
                {
                    var cart = new Cart(item);

                    foreach(var product in generator.GetRandomProducts(10,30))
                    {
                        cart.Add(product);
                    }

                    var cash = CashDesks[random.Next(CashDesks.Count)]; //TODO:
                    cash.Enqueue(cart);
                }
                Thread.Sleep(CustomerSpeed);
            }
        }
    }
}
