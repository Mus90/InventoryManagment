using AutoMapper;
using InventoryFrontend.Services;
using InventoryManagement.Models;
using InventoryManagement.Models.Dtos;
using InventoryManagement.Models.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryFrontend.Pages.Invoices
{
    public class CreateInvoiceBase : ComponentBase
    {
        
        [Inject]
        protected IJSRuntime JsRuntime { get; set; }
        [Inject]
        protected IInvoicesService _client { get; set; }
        [Inject]
        public IProductsService _productsclient { get; set; }
        [Inject]
        protected NavigationManager navigationManager { get; set; }
        public CreateInvoiceDto invoice { get; set; }
        public List<SoldItemsRequestDto> items = new List<SoldItemsRequestDto>();
        public List<ProductQueryResponseDto> products;
        public SoldItemsRequestDto Currentitem = new SoldItemsRequestDto();
        public float totalSelectedItems = 0;
        public bool isDataReady = false;
        protected override async Task OnInitializedAsync()
        {
            
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!isDataReady)
            {
                invoice = new CreateInvoiceDto();
                products = await _productsclient.GetProducts();
                isDataReady = true;
                StateHasChanged();
            }
        }
        protected async Task AddItemToCart()
        {
            if (Currentitem.ProductId != 0 && Currentitem.Quantity != 0)
            {
                items.Add(Currentitem);
                Currentitem = new SoldItemsRequestDto();
            }
            
        }


        protected async Task HandleValidSubmit()
        {
            ActionResponseDto result;
            invoice.SoldItems = items;
            result = await _client.CreateInvoice(invoice);
            navigationManager.NavigateTo("InvoicesList");
        }
        
        protected void getTotalPrice()
        {
            totalSelectedItems = products.Where(x => items.Select(x => x.ProductId).Contains(x.Id)).Sum(x=>x.SellingPrice);
        }
        
    }
}
