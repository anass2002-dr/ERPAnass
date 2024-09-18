using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.UserService
{
    public interface IUserService
    {
        User GetUserById(Guid id);
        List<dynamic> GetUsersDetails();
        List<User> GetUsers();
        User AddUser(UserDtos user);
        User UpdateUser(Guid id, UserDtos userDto);
        Boolean DeleteUser(Guid id);
    }
}
