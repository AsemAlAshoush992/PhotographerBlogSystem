using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class UserService : IUserService
    {
        public Task CreateNewUser(CreateUserAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(UpdateUserAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAccount(UpdateUserDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDetailsDTO> FilterUsersByPhoneOrEmail(string? email, string? phone)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDetailsDTO>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserInfoDTO> GetPersonalInformationsById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDetailsDTO> GetUserDetailsById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Register(RegisterDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(UpdateUserAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAccount(UpdateUserDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
