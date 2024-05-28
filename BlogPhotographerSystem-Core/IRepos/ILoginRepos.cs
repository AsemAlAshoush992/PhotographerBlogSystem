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
        Task LoginRepos(Login login);
        Task ResetPasswordRepos(Login login);
        Task LogoutRepos(Login login);
        //Admin Management
        Task<LoginDetailsDTO> GetLoginDetailsByIdRepos(int Id);
        Task<List<LoginDetailsDTO>> GetAllLoginsRepos();
        //Filter
        Task<LoginDetailsDTO> FilterLoginByIsLoggedInOrLastLoginTimeRepos(bool? IsLoggedIn, DateTime? LastLoginTime);

        //Create
        Task CreateNewLoginRepos(Login login);
        //Update
        Task UpdateLoginRepos(Login login);
        //Delete
        Task DeleteLoginRepos(Login login);
    }
}
