using AutoMapper.Configuration.Annotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float SellingPrice { get; set; }
        public int UnitsInStock { get; set; } = 0;
        [ForeignKey("Item")]
        public List<SoldItems> Sold { get; set; }
    }
}
