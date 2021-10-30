using InventoryFrontend.Services;
using InventoryManagement.Models;
using InventoryManagement.Models.Dtos;
using Pathoschild.Http.Client;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryFrontend.Services
{
    public interface IProductsService
    {
        FluentClient client { get; set; }
        ILocalStorageService storage { get; set; }

        Task<ActionResponseDto> CreateProduct(CreateProductDto input);
        Task<ActionResponseDto> DeleteProduct(int Id);
        Task<List<ProductQueryResponseDto>> GetProducts();
        Task<ProductQueryResponseDto> GetProductById(int Id);
        Task<ActionResponseDto> ReStock(ReStockProductRequestDto input);
        Task<ActionResponseDto> UpdateProduct(UpdateProductDto input);
    }
}