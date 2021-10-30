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
    public class CreateProductBase : ComponentBase
    {
        
        [Inject]
        protected IJSRuntime JsRuntime { get; set; }
        [Inject]
        protected IProductsService _client { get; set; }
        [Inject]
        protected NavigationManager navigationManager { get; set; }
        public CreateProductDto product { get; set; }
        
        

        protected override async Task OnInitializedAsync()
        {
            product = new CreateProductDto();
        }



        protected async Task HandleValidSubmit()
        {
            ActionResponseDto result;
            result = await _client.CreateProduct(product);
            navigationManager.NavigateTo("ProductsList");
        }

    }
}
