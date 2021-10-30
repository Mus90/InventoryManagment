using InventoryFrontend.Services;
using InventoryManagement.Models;
using InventoryManagement.Models.Dtos;
using Pathoschild.Http.Client;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryFrontend.Services
{
    public interface IInvoicesService
    {
        FluentClient client { get; set; }
        ILocalStorageService storage { get; set; }

        Task<ActionResponseDto> CreateInvoice(CreateInvoiceDto input);
        Task<ActionResponseDto> DeleteInvoice(int Id);
        Task<List<InvoiceQueryResponseDto>> GetInvoices();
        Task<InvoiceQueryResponseDto> GetInvoiceById(int Id);
        Task<ActionResponseDto> UpdateInvoice(UpdateInvoiceDto input);
    }
}