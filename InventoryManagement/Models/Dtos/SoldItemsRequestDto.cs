using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.Dtos
{
    public class SoldItemsRequestDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
