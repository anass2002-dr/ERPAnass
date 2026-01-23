using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.PaymentService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IServicePayment _paymentService;

        public PaymentController(IServicePayment paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet("GetPayments")]
        public ActionResult<IEnumerable<dynamic>> GetPayments()
        {
            return Ok(_paymentService.GetPaymentsDetails());
        }

        [HttpGet("GetPaymentById/{id}")]
        public ActionResult<Payment> GetPaymentById(int id)
        {
            var payment = _paymentService.GetPaymentById(id);
            if (payment == null) return NotFound();
            return Ok(payment);
        }

        [HttpPost("AddPayment")]
        public ActionResult<Payment> AddPayment(PaymentDtos payment)
        {
            return Ok(_paymentService.AddPayment(payment));
        }

        [HttpPut("UpdatePayment/{id}")]
        public ActionResult<Payment> UpdatePayment(int id, Payment payment)
        {
            var updated = _paymentService.UpdatePayment(id, payment);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("DeletePayment/{id}")]
        public IActionResult DeletePayment(int id)
        {
            if (!_paymentService.DeletePayment(id)) return NotFound();
            return NoContent();
        }
    }
}
