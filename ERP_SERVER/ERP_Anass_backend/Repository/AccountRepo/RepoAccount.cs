using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.AccountRepo
{
    public class RepoAccount : IRepoAccount
    {
        private readonly DbContextERP _context;

        public RepoAccount(DbContextERP context)
        {
            _context = context;
        }

        public Account AddAccount(Account account)
        {
            var acc = _context.Set<Account>().Add(account);
            _context.SaveChanges();
            return acc.Entity;
        }

        public bool DeleteAccount(int id)
        {
            var account = _context.Set<Account>().Find(id);
            if (account == null) return false;

            _context.Set<Account>().Remove(account);
            _context.SaveChanges();
            return true;
        }

        public Account GetAccountById(int id)
        {
            return _context.Set<Account>().Find(id);
        }

        public List<Account> GetAccounts()
        {
            return _context.Set<Account>().ToList();
        }

        public List<dynamic> GetAccountsDetails()
        {
            return _context.Set<Account>()
                .Select(a => new
                {
                    a.idAccount,
                    a.AccountCode,
                    a.AccountName,
                    a.Type,
                    a.IsAcitve
                })
                .ToList<dynamic>();
        }

        public Account UpdateAccount(Account account)
        {
            var existing = _context.Set<Account>().Find(account.idAccount);
            if (existing != null)
            {
                existing.AccountCode = account.AccountCode ?? existing.AccountCode;
                existing.AccountName = account.AccountName ?? existing.AccountName;
                existing.Type = account.Type;
                 existing.IsAcitve = account.IsAcitve;

                _context.SaveChanges();
                return existing;
            }
            return null;
        }
    }
}
