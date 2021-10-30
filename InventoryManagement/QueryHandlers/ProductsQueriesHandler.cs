using AutoMapper;
using InventoryManagement.Models.Dtos;
using InventoryManagement.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.QueryHandlers
{
    public class ProductsQueriesHandler : IProductsQueriesHandler
    {
        private readonly ProductRepository _productRepo;
        private IMapper _mapper;
        public ProductsQueriesHandler(ProductRepository ProductRepo, IMapper mapper)
        {
            _productRepo = ProductRepo;
            _mapper = mapper;
        }

        public async Task<List<ProductQueryResponseDto>> GetProducts()
        {
            var products = await _productRepo.FindAll().ToListAsync();
            return _mapper.Map<List<ProductQueryResponseDto>>(products);
        }

        public ProductQueryResponseDto GetProductById(int id)
        {
            var product = _productRepo.Find(id);
            return _mapper.Map<ProductQueryResponseDto>(product);
        }

        public async Task<List<ProductSoldItemsResponse>> GetSoldProducts()
        {
            var products = await _productRepo.FindAllProducts().ToListAsync();
            var result = products.Select(x => new ProductSoldItemsResponse
            {
                ProductName = x.ProductName,
                SoldItems = x.Sold.Count()
            }).ToList();
            return result;
        }

        public async Task<ProductsSummaryReportResponse> GetProductsSummary()
        {
            var products = await _productRepo.FindAllProducts().ToListAsync();
            var result = new ProductsSummaryReportResponse
            {
                Products = products.Count(),
                SoldItems = products.Sum(x => x.Sold.Sum(x => x.Quantity)),
                ProductsInStock = products.Sum(x => x.UnitsInStock)
            };
            return result;
        }

        public async Task<List<StockVsSoldItemsResponse>> GetStockVsSoldItems()
        {
            var products = await _productRepo.FindAllProducts().ToListAsync();
            var result = products.Select(x => new StockVsSoldItemsResponse
            {
                ProductName = x.ProductName,
                UnitsInStock = products.Sum(x => x.UnitsInStock),
                SoldItems = x.Sold.Count()
            }).ToList();
            return result;
        }
    }
}
