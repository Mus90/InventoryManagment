using AutoMapper;
using InventoryManagement.Models;
using InventoryManagement.Models.Dtos;
using InventoryManagement.Models.Entities;
using InventoryManagement.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.CommandHandlers
{
    public class InvoiceCommandsHandler : IInvoiceCommandsHandler
    {
        private readonly InvoiceRepository _invoiceRepo;
        private readonly ProductRepository _productRepo;

        private IMapper _mapper;
        public InvoiceCommandsHandler(InvoiceRepository invoiceRepo, IMapper mapper, ProductRepository productRepo)
        {
            _invoiceRepo = invoiceRepo;
            _mapper = mapper;
            _productRepo = productRepo;
        }

        public async Task<InvoiceToPrintDto> CreateInvoice(CreateInvoiceDto input)
        {
            var soldItems = new List<SoldItems>();
            foreach (var item in input.SoldItems)
            {
                _productRepo.UpdateStock(item.ProductId, item.Quantity);
                soldItems.Add(InitSoldItem(item));
            }

            Invoice invoice = new Invoice
            {
                Items = soldItems,
                Total = soldItems.Sum(x => x.Total),
                CreatedBy = input.CreatedBy
            };
            await _invoiceRepo.CreateAsync(invoice);
            return _mapper.Map<InvoiceToPrintDto>(invoice);
        }


        private SoldItems InitSoldItem(SoldItemsRequestDto item)
        {
            var product = _productRepo.Find(item.ProductId);
            return new SoldItems
            {
                Item = product.Id,
                Quantity = item.Quantity,
                Total = product.SellingPrice * item.Quantity
            };
        }
        public async Task<ActionResponseDto> UpdateInvoice(UpdateInvoiceDto input)
        {
            var invoice = _invoiceRepo.Find(input.Id);
            var mapped = _mapper.Map(input, invoice);
            var soldItems = new List<SoldItems>();
            foreach (var item in input.SoldItems)
            {
                _productRepo.ModifyStock(item.ProductId, item.Quantity, invoice.Id);
                soldItems.Add(InitSoldItem(item));
            }

            invoice.Items = soldItems;
            invoice.Total = soldItems.Sum(x => x.Total);

            await _invoiceRepo.UpdateAsync(invoice);
            var result = await _invoiceRepo.UpdateAsync(mapped);
            return result;

        }

        public async Task<ActionResponseDto> DeleteInvoice(int Id)
        {
            var invoice = _invoiceRepo.Find(Id);
            var result = await _invoiceRepo.RemoveAsync(invoice);
            return result;
        }

    }
}
