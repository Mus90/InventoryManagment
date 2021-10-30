using InventoryManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.Dtos
{
    public class CreateInvoiceDto
    {
        public int Id { get; set; }
        public List<SoldItemsRequestDto> SoldItems { get; set; }
        public string CreatedBy { get; set; }
    }
}
