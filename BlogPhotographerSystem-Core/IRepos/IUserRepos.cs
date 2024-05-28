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
        Task<UserDetailsDTO> FilterUsersByPhoneOrEmailRepos(string? email, string? phone);
        //Create
        Task CreateNewUserRepos(User user);
        //Update
        Task UpdateUserRepos(User user);
        //Delete
        Task DeleteUserRepos(User user);
        //User Management
        Task<UserInfoDTO> GetPersonalInformationsByIdRepos(int Id);
        //Update
        Task UpdateUserAccountRepos( User user);
        //Delete
        Task DeleteUserAccountRepos(User user);
    }
}
