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
    [Authorize(Roles = "User,Manager")]
    public class InvoicesController : ControllerBase
    {

        private readonly IInvoiceCommandsHandler _commandHandler;
        private readonly IInvoiceQueriesHandler _queryHandler;
        public InvoicesController(IInvoiceCommandsHandler commandHandler, IInvoiceQueriesHandler queryHandler)
        {
            _commandHandler = commandHandler;
            _queryHandler = queryHandler;
        }

        // PUT: api/Invoices
        [HttpGet]
        public async Task<List<InvoiceQueryResponseDto>> Get()
        {
            return await _queryHandler.GetInvoices();
        }

        // PUT: api/Invoices/{id}
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_queryHandler.GetInvoiceById(id));
        }

        // POST: api/Invoices
        [HttpPost]
        [Produces(typeof(ActionResponseDto))]
        public async Task<IActionResult> Post([FromBody] CreateInvoiceDto invoice)
        {
            invoice.CreatedBy = User.Identity.Name;
            var result = await _commandHandler.CreateInvoice(invoice);
            return Ok(result);
        }


        // PUT: api/Invoices
        [HttpPut]
        [Produces(typeof(ActionResponseDto))]
        public async Task<IActionResult> Put([FromBody] UpdateInvoiceDto invoice)
        {
            var result = await _commandHandler.UpdateInvoice(invoice);
            return Ok(result);
        }

        

        // Delete: api/Invoices
        [HttpDelete]
        [Produces(typeof(ActionResponseDto))]
        public async Task<IActionResult> Delete([FromBody] int Id)
        {
            var result = await _commandHandler.DeleteInvoice(Id);
            return Ok(result);
        }

    }
}
