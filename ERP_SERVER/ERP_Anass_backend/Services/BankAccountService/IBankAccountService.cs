using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.BankAccountService
{
    public interface IBankAccountService
    {
        Task<List<BankAccountDto>> GetBankAccounts();
        Task<BankAccountDto> GetBankAccount(int id);
        Task<BankAccountDto> CreateBankAccount(BankAccountCreateDto bankAccountDto);
        Task<BankAccountDto> UpdateBankAccount(BankAccount bankAccount);
        Task DeleteBankAccount(int id);
    }
}
