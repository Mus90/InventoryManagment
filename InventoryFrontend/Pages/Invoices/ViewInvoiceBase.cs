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
    public class ViewInvoiceBase : ComponentBase
    {

        [Inject]
        protected IJSRuntime JsRuntime { get; set; }
        [Inject]
        protected IInvoicesService _client { get; set; }
        [Inject]
        public IProductsService _productsclient { get; set; }
        [Inject]
        protected NavigationManager navigationManager { get; set; }
        [Inject]
        protected IMapper _mapper { get; set; }
        public UpdateInvoiceDto invoice { get; set; }
        public List<SoldItemsRequestDto> items;
        public List<ProductQueryResponseDto> products;
        public SoldItemsRequestDto Currentitem = new SoldItemsRequestDto();
        public float totalSelectedItems = 0;
        public bool isDataReady = false;
        [Parameter]
        public string id { get; set; }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!isDataReady)
            {
                invoice = _mapper.Map<UpdateInvoiceDto>(await _client.GetInvoiceById(int.Parse(id)));
                products = await _productsclient.GetProducts();
                isDataReady = true;
                StateHasChanged();
            }
        }
        protected async Task AddItemToCart()
        {
            if (Currentitem.ProductId != null && Currentitem.Quantity != null)
            {
                items.Add(Currentitem);
                Currentitem = new SoldItemsRequestDto();
            }

        }


        protected async Task HandleValidSubmit()
        {
            ActionResponseDto result;
            result = await _client.UpdateInvoice(invoice);
            navigationManager.NavigateTo("InvoicesList");
        }

        protected async Task getTotalPrice()
        {
            totalSelectedItems = products.Where(x => items.Select(x => x.ProductId).Contains(x.Id)).Sum(x => x.SellingPrice);
        }

    }
}
