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
    public class ProductsService : IProductsService
    {
        public FluentClient client { get; set; }
        public ILocalStorageService storage { get; set; }
        public IConfiguration Configuration { get; }
        public ProductsService(ILocalStorageService storage, IConfiguration configuration)
        {
            this.storage = storage;
            Configuration = configuration;
            string url = Configuration["BaseUrl"];
            client = new FluentClient(Configuration["BaseUrl"]);
        }

        public async Task<List<ProductQueryResponseDto>> GetProducts()
        {
            string token = await storage.GetItem<string>("token");
            var result = await client.GetAsync("Products")
                .WithBearerAuthentication(token)
                .As<List<ProductQueryResponseDto>>();
            return result;
        }

        public async Task<ProductQueryResponseDto> GetProductById(int Id)
        {
            string token = await storage.GetItem<string>("token");
            var result = await client.GetAsync($"Products/{Id}")
                .WithBearerAuthentication(token)
                .As<ProductQueryResponseDto>();
            return result;
        }

        public async Task<ActionResponseDto> CreateProduct(CreateProductDto input)
        {
            string token = await storage.GetItem<string>("token");
            var result = await client.PostAsync($"Products").WithBody(input)
                .WithBearerAuthentication(token)
                .As<ActionResponseDto>();
            return result;
        }

        public async Task<ActionResponseDto> UpdateProduct(UpdateProductDto input)
        {
            string token = await storage.GetItem<string>("token");
            var result = await client.PutAsync($"Products").WithBody(input)
                .WithBearerAuthentication(token)
                .As<ActionResponseDto>();
            return result;
        }

        public async Task<ActionResponseDto> ReStock(ReStockProductRequestDto input)
        {
            string token = await storage.GetItem<string>("token");
            var result = await client.PutAsync($"Products/ReStock").WithBody(input)
                .WithBearerAuthentication(token)
                .As<ActionResponseDto>();
            return result;
        }

        public async Task<ActionResponseDto> DeleteProduct(int Id)
        {
            string token = await storage.GetItem<string>("token");
            var result = await client.DeleteAsync($"Products/{Id}")
                .WithBearerAuthentication(token)
                .As<ActionResponseDto>();
            return result;
        }
    }
}
