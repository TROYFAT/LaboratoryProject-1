using LS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Presentation.Utilities
{
    public static class ReceiptUtilities
    {
        public static Receipt Create(string name)
        {
            return     new Domain.Entities.Receipt()
            {
                Pages = 2,
                Font = 14,
                Code = 894832952,
                Amount = 4500,
                Recepient = "Darya",
                Payer = "Mikhail",
                Id = Guid.NewGuid(),
                Title = name
            };
        }
    }
}
