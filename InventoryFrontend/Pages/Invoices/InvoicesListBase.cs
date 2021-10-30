using InventoryFrontend.Services;
using InventoryManagement.Models.Dtos;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryFrontend.Pages.Invoices
{
    public class InvoicesListBase : ComponentBase
    {
        [Inject]
        public NavigationManager navManager { get; set; }
        [Inject]
        public IInvoicesService _client { get; set; }
        public bool isDataReady = false;
        public List<InvoiceQueryResponseDto> invoices = new List<InvoiceQueryResponseDto>();


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!isDataReady)
            {
                invoices = await _client.GetInvoices();
                isDataReady = true;
                StateHasChanged();
            }
        }

        protected async Task DeleteProduct(int productId)
        {
            var result = await _client.DeleteInvoice(productId);
            invoices = await _client.GetInvoices();
        }
    }
}
