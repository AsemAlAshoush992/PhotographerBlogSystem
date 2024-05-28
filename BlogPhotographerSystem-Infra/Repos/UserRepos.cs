using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class UserRepos : IUserRepos
    {
        public Task CreateLoginRepos(Login login)
        {
            throw new NotImplementedException();
        }

        public Task CreateNewUserRepos(User user)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateUserRepos(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAccountRepos(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserRepos(User user)
        {
            throw new NotImplementedException();
        }

        public Task<UserDetailsDTO> FilterUsersByPhoneOrEmailRepos(string? email, string? phone)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDetailsDTO>> GetAllUsersRepos()
        {
            throw new NotImplementedException();
        }

        public Task<UserInfoDTO> GetPersonalInformationsByIdRepos(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDetailsDTO> GetUserDetailsByIdRepos(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAccountRepos(User user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserRepos(User user)
        {
            throw new NotImplementedException();
        }
    }
}
