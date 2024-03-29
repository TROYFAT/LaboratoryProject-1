using LS.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Domain.Entities
{
    /// <summary>
    /// Класс, описывающий квитанцию
    /// </summary>
    public class Receipt:Document
    { 
        /// <summary>
        /// ИНН
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// Сумма
        /// </summary>
        public int Amount { get; set; }
        ///<summary>
        /// Получатель
        /// </summary>
        public string Recepient { get; set; } = string.Empty;
        ///<summary>
        /// Плательщик
        /// </summary>
        public string Payer { get; set; } = string.Empty;
    }
}
