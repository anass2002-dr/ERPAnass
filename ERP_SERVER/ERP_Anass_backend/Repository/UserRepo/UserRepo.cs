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
            try
            {
                if (user != null)
                {
                    _context.Set<User>().Remove(user);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }


            return false;
        }


        // ------------------- MODULES ------------------------

        public Modules GetModuleById(int id)
        {
            return _context.Set<Modules>().FirstOrDefault(u => u.IdModule == id);
        }

        public List<dynamic> GetModulesDetails()
        {
            var modulesDetails = _context.Modules
                                         .Select(m => new
                                         {
                                             m.IdModule,
                                             m.ModuleName,
                                             Permissions = m.Permission.Select(p => new
                                             {
                                                 p.Add,
                                                 p.Edit,
                                                 p.Delete
                                             })
                                         })
                                         .ToList<dynamic>();
            return modulesDetails;
        }

        public List<Modules> GetModules()
        {
            return _context.Modules.ToList();
        }

        public Modules AddModules(Modules module)
        {
            _context.Modules.Add(module);
            _context.SaveChanges();
            return module;
        }

        public Modules UpdateModules(int id, Modules module)
        {
            var existingModule = _context.Modules.FirstOrDefault(m => m.IdModule == id);

            if (existingModule == null)
                throw new KeyNotFoundException("Module not found");

            existingModule.ModuleName = module.ModuleName;

            _context.Modules.Update(existingModule);
            _context.SaveChanges();
            return existingModule;
        }

        public bool DeleteModules(int id)
        {
            var module = _context.Modules.FirstOrDefault(m => m.IdModule == id);

            if (module == null)
                return false;

            _context.Modules.Remove(module);
            _context.SaveChanges();
            return true;
        }

        // ------------------- PERMISSION ------------------------

        public Permission GetPermissionById(int id)
        {
            return _context.Permissions.FirstOrDefault(u => u.IdPermission == id);
        }

        public List<dynamic> GetPermissionsDetails()
        {
            var permissionsDetails = _context.Permissions
                                             .Select(p => new
                                             {
                                                 p.IdPermission,
                                                 p.User.FirstName,
                                                 p.Modules.ModuleName,
                                                 p.Add,
                                                 p.Edit,
                                                 p.Delete
                                             })
                                             .ToList<dynamic>();
            return permissionsDetails;
        }

        public List<Permission> GetPermissions()
        {
            return _context.Permissions.ToList();
        }

        public Permission AddPermission(Permission permission)
        {
            _context.Permissions.Add(permission);
            _context.SaveChanges();
            return permission;
        }

        public Permission UpdatePermission(int id, Permission permission)
        {
            var existingPermission = _context.Permissions.FirstOrDefault(p => p.IdPermission == id);

            if (existingPermission == null)
                throw new KeyNotFoundException("Permission not found");

            existingPermission.Add = permission.Add;
            existingPermission.Edit = permission.Edit;
            existingPermission.Delete = permission.Delete;
            existingPermission.UserId = permission.UserId;
            existingPermission.IdModule = permission.IdModule;

            _context.Permissions.Update(existingPermission);
            _context.SaveChanges();
            return existingPermission;
        }

        public bool DeletePermission(int id)
        {
            var permission = _context.Permissions.FirstOrDefault(p => p.IdPermission == id);

            if (permission == null)
                return false;

            _context.Permissions.Remove(permission);
            _context.SaveChanges();
            return true;
        }
    }
}
