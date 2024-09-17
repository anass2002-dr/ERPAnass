using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.UserRepo
{
    public interface IUserRepo
    {
        User GetUserById(int id);
        List<dynamic> GetUsersDetails();
        List<User> GetUsers();
        User AddUser(User user);
        User UpdateUser(User user);
        Boolean DeleteUser(int id);
    }
}
