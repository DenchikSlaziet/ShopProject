using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Model
{
    /// <summary>
    /// Сущность продажи
    /// </summary>
    public class Sell
    {
        /// <summary>
        /// Id
        /// </summary>
        public int SellId { get; set; }

        /// <summary>
        /// Id чека
        /// </summary>
        public int CheckId { get; set; }
        public virtual Check Check { get; set; }

        /// <summary>
        /// Id продукта
        /// </summary>
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
