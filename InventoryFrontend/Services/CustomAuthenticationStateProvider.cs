
using InventoryManagement.Models.Dtos;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InventoryFrontend.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        public ILocalStorageService _storage { get; set; }
        protected ClaimsIdentity identity;
        public CustomAuthenticationStateProvider(ILocalStorageService storage)
        {
            _storage = storage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var token = await _storage.GetItem<string>("token");
                if (token != null)
                {
                    identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name,token),}, "apiAuthType");
                    foreach (var role in await _storage.GetItem<string[]>("Roles"))
                    {
                        identity.AddClaim(new Claim(ClaimTypes.Role, role));
                    }
                }
                else
                {
                    identity = new ClaimsIdentity();
                }

                

                var user = new ClaimsPrincipal(identity);
                return await Task.FromResult(new AuthenticationState(user));
            }
            catch (System.Exception e)
            {
                identity = new ClaimsIdentity();
                var user = new ClaimsPrincipal(identity);
                return await Task.FromResult(new AuthenticationState(user));
            }

        }

        public void MarkUserAsAuthenticated(AuthenticateResponse response)
        {
            identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, response.Token), }, "apiAuthType");
            foreach (var role in response.Roles)
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, role));
            }

           

            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }



        public void MarkUserAsLoggedOut()
        {
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
