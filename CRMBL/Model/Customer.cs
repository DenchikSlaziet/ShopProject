using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Model
{
    /// <summary>
    /// Сущность покупателя
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Id
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Имя покупателя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Номер карты покупателя
        /// </summary>
        public string NumberCard { get; set; }

        public virtual ICollection<Check> Checks { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
