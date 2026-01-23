using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.BankAccountRepo
{
    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly DbContextERP _context;

        public BankAccountRepository(DbContextERP context)
        {
            _context = context;
        }

        public async Task<List<BankAccount>> GetBankAccounts()
        {
            return await _context.BankAccounts.ToListAsync();
        }

        public async Task<BankAccount> GetBankAccount(int id)
        {
            return await _context.BankAccounts.FindAsync(id);
        }

        public async Task<BankAccount> AddBankAccount(BankAccount bankAccount)
        {
            _context.BankAccounts.Add(bankAccount);
            await _context.SaveChangesAsync();
            return bankAccount;
        }

        public async Task<BankAccount> UpdateBankAccount(BankAccount bankAccount)
        {
            _context.Entry(bankAccount).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return bankAccount;
        }

        public async Task DeleteBankAccount(int id)
        {
            var bankAccount = await _context.BankAccounts.FindAsync(id);
            if (bankAccount != null)
            {
                _context.BankAccounts.Remove(bankAccount);
                await _context.SaveChangesAsync();
            }
        }
    }
}
