
using InventoryManagement.CommandHandlers;
using InventoryManagement.Models;
using InventoryManagement.Models.Dtos;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private IConfiguration _config;

        public AccountController(UserManager<ApplicationUser> mUserManager, IConfiguration config)
        {
            _userManager = mUserManager;
            _config = config;
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "Admin")]
        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser(CreateUserDto request)
        {
            //check if the SignupRequest is valid
            if (ModelState.IsValid)
            {
                //Create new user and map it with the request
                var newUser = new ApplicationUser();
                newUser.UserName = request.UserName;
                newUser.Email = request.Email;

                var result = await _userManager.CreateAsync(newUser, request.Password);

                //Check if the user is created successfuly
                if (result.Succeeded)
                {
                    // Add user to role
                    foreach (var role in request.Roles.Split(","))
                    {
                        await _userManager.AddToRoleAsync(newUser, role);
                    }

                    var response = new ActionResponseDto
                    {
                        message = "Successful",
                        result = newUser.Id,
                        Success = true
                    };
                    return Ok(response);
                }
            }
            //otherwise
            return BadRequest("Invalid data entered");
        }

        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateRequestDto request)
        {
            IActionResult response = Unauthorized();
            var user = await AuthenticateUser(request);

            if (user != null)
            {
                var tokenString = GenerateJSONWebToken(user);
                var roles = await _userManager.GetRolesAsync((ApplicationUser)user);

                response = Ok(new AuthenticateResponse { Token = tokenString.Result, Roles = roles });
            }

            return response;
        }


        //Generate Token for the user if authenticated
        private async Task<string> GenerateJSONWebToken(IdentityUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim> {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
        };

            var roles = await _userManager.GetRolesAsync((ApplicationUser)user);
            foreach (var userRole in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, userRole));
            }

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                expires: DateTime.Now.AddHours(2),
                claims: claims,
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        //Check if the user authenticated
        private async Task<IdentityUser> AuthenticateUser(AuthenticateRequestDto request)
        {

            //Validate the User Credentials
            var user = await _userManager.FindByNameAsync(request.UserName);
            var result = await _userManager.CheckPasswordAsync(user, request.Password);
            if (result)
            {
                return user;
            }
            return null;

        }
    }
}