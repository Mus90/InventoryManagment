using InventoryManagement.Data;
using InventoryManagement.Models;
using InventoryManagement.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryManagement.Services
{
    public class Functional : IFunctional
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private readonly SuperAdminDefaultOptions _superAdminDefaultOptions;

        public Functional(UserManager<ApplicationUser> userManager,
           RoleManager<IdentityRole> roleManager,
           ApplicationDbContext context,
           IOptions<SuperAdminDefaultOptions> superAdminDefaultOptions)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
            _superAdminDefaultOptions = superAdminDefaultOptions.Value;
        }



        public async Task InitAppData()
        {
            try
            {
                // Seed Products
                List<Product> products = new List<Product>() {
                    new Product{ProductName = "Laptop",SellingPrice=21000,UnitsInStock=35},
                    new Product{ProductName = "Mouse",SellingPrice=1000,UnitsInStock=243},
                    new Product{ProductName = "Keyboard",SellingPrice=500,UnitsInStock=154},
                    new Product{ProductName = "Monitor",SellingPrice=6000,UnitsInStock=72},
                    new Product{ProductName = "Desktop",SellingPrice=12000,UnitsInStock=61}
                };
                await _context.Products.AddRangeAsync(products);
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {
                throw;
            }
        }

        

        public async Task GenerateRoles()
        {
            try
            {
                // Seed Roles
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
                await _roleManager.CreateAsync(new IdentityRole("User"));
                await _roleManager.CreateAsync(new IdentityRole("Manager"));
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task CreateDefaultSuperAdmin()
        {
            try
            {
                ApplicationUser superAdmin = new ApplicationUser();
                superAdmin.Email = _superAdminDefaultOptions.Email;
                superAdmin.UserName = _superAdminDefaultOptions.UserName;
                superAdmin.EmailConfirmed = true;

                var result = await _userManager.CreateAsync(superAdmin, _superAdminDefaultOptions.Password);

                if (result.Succeeded)
                {
                    //add to super admin to all Roles
                    var roles = _roleManager.Roles;
                    List<string> listRoles = new List<string>();
                    foreach (var item in roles)
                    {
                        listRoles.Add(item.Name);
                    }
                    await _userManager.AddToRolesAsync(superAdmin, listRoles);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
