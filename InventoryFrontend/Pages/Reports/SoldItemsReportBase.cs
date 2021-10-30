using InventoryFrontend.Services;
using InventoryManagement.Models.Dtos;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryFrontend.Pages.Reports
{
    public class SoldItemsReportBase : ComponentBase
    {
        [Inject]
        public NavigationManager navManager { get; set; }
        [Inject]
        public IReportsService _client { get; set; }
        public bool isDataReady = false;
        public List<ProductSoldItemsResponse> products = new List<ProductSoldItemsResponse>();


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!isDataReady)
            {
                products = await _client.GetSoldItems();
                isDataReady = true;
                StateHasChanged();
            }
        }

    }
}
