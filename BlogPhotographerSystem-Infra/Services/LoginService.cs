using BlogPhotographerSystem_Core.DTOs.Login;
using BlogPhotographerSystem_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class LoginService : ILoginService
    {
        public Task CreateNewLogin(CreateLoginDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLogin(UpdateLoginDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<LoginDetailsDTO> FilterLoginByIsLoggedInOrLastLoginTime(bool? IsLoggedIn, DateTime? LastLoginTime)
        {
            throw new NotImplementedException();
        }

        public Task<List<LoginDetailsDTO>> GetAllLogins()
        {
            throw new NotImplementedException();
        }

        public Task<LoginDetailsDTO> GetLoginDetailsById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Login(LoginDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task Logout(int id, bool isDeleted)
        {
            throw new NotImplementedException();
        }

        public Task ResetPassword(string? email, string? phone)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLogin(UpdateLoginDTO dto)
        {
            throw new NotImplementedException();
        }
    }

}
