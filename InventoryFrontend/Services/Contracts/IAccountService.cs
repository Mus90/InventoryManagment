using InventoryFrontend.Services;
using InventoryManagement.Models;
using InventoryManagement.Models.Dtos;
using Pathoschild.Http.Client;
using System.Threading.Tasks;

namespace InventoryFrontend.Services
{
    public interface IAccountService
    {
        FluentClient client { get; set; }
        ILocalStorageService storage { get; set; }

        Task<ActionResponseDto> CreateUser(CreateUserDto request);
        Task<AuthenticateResponse> SignIn(AuthenticateRequestDto request);
    }
}