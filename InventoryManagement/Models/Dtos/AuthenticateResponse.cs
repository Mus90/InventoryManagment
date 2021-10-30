using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models.Dtos
{
    public class AuthenticateResponse
    {
        public string Token { get; set; }
        public IList<string> Roles { get; set; }
    }
}
