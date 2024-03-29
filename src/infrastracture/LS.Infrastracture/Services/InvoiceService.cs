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
    public class InvoiceService : BaseService<Invoice>,
        IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        public InvoiceService(IInvoiceRepository invoiceRepository)
            : base(invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        public List<Invoice> GetList(string name)
        {
            return _invoiceRepository.
                GetList(name);
        }
    }
}
