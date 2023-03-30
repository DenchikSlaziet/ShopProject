using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Model
{
    /// <summary>
    /// Сущность кассы
    /// </summary>
    public class CashDesk
    {
        private MyDbContext context = new MyDbContext();

        /// <summary>
        /// Номер кассы
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Продавец
        /// </summary>
        public Seller Seller { get; set; }

        /// <summary>
        /// Очередь
        /// </summary>
        public Queue<Cart> QueueCart { get; set; }

        /// <summary>
        /// Максимальная длинна очереди
        /// </summary>
        public int MaxQueueLenght { get; set; }

        /// <summary>
        /// Счетчик ушедших покупателей
        /// </summary>
        public int ExitCustomer { get; set; }

        /// <summary>
        /// Переключатель моделирования
        /// </summary>
        public bool IsModel { get; set; }

        public CashDesk(int number,Seller seller)
        {
            QueueCart = new Queue<Cart>();
            IsModel = true;
            //TODO Возможна сириализация номера кассы
            if(number>0 && seller != null)
            {
                Number = number;
                Seller = seller;
                return;
            }

            Number = new Random().Next(0,20);
            Seller = new Seller();
        }

        public void Enqueue(Cart cart)
        {
            if(cart!=null && QueueCart.Count<=MaxQueueLenght)
            {
                QueueCart.Enqueue(cart);
            }
            else
            {
                ExitCustomer++;
            }
        }
        
        public decimal Dequeue()
        {
           var sum = 0.0m;
           var card = QueueCart.Dequeue();

            if(card!=null)
            {
                var check = new Check()
                {
                    SellerId = Seller.SellerId,
                    Seller = Seller,
                    CustomerId = card.Customer.CustomerId,
                    Customer = card.Customer,
                    CreatedData = DateTime.Now,
                };

                if(!IsModel)
                {
                    context.Checks.Add(check);
                    context.SaveChanges();
                }
                else
                {
                    check.CheckId = 0;
                }

                var sells = new List<Sell>();

                foreach(Product product in card)
                {
                    if (product.Count > 0)
                    {
                        var sell = new Sell()
                        {
                            CheckId = check.CheckId,
                            Check = check,
                            ProductId = product.ProductId,
                            Product = product,
                        };

                        sells.Add(sell);

                        if (!IsModel)
                        {
                            context.Sells.Add(sell);
                        }

                        product.Count--;
                        sum += product.Price;
                    }
                }

                if (!IsModel)
                {
                    context.SaveChanges();
                }
            }
            return sum;
        }
    }
}
