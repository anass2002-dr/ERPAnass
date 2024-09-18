using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.UserRepo;

namespace ERP_Anass_backend.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _repoUser;

        public UserService(IUserRepo repoUser)
        {
            _repoUser = repoUser;
        }

        public User GetUserById(Guid id)
        {
            return _repoUser.GetUserById(id);
        }

        public List<User> GetUsers()
        {
            return _repoUser.GetUsers();
        }

        public List<dynamic> GetUsersDetails()
        {
            return _repoUser.GetUsersDetails();
        }

        public User AddUser(UserDtos userDto)
        {
            User user = new User
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Password = userDto.Password, // Assuming you're hashing the password elsewhere
                Status = userDto.Status,
                CreatedAt = userDto.CreatedAt == default ? DateTime.UtcNow : userDto.CreatedAt,
                UpdatedAt = userDto.UpdatedAt == default ? DateTime.UtcNow : userDto.UpdatedAt,
                Role = userDto.Role
            };

            return _repoUser.AddUser(user);
        }

        public User UpdateUser(Guid id, UserDtos userDto)
        {
            var existingUser = _repoUser.GetUserById(id);
            if (existingUser == null)
            {
                throw new KeyNotFoundException("User not found");
            }

            existingUser.FirstName = string.IsNullOrEmpty(userDto.FirstName) ? existingUser.FirstName : userDto.FirstName;
            existingUser.LastName = string.IsNullOrEmpty(userDto.LastName) ? existingUser.LastName : userDto.LastName;
            existingUser.Email = string.IsNullOrEmpty(userDto.Email) ? existingUser.Email : userDto.Email;
            existingUser.Password = string.IsNullOrEmpty(userDto.Password) ? existingUser.Password : userDto.Password;
            existingUser.Status = string.IsNullOrEmpty(userDto.Status) ? existingUser.Status : userDto.Status;
            existingUser.UpdatedAt = DateTime.UtcNow;
            existingUser.Role = string.IsNullOrEmpty(userDto.Role) ? existingUser.Role : userDto.Role;

            return _repoUser.UpdateUser(existingUser);
        }

        public Boolean DeleteUser(Guid id)
        {
            return _repoUser.DeleteUser(id);
        }


    }
}
