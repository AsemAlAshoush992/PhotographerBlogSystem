using BlogPhotographerSystem_Core.DTOs.Login;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepos _loginRepos;
        public LoginService(ILoginRepos loginRepos)
        {
            _loginRepos = loginRepos;
        }
        public async Task Login(CreateLoginDTO dto)
        {
            await _loginRepos.LoginReposClient(dto);
        }

        public async Task Logout(int userID)
        {
            await _loginRepos.LogoutRepos(userID);
        }

        public async Task ResetPassword(CreateLoginDTO dto)
        {
            await _loginRepos.ResetPasswordRepos(dto);
        }
    }

}
