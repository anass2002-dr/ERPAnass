using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/User/{id}
        [HttpGet("GetUserById{id:guid}")]
        public IActionResult GetUserById(Guid id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound("User not found");
            }
            return Ok(user);
        }

        // GET: api/User
        [HttpGet("GetAllUsers")]
        public IActionResult GetUsers()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }

        // GET: api/User/details
        [HttpGet("details")]
        public IActionResult GetUsersDetails()
        {
            var userDetails = _userService.GetUsersDetails();
            return Ok(userDetails);
        }

        // POST: api/User
        [HttpPost("AddUser")]
        public IActionResult AddUser(UserDtos userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newUser = _userService.AddUser(userDto);
            return CreatedAtAction(nameof(GetUserById), new { id = newUser.UserID }, newUser);
        }

        // PUT: api/User/{id}
        [HttpPut("UpdateUser/{id:guid}")]
        public IActionResult UpdateUser(Guid id, [FromBody] UserDtos userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var updatedUser = _userService.UpdateUser(id, userDto);
                return Ok(updatedUser);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("User not found");
            }
        }

        // DELETE: api/User/{id}
        [HttpDelete("DeleteUser/{id:guid}")]
        public IActionResult DeleteUser(Guid id)
        {
            var isDeleted = _userService.DeleteUser(id);
            if (!isDeleted)
            {
                return NotFound("User not found");
            }

            return Ok("Deleted with success");
        }

        // ------------------- MODULES ------------------------

        [HttpGet("modules/GetModuleById/{id}")]
        public ActionResult<Modules> GetModuleById(int id)
        {
            var module = _userService.GetModuleById(id);
            if (module == null)
                return NotFound("Module not found");

            return Ok(module);
        }

        [HttpGet("modules/GetModulesDetails")]
        public ActionResult<List<dynamic>> GetModulesDetails()
        {
            var moduleDetails = _userService.GetModulesDetails();
            return Ok(moduleDetails);
        }

        [HttpGet("modules/GetModules")]
        public ActionResult<List<Modules>> GetModules()
        {
            var modules = _userService.GetModules();
            return Ok(modules);
        }

        [HttpPost("modules/AddModules")]
        public ActionResult<Modules> AddModules(Modules module)
        {
            var createdModule = _userService.AddModules(module);
            return CreatedAtAction(nameof(GetModuleById), new { id = createdModule.IdModule }, createdModule);
        }

        [HttpPut("modules/UpdateModules/{id}")]
        public ActionResult<Modules> UpdateModules(int id, Modules module)
        {
            var updatedModule = _userService.UpdateModules(id, module);
            if (updatedModule == null)
                return NotFound("Module not found");

            return Ok(updatedModule);
        }

        [HttpDelete("modules/DeleteModules/{id}")]
        public ActionResult<Boolean> DeleteModules(int id)
        {
            var deleted = _userService.DeleteModules(id);
            if (!deleted)
                return NotFound("Module not found");

            return Ok(deleted);
        }

        // ------------------- PERMISSIONS ------------------------

        [HttpGet("permissions/GetPermissionById/{id}")]
        public ActionResult<Permission> GetPermissionById(int id)
        {
            var permission = _userService.GetPermissionById(id);
            if (permission == null)
                return NotFound("Permission not found");

            return Ok(permission);
        }

        [HttpGet("permissions/GetPermissionsDetails")]
        public ActionResult<List<dynamic>> GetPermissionsDetails()
        {
            var permissionDetails = _userService.GetPermissionsDetails();
            return Ok(permissionDetails);
        }

        [HttpGet("permissions/GetPermissions")]
        public ActionResult<List<Permission>> GetPermissions()
        {
            var permissions = _userService.GetPermissions();
            return Ok(permissions);
        }

        [HttpPost("permissions/AddPermission")]
        public ActionResult<Permission> AddPermission(PermissionDtos permissionDto)
        {
            var createdPermission = _userService.AddPermission(permissionDto);
            return CreatedAtAction(nameof(GetPermissionById), new { id = createdPermission.IdPermission }, createdPermission);
        }

        [HttpPut("permissions/UpdatePermission/{id}")]
        public ActionResult<Permission> UpdatePermission(int id, PermissionDtos permissionDto)
        {
            var updatedPermission = _userService.UpdatePermission(id, permissionDto);
            if (updatedPermission == null)
                return NotFound("Permission not found");

            return Ok(updatedPermission);
        }

        [HttpDelete("permissions/DeletePermission/{id}")]
        public ActionResult<Boolean> DeletePermission(int id)
        {
            var deleted = _userService.DeletePermission(id);
            if (!deleted)
                return NotFound("Permission not found");

            return Ok(deleted);
        }



    }
}
