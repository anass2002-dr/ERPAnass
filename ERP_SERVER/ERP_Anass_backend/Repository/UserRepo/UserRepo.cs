using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.UserRepo
{
    public class UserRepo : IUserRepo
    {
        private readonly DbContextERP _context;

        public UserRepo(DbContextERP context)
        {
            _context = context;
        }

        public User GetUserById(Guid id)
        {
            return _context.Set<User>().FirstOrDefault(u => u.UserID == id);
        }

        public List<User> GetUsers()
        {
            return _context.Set<User>().ToList();
        }

        public List<dynamic> GetUsersDetails()
        {
            return _context.Set<User>()
                .Select(u => new
                {
                    u.UserID,
                    u.FirstName,
                    u.LastName,
                    u.Email,
                    u.Role,
                    u.Status,
                    u.CreatedAt,
                    u.UpdatedAt
                })
                .ToList<dynamic>();
        }

        public User AddUser(User user)
        {
            _context.Set<User>().Add(user);
            _context.SaveChanges();
            return user;
        }

        public User UpdateUser(User user)
        {
            _context.Set<User>().Update(user);
            _context.SaveChanges();
            return user;
        }

        public Boolean DeleteUser(Guid id)
        {
            var user = _context.Set<User>().FirstOrDefault(u => u.UserID == id);
            if (user != null)
            {
                _context.Set<User>().Remove(user);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
