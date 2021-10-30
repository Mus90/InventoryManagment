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

namespace InventoryFrontend.Pages.Products
{
    public class RestockProductBase : ComponentBase
    {
        [Inject]
        protected IJSRuntime JsRuntime { get; set; }
        [Inject]
        protected IProductsService _client { get; set; }
        [Inject]
        protected NavigationManager navigationManager { get; set; }
        [Inject]
        protected IMapper _mapper { get; set; }
        public ReStockProductRequestDto product { get; set; }
        [Parameter]
        public string id { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            product = _mapper.Map< ReStockProductRequestDto>(await _client.GetProductById(int.Parse(id)));

        }



        protected async Task HandleValidSubmit()
        {
            ActionResponseDto result;
            result = await _client.ReStock(product);
            navigationManager.NavigateTo("ProductsList");
        }

    }
}
