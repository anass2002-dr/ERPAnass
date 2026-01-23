using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.BankAccountService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly IBankAccountService _service;

        public BankAccountController(IBankAccountService service)
        {
            _service = service;
        }

        [HttpGet("GetBankAccounts")]
        public async Task<ActionResult<List<BankAccountDto>>> GetBankAccounts()
        {
            return await _service.GetBankAccounts();
        }

        [HttpGet("GetBankAccountById/{id}")]
        public async Task<ActionResult<BankAccountDto>> GetBankAccount(int id)
        {
            var bankAccount = await _service.GetBankAccount(id);
            if (bankAccount == null)
            {
                return NotFound();
            }
            return bankAccount;
        }

        [HttpPost("AddBankAccount")]
        public async Task<ActionResult<BankAccountDto>> AddBankAccount(BankAccountCreateDto bankAccountDto)
        {
            var bankAccount = await _service.CreateBankAccount(bankAccountDto);
            return CreatedAtAction(nameof(GetBankAccount), new { id = bankAccount.idBankAccount }, bankAccount);
        }

        [HttpPut("UpdateBankAccount/{id}")]
        public async Task<ActionResult<BankAccountDto>> UpdateBankAccount(int id, BankAccount bankAccount)
        {
            if (id != bankAccount.idBankAccount)
            {
                return BadRequest();
            }

            var updatedBankAccount = await _service.UpdateBankAccount(bankAccount);
            return Ok(updatedBankAccount);
        }

        [HttpDelete("DeleteBankAccount/{id}")]
        public async Task<IActionResult> DeleteBankAccount(int id)
        {
            await _service.DeleteBankAccount(id);
            return NoContent();
        }
    }
}
