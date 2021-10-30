using InventoryFrontend.Services;
using InventoryManagement.Models;
using InventoryManagement.Models.Dtos;
using Microsoft.Extensions.Configuration;
using Pathoschild.Http.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryFrontend.Services
{
    public class ReportsService : IReportsService
    {
        public FluentClient client { get; set; }
        public IConfiguration Configuration { get; }
        public ILocalStorageService storage { get; set; }

        public ReportsService(ILocalStorageService storage, IConfiguration configuration)
        {
            this.storage = storage;
            Configuration = configuration;
            client = new FluentClient(Configuration["BaseUrl"]);
        }

        public async Task<List<ProductSoldItemsResponse>> GetSoldItems()
        {
            string token = await storage.GetItem<string>("token");
            var result = await client.GetAsync("Reports/SoldItems")
                .WithBearerAuthentication(token)
                .As<List<ProductSoldItemsResponse>>();
            return result;
        }

        public async Task<ProductsSummaryReportResponse> GeProductsSummary()
        {
            string token = await storage.GetItem<string>("token");
            var result = await client.GetAsync($"Reports/ProductsSummary")
                .WithBearerAuthentication(token)
                .As<ProductsSummaryReportResponse>();
            return result;
        }
        public async Task<List<StockVsSoldItemsResponse>> GeProductsVsStock()
        {
            string token = await storage.GetItem<string>("token");
            var result = await client.GetAsync($"Reports/ProductsVsStock")
                .WithBearerAuthentication(token)
                .As<List<StockVsSoldItemsResponse>>();
            return result;
        }
    }
}
