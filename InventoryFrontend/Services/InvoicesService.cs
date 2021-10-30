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
    public class InvoicesService : IInvoicesService
    {
        public FluentClient client { get; set; }
        public ILocalStorageService storage { get; set; }
        public IConfiguration Configuration { get; }
        public InvoicesService(ILocalStorageService storage, IConfiguration configuration)
        {
            this.storage = storage;
            Configuration = configuration;
            client = new FluentClient(Configuration["BaseUrl"]);
        }

        public async Task<List<InvoiceQueryResponseDto>> GetInvoices()
        {
            string token = await storage.GetItem<string>("token");
            try
            {
                await client.GetAsync("Invoices")
                .WithBearerAuthentication(token)
                .As<List<InvoiceQueryResponseDto>>();
            }
            catch(Exception e)
            {
                string ss = "";
            }
            var result = await client.GetAsync("Invoices")
                .WithBearerAuthentication(token)
                .As<List<InvoiceQueryResponseDto>>();
            return result;
        }
        
        public async Task<InvoiceQueryResponseDto> GetInvoiceById(int Id)
        {
            string token = await storage.GetItem<string>("token");
            var result = await client.GetAsync($"Invoices/{Id}")
                .WithBearerAuthentication(token)
                .As<InvoiceQueryResponseDto>();
            return result;
        }

        public async Task<ActionResponseDto> CreateInvoice(CreateInvoiceDto input)
        {
            string token = await storage.GetItem<string>("token");
            var result = await client.PostAsync($"Invoices").WithBody(input)
                .WithBearerAuthentication(token)
                .As<ActionResponseDto>();
            return result;
        }

        public async Task<ActionResponseDto> UpdateInvoice(UpdateInvoiceDto input)
        {
            string token = await storage.GetItem<string>("token");
            var result = await client.PutAsync($"Invoices").WithBody(input)
                .WithBearerAuthentication(token)
                .As<ActionResponseDto>();
            return result;
        }

        public async Task<ActionResponseDto> DeleteInvoice(int Id)
        {
            string token = await storage.GetItem<string>("token");
            var result = await client.DeleteAsync($"Invoices/{Id}")
                .WithBearerAuthentication(token)
                .As<ActionResponseDto>();
            return result;
        }

        
    }
}
