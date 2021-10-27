using System.Collections.Generic;

namespace InventoryManagement.Models.Dtos
{
    public class UpdateInvoiceDto
    {
        public int Id { get; set; }
        public List<SoldItemsRequestDto> SoldItems { get; set; }
    }
}
