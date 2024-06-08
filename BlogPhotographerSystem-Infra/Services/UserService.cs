using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using BlogPhotographerSystem_Infra.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Infra.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepos _userRepos;

        public UserService(IUserRepos userRepos)
        {
            _userRepos = userRepos;
        }
        public async Task CreateNewAdmin(CreateUserAdminDTO dto)
        {
            User user = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                BirthDate = dto.BirthDate,
                ImagePath = dto.ImagePath,
                Phone = dto.Phone,
                UserType = UserType.Admin
            };
            int UsertId = await _userRepos.CreateUserRepos(user);
            Login login = new Login()
            {
                UserName = dto.Email,
                Password = dto.Password,
                UserID = UsertId,
            };
            await _userRepos.CreateLoginRepos(login);
        }
        public Task DeleteUserAccount(UpdateUserDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDetailsDTO> FilterUsersByPhoneOrEmail(string? email, string? phone)
        {
            throw new NotImplementedException();
        }

        public async Task<UserInfoDTO> GetPersonalInformationsById(int Id)
        {
            return await _userRepos.GetPersonalInformationsByIdRepos(Id);
        }

        public async Task<UserDetailsDTO> GetUserDetailsById(int Id)
        {
            return await _userRepos.GetUserDetailsByIdRepos(Id);
        }

        public async Task Register(RegisterDTO dto)
        {
            User user = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                BirthDate = dto.BirthDate,
                ImagePath = dto.ImagePath,
                Phone = dto.Phone,
                UserType = UserType.Client
            };
            int UsertId = await _userRepos.CreateUserRepos(user);

            Login login = new Login()
            {
                UserName = dto.Email,
                Password = dto.Password,
                UserID = UsertId,
            };
            await _userRepos.CreateLoginRepos(login);
        }

        public async Task UpdateUser(UpdateUserAdminDTO dto)
        {
            await _userRepos.UpdateUserRepos(dto);
        }
        public async Task DeleteUser(UpdateUserAdminDTO dto)
        {
            await _userRepos.DeleteUserRepos(dto);
        }
        public async Task UpdateUserAccount(UpdateUserDTO dto)
        {
            await _userRepos.UpdateUserAccountRepos(dto);
        }
    }
}
