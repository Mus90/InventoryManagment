using InventoryManagement.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryManagement.QueryHandlers
{
    public interface IProductsQueriesHandler
    {
        ProductQueryResponseDto GetProductById(int id);
        Task<List<ProductQueryResponseDto>> GetProducts();
        Task<ProductsSummaryReportResponse> GetProductsSummary();
        Task<List<ProductSoldItemsResponse>> GetSoldProducts();
        Task<List<StockVsSoldItemsResponse>> GetStockVsSoldItems();
    }
}