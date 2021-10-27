using InventoryManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagement.Models.Dtos
{
    public class InvoiceQueryResponseDto
    {
        public int Id { get; set; }
        public List<SoldItems> Items { get; set; }
        public int Total
        {
            get
            {
                return this.Total;
            }
            set
            {
                int.Parse(Items.Sum(x => x.Total).ToString());
            }
        }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
    }
}
