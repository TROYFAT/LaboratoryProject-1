using LS.Application.Common.Interfaces.Services.Base;
using LS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Application.Common.Interfaces.Services
{
    public interface IReceiptService:IBaseService<Receipt>
    {
         
        List<Receipt> GetList(string name);
    }
}
