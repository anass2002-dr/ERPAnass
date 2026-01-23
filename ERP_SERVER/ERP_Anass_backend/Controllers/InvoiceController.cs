using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.InvoiceService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _service;

        public InvoiceController(IInvoiceService service)
        {
            _service = service;
        }

        [HttpGet("GetInvoices")]
        public async Task<ActionResult<List<InvoiceDto>>> GetInvoices()
        {
            return await _service.GetInvoices();
        }

        [HttpGet("GetInvoiceById/{id}")]
        public async Task<ActionResult<InvoiceDto>> GetInvoice(int id)
        {
            var invoice = await _service.GetInvoice(id);
            if (invoice == null)
            {
                return NotFound();
            }
            return invoice;
        }

        [HttpPost("AddInvoice")]
        public async Task<ActionResult<InvoiceDto>> AddInvoice(InvoiceCreateDto invoiceDto)
        {
            var invoice = await _service.CreateInvoice(invoiceDto);
            return CreatedAtAction(nameof(GetInvoice), new { id = invoice.idInvoice }, invoice);
        }

        [HttpPut("UpdateInvoice/{id}")]
        public async Task<ActionResult<InvoiceDto>> UpdateInvoice(int id, Invoice invoice)
        {
            if (id != invoice.idInvoice)
            {
                return BadRequest();
            }

            var updatedInvoice = await _service.UpdateInvoice(invoice);
            return Ok(updatedInvoice);
        }

        [HttpDelete("DeleteInvoice/{id}")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            await _service.DeleteInvoice(id);
            return NoContent();
        }
    }
}
