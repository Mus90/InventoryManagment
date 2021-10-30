using AutoMapper;
using InventoryManagement.Models.Dtos;
using InventoryManagement.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.QueryHandlers
{
    public class InvoiceQueriesHandler : IInvoiceQueriesHandler
    {
        private readonly InvoiceRepository _invoiceRepo;
        private IMapper _mapper;
        public InvoiceQueriesHandler(InvoiceRepository invoiceRepo, IMapper mapper)
        {
            _invoiceRepo = invoiceRepo;
            _mapper = mapper;
        }

        public async Task<List<InvoiceQueryResponseDto>> GetInvoices()
        {
            var invoices = await _invoiceRepo.FindAll().ToListAsync();
            return _mapper.Map<List<InvoiceQueryResponseDto>>(invoices);
        }

        public InvoiceQueryResponseDto GetInvoiceById(int id)
        {
            var invoice = _invoiceRepo.Find(id);
            return _mapper.Map<InvoiceQueryResponseDto>(invoice);
        }
    }
}
