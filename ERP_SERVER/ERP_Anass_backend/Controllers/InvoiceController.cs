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
        [HttpPost("GenerateFromSale/{saleId}")]
        public async Task<ActionResult<InvoiceDto>> GenerateFromSale(int saleId)
        {
            var invoice = await _service.GenerateInvoiceFromSale(saleId);
            return CreatedAtAction(nameof(GetInvoice), new { id = invoice.idInvoice }, invoice);
        }

        [HttpPost("GenerateFromPurchase/{purchaseId}")]
        public async Task<ActionResult<InvoiceDto>> GenerateFromPurchase(int purchaseId)
        {
            var invoice = await _service.GenerateInvoiceFromPurchase(purchaseId);
            return CreatedAtAction(nameof(GetInvoice), new { id = invoice.idInvoice }, invoice);
        }

        [HttpGet("GetInvoiceData/{purchaseId}")] // Changed to GET as it is read-only
        public async Task<ActionResult<InvoiceDto>> GetInvoiceDataFromPurchase(int purchaseId)
        {
            var invoice = await _service.GetInvoiceDataFromPurchase(purchaseId);
            return Ok(invoice);
        }

        [HttpGet("GetInvoicePdfData/{id}")]
        public async Task<ActionResult<InvoicePdfDto>> GetInvoicePdfData(int id)
        {
            var invoiceData = await _service.GetInvoicePdfData(id);
            if (invoiceData == null)
            {
                return NotFound();
            }
            return Ok(invoiceData);
        }
    }
}
