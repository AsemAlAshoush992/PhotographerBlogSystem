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
        Task Login(LoginDTO dto);
        Task ResetPassword(string? email, string? phone);
        Task Logout(int id, bool isDeleted);
        //Admin Management
        Task<LoginDetailsDTO> GetLoginDetailsById(int Id);
        Task<List<LoginDetailsDTO>> GetAllLogins();
        //Filter
        Task<LoginDetailsDTO> FilterLoginByIsLoggedInOrLastLoginTime(bool? IsLoggedIn, DateTime? LastLoginTime);

        //Create
        Task CreateNewLogin(CreateLoginDTO dto);
        //Update
        Task UpdateLogin(UpdateLoginDTO dto);
        //Delete
        Task DeleteLogin(UpdateLoginDTO dto);
    }
}
