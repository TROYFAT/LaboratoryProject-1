using LS.Application.Common.Interfaces.Repositories.Base;
using LS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Application.Common.Interfaces.Repositories
{
    public interface IInvoiceRepository: IBaseRepository<Invoice>
    {
        List<Invoice> GetList(string name);
    }
}
