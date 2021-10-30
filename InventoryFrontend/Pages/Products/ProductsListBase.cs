using InventoryFrontend.Services;
using InventoryManagement.Models.Dtos;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryFrontend.Pages.Products
{
    public class ProductsListBase : ComponentBase
    {
        [Inject]
        public NavigationManager navManager { get; set; }
        [Inject]
        public IProductsService _client { get; set; }
        public bool isDataReady = false;
        public List<ProductQueryResponseDto> products = new List<ProductQueryResponseDto>();

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!isDataReady)
            {
                products = await _client.GetProducts();
                isDataReady = true;
                StateHasChanged();
            }
        }

        protected async Task DeleteProduct(int productId)
        {
            var result = await _client.DeleteProduct(productId);
            products = await _client.GetProducts();

        }
    }
}
