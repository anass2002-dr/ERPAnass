using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.BankAccountRepo
{
    public interface IBankAccountRepository
    {
        Task<List<BankAccount>> GetBankAccounts();
        Task<BankAccount> GetBankAccount(int id);
        Task<BankAccount> AddBankAccount(BankAccount bankAccount);
        Task<BankAccount> UpdateBankAccount(BankAccount bankAccount);
        Task DeleteBankAccount(int id);
    }
}
