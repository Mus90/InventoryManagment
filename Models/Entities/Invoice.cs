using InventoryManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace InventoryManagement.Models.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        [ForeignKey("InvoiceId")]
        public List<SoldItems> Items { get; set; }
        public float Total { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
    }
}
