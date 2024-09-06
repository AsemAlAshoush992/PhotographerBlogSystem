using BlogPhotographerSystem_Core.DTOs.Login;
using BlogPhotographerSystem_Core.Helper;
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
        private readonly IUserRepos _userRepos;
        public LoginService(ILoginRepos loginRepos, IUserRepos userRepos)
        {
            _loginRepos = loginRepos;
            _userRepos = userRepos;
        }
        //public async Task Login(CreateLoginDTO dto)
        //{
        //    await _loginRepos.LoginReposClient(dto);
        //}
        public async Task<string> GenerateUserAccessToken(CreateLoginDTO input)
        {
            var user = await TryAuthenticate(input);
            if (user != null)
            {
                return TokenHelper.GenerateJwtToken(user);
            }
            throw new Exception("Failed to generate token");
        }
        public async Task<User> TryAuthenticate(CreateLoginDTO input)
        {
            var userId = await _loginRepos.GetUserIdAfterLoginOperations(input.UserName, input.Password);

            if(userId != 0)
            {
                return await _userRepos.GetUserById(userId);
            }
            else
            {
                throw new Exception("Wrong email or password");
            }
        }

        public async Task Logout(int userID)
        {
            await _loginRepos.LogoutRepos(userID);
        }

        public async Task ResetPassword(CreateLoginDTO dto)
        {
            await _loginRepos.ResetPasswordRepos(dto);
        }

        public async Task<string> GenerateAdminAccessToken(CreateLoginDTO input)
        {
            var user = await TryAdminAuthenticate(input);
            if (user != null)
            {
                return TokenHelper.GenerateJwtToken(user);
            }
            throw new Exception("Failed to generate token");
        }

        public async Task<User> TryAdminAuthenticate(CreateLoginDTO input)
        {
            var userId = await _loginRepos.GetAdminIdAfterLoginOperations(input.UserName, input.Password);

            if (userId != 0)
            {
                return await _userRepos.GetUserById(userId);
            }
            else
            {
                throw new Exception("Wrong email or password");
            }
        }
    }
}
