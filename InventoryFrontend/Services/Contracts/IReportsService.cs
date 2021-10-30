using InventoryFrontend.Services;
using InventoryManagement.Models.Dtos;
using Pathoschild.Http.Client;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryFrontend.Services
{
    public interface IReportsService
    {
        FluentClient client { get; set; }
        ILocalStorageService storage { get; set; }

        Task<List<ProductSoldItemsResponse>> GetSoldItems();
        Task<List<StockVsSoldItemsResponse>> GeProductsVsStock();
        Task<ProductsSummaryReportResponse> GeProductsSummary();
    }
}