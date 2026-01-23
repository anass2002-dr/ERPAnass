using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.AccountService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IServiceAccount _accountService;

        public AccountController(IServiceAccount accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("GetAccounts")]
        public ActionResult<IEnumerable<dynamic>> GetAccounts()
        {
            return Ok(_accountService.GetAccountsDetails());
        }

        [HttpGet("GetAccountById/{id}")]
        public ActionResult<Account> GetAccountById(int id)
        {
            var account = _accountService.GetAccountById(id);
            if (account == null) return NotFound();
            return Ok(account);
        }

        [HttpPost("AddAccount")]
        public ActionResult<Account> AddAccount(AccountDtos account)
        {
            return Ok(_accountService.AddAccount(account));
        }

        [HttpPut("UpdateAccount/{id}")]
        public ActionResult<Account> UpdateAccount(int id, Account account)
        {
            var updated = _accountService.UpdateAccount(id, account);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("DeleteAccount/{id}")]
        public IActionResult DeleteAccount(int id)
        {
            if (!_accountService.DeleteAccount(id)) return NotFound();
            return NoContent();
        }
    }
}
