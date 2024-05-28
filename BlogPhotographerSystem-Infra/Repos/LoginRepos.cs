using BlogPhotographerSystem_Core.DTOs.Login;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class LoginRepos : ILoginRepos
    {
        public Task CreateNewLoginRepos(Login login)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLoginRepos(Login login)
        {
            throw new NotImplementedException();
        }

        public Task<LoginDetailsDTO> FilterLoginByIsLoggedInOrLastLoginTimeRepos(bool? IsLoggedIn, DateTime? LastLoginTime)
        {
            throw new NotImplementedException();
        }

        public Task<List<LoginDetailsDTO>> GetAllLoginsRepos()
        {
            throw new NotImplementedException();
        }

        public Task<LoginDetailsDTO> GetLoginDetailsByIdRepos(int Id)
        {
            throw new NotImplementedException();
        }

        public Task LogoutRepos(Login login)
        {
            throw new NotImplementedException();
        }

        public Task ResetPasswordRepos(Login login)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLoginRepos(Login login)
        {
            throw new NotImplementedException();
        }

        Task ILoginRepos.LoginRepos(Login login)
        {
            throw new NotImplementedException();
        }
    }
}
