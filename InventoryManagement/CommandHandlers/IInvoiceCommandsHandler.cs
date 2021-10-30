using InventoryManagement.Models;
using InventoryManagement.Models.Dtos;
using System.Threading.Tasks;

namespace InventoryManagement.CommandHandlers
{
    public interface IInvoiceCommandsHandler
    {
        Task<InvoiceToPrintDto> CreateInvoice(CreateInvoiceDto input);
        Task<ActionResponseDto> DeleteInvoice(int Id);
        Task<ActionResponseDto> UpdateInvoice(UpdateInvoiceDto input);
    }
}