using BlogPhotographerSystem_Core.DTOs.Login;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IRepos
{
    public interface ILoginRepos
    {
        //Guest Management
        Task<int> GetUserIdAfterLoginOperations(string email, string password);
        Task<int> GetAdminIdAfterLoginOperations(string email, string password);
        //Task LoginReposClient(CreateLoginDTO dto);
        Task ResetPasswordRepos(CreateLoginDTO dto);
        Task LogoutRepos(int userID);
    }
}
