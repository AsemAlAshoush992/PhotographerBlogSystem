using BlogPhotographerSystem_Core.DTOs.Login;
using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IRepos
{
    public interface IUserRepos
    {
        //Guest Management
        Task<int> CreateUserRepos(User user);
        Task CreateLoginRepos(Login login);

        //Admin Management
        Task<UserDetailsDTO> GetUserDetailsByIdRepos(int Id);
        Task<List<UserDetailsDTO>> GetAllUsersRepos();
        //Filter
        Task<List<UserDetailsDTO>> FilterUsersByPhoneOrEmailRepos(string? email, string? phone);
        //Update
        Task UpdateUserRepos(UpdateUserAdminDTO dto);
        //Delete
        Task DeleteUserRepos(int ID);
        //User Management
        Task<UserInfoDTO> GetPersonalInformationsByIdRepos(int Id);
        //Update
        Task UpdateUserAccountRepos(UpdateUserDTO dto);
        //Delete
        Task DeleteUserAccountRepos(int ID);
    }
}
