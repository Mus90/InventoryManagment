using InventoryFrontend.Services;
using InventoryManagement.Models.Dtos;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryFrontend.Pages.Reports
{
    public class SummaryReportBase : ComponentBase
    {
        [Inject]
        public NavigationManager navManager { get; set; }
        [Inject]
        public IReportsService _client { get; set; }
        public bool isDataReady = false;
        public ProductsSummaryReportResponse product = new ProductsSummaryReportResponse();



        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!isDataReady)
            {
                product = await _client.GeProductsSummary();
                isDataReady = true;
                StateHasChanged();
            }
        }

    }
}
