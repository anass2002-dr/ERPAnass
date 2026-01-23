using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.AccountRepo
{
    public interface IRepoAccount
    {
        Account GetAccountById(int id);
        List<dynamic> GetAccountsDetails();
        List<Account> GetAccounts();
        Account AddAccount(Account account);
        Account UpdateAccount(Account account);
        Boolean DeleteAccount(int id);
    }
}
