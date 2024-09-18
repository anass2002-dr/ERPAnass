using ERP_Anass_backend.DTOs;
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

            return NoContent();
        }
    }
}
