using InventoryFrontend.Services;
using InventoryManagement.Models;
using InventoryManagement.Models.Dtos;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryFrontend.Pages.Account
{
    public class LoginBase : ComponentBase
    {
        [Inject]
        public NavigationManager navManager { get; set; }

        [Inject]
        public IAccountService appClient { get; set; }
        [Inject]
        public ILocalStorageService _storage { get; set; }
        [Inject]
        public AuthenticationStateProvider authenticationStateProvider { get; set; }
        [Inject]
        public NavigationManager _navManager { get; set; }

        public AuthenticateRequestDto request = new AuthenticateRequestDto();
        protected async Task OnSubmitClick()
        {
            AuthenticateResponse response = await appClient.SignIn(request);
            if (response.Token != null)
            {
                await _storage.SetItem<string>("token", response.Token);
                await _storage.SetItem<IList<string>>("Roles", response.Roles);
                ((CustomAuthenticationStateProvider)authenticationStateProvider).MarkUserAsAuthenticated(response);
                _navManager.NavigateTo("/ProductsList", true);
            }

        }
    }
}
