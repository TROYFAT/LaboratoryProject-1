using LS.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Domain.Entities
{
    /// <summary>
    /// Накладная
    /// </summary>
    public class Invoice:Document
    {
        /// <summary>
        /// Общая сумма товаров по стоимости
        /// </summary>
        public int GeneralAmount { get; set; }
        /// <summary>
        /// Общая сумма товаров по кол-ву
        /// </summary>
        public int CountThings { get; set; }
        /// <summary>
        /// Номер накладной
        /// </summary>
        public int Number {  get; set; }
    }
}
