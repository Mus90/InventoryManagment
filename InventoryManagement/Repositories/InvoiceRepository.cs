using InventoryManagement.Data;
using InventoryManagement.Models;
using InventoryManagement.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        internal List<Invoice> getAllInvoices()
        {
            return _context.Invoices.Include(x => x.Items).ToList();
        }
    }
}

