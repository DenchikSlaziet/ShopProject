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
        private MyDbContext context;

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
        public int MaxQueueLength { get; set; }

        /// <summary>
        /// Счетчик ушедших покупателей
        /// </summary>
        public int ExitCustomer { get; set; }

        /// <summary>
        /// Переключатель моделирования
        /// </summary>
        public bool IsModel { get; set; }

        public event EventHandler<Check> CheckClosed;

        /// <summary>
        /// Длинна очереди
        /// </summary>
        public int Count =>QueueCart.Count;

        public CashDesk(int number,Seller seller,MyDbContext context)
        {
            this.context = context ?? new MyDbContext();
            QueueCart = new Queue<Cart>();
            IsModel = true;
            MaxQueueLength = 10;

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
            if(cart!=null && QueueCart.Count<=MaxQueueLength)
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
           if(QueueCart.Count ==0)
           {
               return 0m;
           }
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
                check.Price = sum;

                if (!IsModel)
                {
                    context.Customers.Remove(card.Customer);
                    context.SaveChanges();
                }

                CheckClosed?.Invoke(this, check);
            }
            return sum;
        }

        public override string ToString()
        {
            return $"Касса№{Number}";
        }
    }
}
