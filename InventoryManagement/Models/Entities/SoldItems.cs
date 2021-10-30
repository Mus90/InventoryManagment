using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.Entities
{
    public class SoldItems
    {
        public int Id { get; set; }
        public int Item { get; set; }
        public int Quantity { get; set; }
        public float Total { get; set; }
        public int InvoiceId { get; set; }
    }
}
