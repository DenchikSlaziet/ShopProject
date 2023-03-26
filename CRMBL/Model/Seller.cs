using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBL.Model
{
    /// <summary>
    /// Сущность продавца
    /// </summary>
    public class Seller
    {
        /// <summary>
        /// Id
        /// </summary>
        public int SellerId { get; set; }

        /// <summary>
        /// Имя продавца
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фаилия продавца
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Возраст продавца
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Компания продавца
        /// </summary>
        public string CompanySeller { get; set; }

        public virtual ICollection<Check> Checks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
