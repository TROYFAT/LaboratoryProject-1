using LS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Presentation.Utilities
{
    public static class InvoiceUtilities
    {
        public static Invoice Create(string name)
        {
            return new Domain.Entities.Invoice()
            {
                Pages = 1,
                Font = 16,
                CountThings = 14,
                GeneralAmount = 30000,
                Id = Guid.NewGuid(),
                Title = name
            };
        }
    }
}