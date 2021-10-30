using InventoryFrontend.Services;
using InventoryManagement.Models;
using InventoryManagement.Models.Dtos;
using Microsoft.Extensions.Configuration;
using Pathoschild.Http.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryFrontend.Services
{
    public class AccountService : IAccountService
    {
        public FluentClient client { get; set; }
        public ILocalStorageService storage { get; set; }
        public IConfiguration Configuration { get; }
        public AccountService(ILocalStorageService storage, IConfiguration configuration)
        {
            this.storage = storage;
            Configuration = configuration;
            client = new FluentClient(Configuration["BaseUrl"]);
        }

        public async Task<ActionResponseDto> CreateUser(CreateUserDto request)
        {
            var result = await client.PostAsync("Account/CreateUser").WithBody(request).As<ActionResponseDto>();
            return result;
        }

        public async Task<AuthenticateResponse> SignIn(AuthenticateRequestDto request)
        {
            var result = await client.PostAsync("Account/Authenticate").WithBody(request).As<AuthenticateResponse>();
            await storage.SetItem<string>("Token", result.Token);
            await storage.SetItem<IList<string>>("Roles", result.Roles);
            return result;
        }

    }
}
