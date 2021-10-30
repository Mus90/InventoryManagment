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
    [Authorize(Roles = "Manager")]
    public class ReportsController : ControllerBase
    {

        private readonly IProductsQueriesHandler _queriesHandler;
        public ReportsController(IProductsQueriesHandler queriesHandler)
        {
            _queriesHandler = queriesHandler;
        }

        [HttpGet("SoldItems")]
        public async Task<ActionResult<List<ProductSoldItemsResponse>>> SoldItems()
        {
            var product = await _queriesHandler.GetSoldProducts();
            if (product == null)
            {
                return NotFound("No product sold yet");
            }
            return Ok(product);
        }

        [HttpGet("ProductsSummary")]
        public async Task<ActionResult<ProductsSummaryReportResponse>> ProductsSummary()
        {
            var product = await _queriesHandler.GetProductsSummary();
            if (product == null)
            {
                return NotFound("No items found in products");
            }
            return Ok(product);
        }

        [HttpGet("ProductsVsStock")]
        public async Task<ActionResult<List<StockVsSoldItemsResponse>>> ProductsVsStock()
        {
            var result = await _queriesHandler.GetStockVsSoldItems();
            if (result == null)
            {
                return NotFound("No items in stock");
            }
            return Ok(result);
        }
    }
}
