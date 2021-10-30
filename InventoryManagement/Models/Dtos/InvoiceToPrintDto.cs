using InventoryManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.Dtos
{
    public class InvoiceToPrintDto
    {
        public int Id { get; set; }
        public List<SoldItems> Items { get; set; }
        public float Total { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
    }

}
