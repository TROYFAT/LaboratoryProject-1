using LS.Application.Common.Interfaces.Repositories;
using LS.Application.Common.Interfaces.Services;
using LS.Infrastracture.Persistence.Repositories;
using LS.Infrastracture.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LS.Infrastracture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastracture
            (this IServiceCollection services)
        {
            services.AddScoped<IReceiptRepository, ReceiptRepository>();
            services.AddScoped<IReceiptService, ReceiptService>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IInvoiceService, InvoiceService>();
            return services;

        }

    }
}
