using InventoryManagement.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryManagement.QueryHandlers
{
    public interface IInvoiceQueriesHandler
    {
        InvoiceQueryResponseDto GetInvoiceById(int id);
        Task<List<InvoiceQueryResponseDto>> GetInvoices();
    }
}