using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.AccountService
{
    public interface IServiceAccount
    {
        Account GetAccountById(int id);
        List<Account> GetAccounts();
        List<dynamic> GetAccountsDetails();
        Account AddAccount(AccountDtos account);
        Account UpdateAccount(int id, Account account);
        bool DeleteAccount(int id);
    }
}
