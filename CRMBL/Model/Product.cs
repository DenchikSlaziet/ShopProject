using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Model
{
    /// <summary>
    /// Сущность продукта
    /// </summary>
    public class Product
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Наиминование продукта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Цена продукта
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Кол-во продукта
        /// </summary>
        public int Count { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price} руб.";
        }

        public override int GetHashCode()
        {
            return ProductId;
        }

        public override bool Equals(object obj)
        {
            if (obj is Product product)
            {
                return ProductId.Equals(product.ProductId);
            }
            return false;
        }
    }
}
