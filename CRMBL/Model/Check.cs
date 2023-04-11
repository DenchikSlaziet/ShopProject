using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Model
{
    /// <summary>
    /// Сущность чека
    /// </summary>
    public class Check
    {
        /// <summary>
        /// Id
        /// </summary>
        public int CheckId { get; set; }

        /// <summary>
        /// Id покупателя
        /// </summary>
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// Id продавца
        /// </summary>
        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }

        /// <summary>
        /// Дата создания чека
        /// </summary>
        public DateTime CreatedData { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        /// <summary>
        /// Сумма чека
        /// </summary>
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"№{CheckId} от {CreatedData.ToString("dd.MM.yy hh.mm.ss")}";
        }
    }
}
