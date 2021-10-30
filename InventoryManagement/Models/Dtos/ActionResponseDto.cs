using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class ActionResponseDto
    {
        public object result { get; set; }
        public bool Success { get; set; }
        public string message { get; set; }

    }
}
