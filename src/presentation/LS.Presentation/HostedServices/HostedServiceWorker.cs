using LS.Application.Common.Interfaces.Services;
using LS.Domain.Entities;
using LS.Infrastracture.Services;
using LS.Presentation.Utilities;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Presentation.HostedServices
{
    public class HostedServiceWorker : IHostedService
    {
        private readonly IReceiptService _receiptService;
        private readonly IInvoiceService _invoiceService;
  
        public HostedServiceWorker(IReceiptService receiptService, IInvoiceService invoiceService)
        {
            _receiptService = receiptService;
            _invoiceService = invoiceService;
        }        
        public async Task StartAsync(CancellationToken cancellationToken)
        {  
            await BuildMenu(); 
        }
        private async Task BuildMenu()
        {
            List<Receipt> ReceiptsList = new List<Receipt>();
            List<Invoice> InvoicesList = new List<Invoice>();
            Console.WriteLine("Выберите тип документов, с которыми будете работать:");
            Console.WriteLine("1 - Квитанции");
            Console.WriteLine("2 - Накладные");
            var key = Console.ReadKey();
            Console.Clear();
            switch (key.KeyChar)
            {
                case '1':
                    while (true)
                    {
                        Console.WriteLine("Выберите пункт меню для начала:");
                        Console.WriteLine("1 - Добавить объект");
                        Console.WriteLine("2 - Получить объект");
                        Console.WriteLine("3 - Сохранить список");
                        Console.WriteLine("4 - Получить список");
                        var key2 = Console.ReadKey();
                        Console.Clear();
                        switch (key2.KeyChar)
                        {
                            case '1':
                                Console.WriteLine("Укажите имя объекта: ");
                                var newRec = ReceiptUtilities.Create(Console.ReadLine() ?? "");
                                Console.WriteLine($"Создан документ Id: {newRec.Id}, Name= {newRec.Title}");
                                _receiptService.Add(newRec);
                                ReceiptsList.Add(newRec);
                                //var rectStr = _rectangleService.SerializeToString(newRect);
                                //Console.WriteLine(rectStr);
                                //await _receiptService.SerializeToFile(newRect, "receipt.txt");
                                //var getRec = _receiptService.DeserializeFromString(recStr);
                                break;
                            case '2':
                                Console.WriteLine("Пожалуйста, введите имя объекта:");

                                var resultList = _receiptService.GetList(Console.ReadLine() ?? "");
                                resultList.ForEach(receipt => Console.WriteLine($"Документ - {receipt.Title}"));
                                if (resultList.Count > 0)
                                {
                                    _receiptService.GetById(resultList[0].Id);
                                }
                                break;
                            case '3':
                                await _receiptService.SerializeToFile(ReceiptsList, "receiptsList.txt");

                                break;
                            case '4':
                                ReceiptsList = await _receiptService.
                                    DeserializeFromFile("receiptsList.txt") ?? new List<Receipt>();
                                ReceiptsList.ForEach(receipt => Console.WriteLine(receipt.Title));
                                break;
                            default:
                                break;

                        }
                    }
                case '2':
                    while (true)
                    {
                        Console.WriteLine("Выберите пункт меню для начала:");
                        Console.WriteLine("1 - Добавить объект");
                        Console.WriteLine("2 - Получить объект");
                        Console.WriteLine("3 - Сохранить список");
                        Console.WriteLine("4 - Получить список");
                        var key2 = Console.ReadKey();
                        Console.Clear();
                        switch (key2.KeyChar)
                        {
                            case '1':
                                Console.WriteLine("Укажите имя объекта: ");
                                var newInv = InvoiceUtilities.Create(Console.ReadLine() ?? "");
                                Console.WriteLine($"Создан документ Id: {newInv.Id}, Name= {newInv.Title}");
                                _invoiceService.Add(newInv);
                                InvoicesList.Add(newInv);
                                //var rectStr = _invoiceService.SerializeToString(newInv);
                                //Console.WriteLine(rectStr);
                                //await _invoiceService.SerializeToFile(newInv, "invoice.txt");
                                //var getInv = _invoiceService.DeserializeFromString(recStr);
                                break;
                            case '2':
                                Console.WriteLine("Пожалуйста, введите имя объекта:");

                                var resultList = _invoiceService.GetList(Console.ReadLine() ?? "");
                                resultList.ForEach(invoice => Console.WriteLine($"Документ - {invoice.Title}"));
                                if (resultList.Count > 0)
                                {
                                    _invoiceService.GetById(resultList[0].Id);
                                }
                                break;
                            case '3':
                                await _invoiceService.SerializeToFile(InvoicesList, "invoicesList.txt");

                                break;
                            case '4':
                                InvoicesList = await _invoiceService.
                                    DeserializeFromFile("invoicesList.txt") ?? new List<Invoice>();
                                InvoicesList.ForEach(invoice => Console.WriteLine(invoice.Title));
                                break;
                            default:
                                break;

                        }
                    }
                default:
                    break;
            }
        }

    public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.Delay(1);
        }
}
}
