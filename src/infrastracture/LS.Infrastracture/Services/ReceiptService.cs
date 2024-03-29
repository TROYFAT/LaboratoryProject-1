using LS.Application.Common.Interfaces.Repositories;
using LS.Application.Common.Interfaces.Services;
using LS.Domain.Entities;
using LS.Infrastracture.Services.Base;
using System;
using System.Collections.Generic;
 using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LS.Infrastracture.Services
{
    public class ReceiptService :BaseService<Receipt>,
        IReceiptService
    {
        private readonly IReceiptRepository _receiptRepository;
        public ReceiptService(IReceiptRepository receiptRepository)
            :base(receiptRepository)
        {
            _receiptRepository= receiptRepository;
        }       
        public List<Receipt> GetList(string name)
        {
            return _receiptRepository.
                GetList(name);
        }
    }
}
