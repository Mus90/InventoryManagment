using InventoryManagement.Data;
using InventoryManagement.Models;
using InventoryManagement.Models.Entities;
using System;
using System.Threading.Tasks;

namespace InventoryManagement.Repositories
{
    public class InvoiceRepository : RepositoryBase<Invoice>
    {
        private readonly ApplicationDbContext _context;
        public InvoiceRepository(ApplicationDbContext appContext) :
            base(appContext)
        {
            _context = appContext;
        }
    }
}
