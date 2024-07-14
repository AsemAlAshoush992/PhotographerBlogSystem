using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Migrations;
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

        //GetAll
        public async Task<List<UserDetailsDTO>> GetAllUsersDetails()
        {
            return await _userRepos.GetAllUsersRepos();
        }
        public async Task CreateNewAdmin(CreateUserAdminDTO dto)
        {
            User user = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                BirthDate = dto.BirthDate,
                ImagePath = !string.IsNullOrEmpty(dto.ImagePath)? dto.ImagePath: null,
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
        public async Task DeleteUser(int ID)
        {
            await _userRepos.DeleteUserRepos(ID);
        }
        public async Task UpdateUserAccount(UpdateUserDTO dto)
        {
            await _userRepos.UpdateUserAccountRepos(dto);
        }
    }
}
