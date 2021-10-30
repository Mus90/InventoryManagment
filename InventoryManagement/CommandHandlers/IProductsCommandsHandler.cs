using InventoryManagement.Models;
using InventoryManagement.Models.Dtos;
using System.Threading.Tasks;

namespace InventoryManagement.CommandHandlers
{
    public interface IProductsCommandsHandler
    {
        Task<ActionResponseDto> CreateProduct(CreateProductDto input);
        Task<ActionResponseDto> DeleteProduct(int Id);
        Task<ActionResponseDto> RestockProduct(int productId, int quantity);
        Task<ActionResponseDto> UpdateProduct(UpdateProductDto input);
    }
}