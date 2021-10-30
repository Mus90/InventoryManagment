using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.Dtos
{
    public class ProductSoldItemsResponse
    {
        public string ProductName { get; set; }
        public float SoldItems { get; set; }
    }

}
