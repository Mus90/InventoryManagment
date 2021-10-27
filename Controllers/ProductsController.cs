using InventoryManagement.CommandHandlers;
using InventoryManagement.Models;
using InventoryManagement.Models.Dtos;
using InventoryManagement.Models.Entities;
using InventoryManagement.QueryHandlers;
using InventoryManagement.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [Authorize(Roles ="User,Manager")]
    public class ProductsController : ControllerBase
    {

        private readonly IProductsCommandsHandler _commandHandler;
        private readonly IProductsQueriesHandler _queryHandler;
        public ProductsController(IProductsCommandsHandler commandHandler, IProductsQueriesHandler queryHandler)
        {
            _commandHandler = commandHandler;
            _queryHandler = queryHandler;
        }

        // PUT: api/Products
        [HttpGet]
        public async Task<List<ProductQueryResponseDto>> Get()
        {
            return await _queryHandler.GetProducts();
        }

        // PUT: api/Products/{id}
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_queryHandler.GetProductById(id));
        }


        // PUT: api/Products
        [HttpPut]
        [Produces(typeof(Product))]
        public async Task<IActionResult> Put([FromBody] UpdateProductDto product)
        {
            var result = await _commandHandler.UpdateProduct(product);
            return Ok(result);
        }

        // PUT: api/Products
        [HttpPut("ReStock")]
        [Produces(typeof(Product))]
        public async Task<IActionResult> ReStock([FromBody] ReStockProductRequestDto input)
        {
            var result = await _commandHandler.RestockProduct(input.ProductId, input.Quantity);
            return Ok(result);
        }

        // POST: api/Products
        [HttpPost]
        [Produces(typeof(Product))]
        public async Task<IActionResult> Post([FromBody] CreateProductDto product)
        {
            var result = await _commandHandler.CreateProduct(product);
            return Ok(result);
        }

        // PUT: api/Products
        [HttpDelete]
        [Produces(typeof(Product))]
        public async Task<IActionResult> Delete([FromBody] int Id)
        {
            var result = await _commandHandler.DeleteProduct(Id);
            return Ok(result);
        }
    }
}
