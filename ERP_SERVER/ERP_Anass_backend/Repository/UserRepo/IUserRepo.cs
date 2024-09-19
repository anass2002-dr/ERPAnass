using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.UserRepo
{
    public interface IUserRepo
    {
        User GetUserById(Guid id);
        List<dynamic> GetUsersDetails();
        List<User> GetUsers();
        User AddUser(User user);
        User UpdateUser(User user);
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
        Permission AddPermission(Permission Permission);
        Permission UpdatePermission(int id, Permission Permission);
        Boolean DeletePermission(int id);
    }
}
