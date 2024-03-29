using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Domain.Entities.Base
{
    /// <summary>
    /// Базовый класс документа
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Размер шрифта
        /// </summary>
        public int Font { get; set; }
        /// <summary>
        /// Кол-во страниц
        /// </summary>
        public int Pages { get; set; }
        /// <summary>
        /// Название документа
        /// </summary>
        public string Title { get; set; } = string.Empty; 
    }
}
