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
    public class ProductRepository : RepositoryBase<Product>
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext appContext) :
            base(appContext)
        {
            _context = appContext;
        }

        public IQueryable<Product> FindAllProducts()
        {
            return FindAll().Include(x => x.Sold);
        }
        public void UpdateStock(int productId, int Quantity)
        {
            var product = Find(productId);
            product.UnitsInStock = product.UnitsInStock - Quantity;
            _context.Update(product);
            _context.SaveChanges();
        }

        public void ModifyStock(int productId, int Quantity, int invoiceNo)
        {
            var product = Find(productId);
            var previousQuantity = product.Sold.Where(x => x.InvoiceId == invoiceNo).Sum(x => x.Quantity);
            product.UnitsInStock = product.UnitsInStock - (Quantity - previousQuantity);
            _context.Update(product);
            _context.SaveChanges();
        }
    }
}
