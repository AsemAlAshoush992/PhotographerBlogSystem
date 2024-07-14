using BlogPhotographerSystem_Core.DTOs.Login;
using BlogPhotographerSystem_Core.DTOs.Order;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IServices
{
    public interface ILoginService
    {
        //Guest Management
        Task<string> GenerateUserAccessToken(CreateLoginDTO input);
        Task<User> TryAuthenticate(CreateLoginDTO input);
        //Task Login(CreateLoginDTO dto);
        Task ResetPassword(CreateLoginDTO dto);
        Task Logout(int userID);

    }
}
