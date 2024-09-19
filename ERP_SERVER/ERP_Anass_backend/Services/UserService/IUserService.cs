using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.UserService
{
    public interface IUserService
    {
        //users

        User GetUserById(Guid id);
        List<dynamic> GetUsersDetails();
        List<User> GetUsers();
        User AddUser(UserDtos user);
        User UpdateUser(Guid id, UserDtos userDto);
        Boolean DeleteUser(Guid id);


        // module
        
        Modules GetModuleById(int id);
        List<dynamic> GetModulesDetails();
        List<Modules> GetModules();
        Modules AddModules(Modules module);
        Modules UpdateModules(int id, Modules modules);
        Boolean DeleteModules(int id);

        //Permission
        Permission GetPermissionById(int id);
        List<dynamic> GetPermissionsDetails();
        List<Permission> GetPermissions();
        Permission AddPermission(PermissionDtos Permission);
        Permission UpdatePermission(int id, PermissionDtos Permission);
        Boolean DeletePermission(int id);


    }
}
