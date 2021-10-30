﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.Dtos
{
    public class ProductQueryResponseDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float SellingPrice { get; set; }
        public int UnitsInStock { get; set; } = 0;
    }
}
