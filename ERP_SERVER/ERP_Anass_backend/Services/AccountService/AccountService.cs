using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.AccountRepo;

namespace ERP_Anass_backend.Services.AccountService
{
    public class AccountService : IServiceAccount
    {
        private readonly IRepoAccount _repoAccount;

        public AccountService(IRepoAccount repoAccount)
        {
            _repoAccount = repoAccount;
        }

        public Account AddAccount(AccountDtos accountDtos)
        {
            Account account = new Account();
            account.AccountCode = accountDtos.AccountCode;
            account.AccountName = accountDtos.AccountName;
            account.Type = accountDtos.Type;
            account.IsAcitve = accountDtos.IsAcitve;
            return _repoAccount.AddAccount(account);
        }

        public bool DeleteAccount(int id)
        {
            return _repoAccount.DeleteAccount(id);
        }

        public Account GetAccountById(int id)
        {
            return _repoAccount.GetAccountById(id);
        }

        public List<Account> GetAccounts()
        {
            return _repoAccount.GetAccounts();
        }

        public List<dynamic> GetAccountsDetails()
        {
            return _repoAccount.GetAccountsDetails();
        }

        public Account UpdateAccount(int id, Account account)
        {
            account.idAccount = id;
            return _repoAccount.UpdateAccount(account);
        }
    }
}
