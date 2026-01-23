using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.BankAccountRepo;

namespace ERP_Anass_backend.Services.BankAccountService
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository _repository;

        public BankAccountService(IBankAccountRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<BankAccountDto>> GetBankAccounts()
        {
            var bankAccounts = await _repository.GetBankAccounts();
            return bankAccounts.Select(b => new BankAccountDto
            {
                idBankAccount = b.idBankAccount,
                BankName = b.BankName,
                AccountNumber = b.AccountNumber,
                IBAN = b.IBAN,
                SwiftCode = b.SwiftCode,
                CurrentBalance = b.CurrentBalance
            }).ToList();
        }

        public async Task<BankAccountDto> GetBankAccount(int id)
        {
            var bankAccount = await _repository.GetBankAccount(id);
            if (bankAccount == null) return null;

            return new BankAccountDto
            {
                idBankAccount = bankAccount.idBankAccount,
                BankName = bankAccount.BankName,
                AccountNumber = bankAccount.AccountNumber,
                IBAN = bankAccount.IBAN,
                SwiftCode = bankAccount.SwiftCode,
                CurrentBalance = bankAccount.CurrentBalance
            };
        }

        public async Task<BankAccountDto> CreateBankAccount(BankAccountCreateDto bankAccountDto)
        {
            var bankAccount = new BankAccount
            {
                BankName = bankAccountDto.BankName,
                AccountNumber = bankAccountDto.AccountNumber,
                IBAN = bankAccountDto.IBAN,
                SwiftCode = bankAccountDto.SwiftCode,
                CurrentBalance = bankAccountDto.CurrentBalance
            };

            var createdBankAccount = await _repository.AddBankAccount(bankAccount);
            return await GetBankAccount(createdBankAccount.idBankAccount);
        }

        public async Task<BankAccountDto> UpdateBankAccount(BankAccount bankAccount)
        {
            var updatedBankAccount = await _repository.UpdateBankAccount(bankAccount);
            return await GetBankAccount(updatedBankAccount.idBankAccount);
        }

        public async Task DeleteBankAccount(int id)
        {
            await _repository.DeleteBankAccount(id);
        }
    }
}
