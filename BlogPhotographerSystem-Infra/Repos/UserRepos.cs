using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class UserRepos : IUserRepos
    {
        private readonly BlogPhotographerSystemDBContext _dbContext;

        public UserRepos(BlogPhotographerSystemDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> CreateUserRepos(User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return user.Id;
        }
        public async Task CreateLoginRepos(Login login)
        {
            _dbContext.Logins.Add(login);
            await _dbContext.SaveChangesAsync();
        }

        public Task DeleteUserAccountRepos(User user)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteUserRepos(UpdateUserAdminDTO dto)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(b => b.Id == dto.Id);
            user.ModifiedDate = DateTime.Now;
            user.ModifiedUserId = 1;
            user.IsDeleted = true;

            _dbContext.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public Task<UserDetailsDTO> FilterUsersByPhoneOrEmailRepos(string? email, string? phone)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDetailsDTO>> GetAllUsersRepos()
        {
            throw new NotImplementedException();
        }

        public async Task<UserInfoDTO> GetPersonalInformationsByIdRepos(int Id)
        {
            var query = from user in _dbContext.Users
                        join login in _dbContext.Logins
                        on user.Id equals login.UserID
                        where user.Id == Id
                        select new UserInfoDTO
                        {
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Email = user.Email,
                            Password = login.Password,
                            BirthDate = user.BirthDate,
                            ImagePath = user.ImagePath,
                            Phone = user.Phone
                        };
            return await query.SingleOrDefaultAsync();
        }

        public async Task<UserDetailsDTO> GetUserDetailsByIdRepos(int Id)
        {
            var query = from user in _dbContext.Users
                        where user.Id == Id
                        select new UserDetailsDTO
                        {
                            Id = user.Id,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Email = user.Email,
                            BirthDate = user.BirthDate,
                            ImagePath = user.ImagePath,
                            Phone = user.Phone,
                            UserType = user.UserType.ToString(),
                            CreationDate = user.CreationDate,
                            ModifiedDate = user.ModifiedDate,
                            CreatorUserId = user.CreatorUserId,
                            ModifiedUserId = user.ModifiedUserId,
                            IsDeleted = user.IsDeleted
                        };
            return await query.SingleOrDefaultAsync();
        }

        public async Task UpdateUserAccountRepos(UpdateUserDTO dto)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(b => b.Id == dto.Id);
            var login = await _dbContext.Logins.SingleOrDefaultAsync(b => b.UserID == dto.Id);


            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (!string.IsNullOrEmpty(dto.FirstName))
            {
                user.FirstName = dto.FirstName;
            }

            if (!string.IsNullOrEmpty(dto.LastName))
            {
                user.LastName = dto.LastName;
            }

            if (!string.IsNullOrEmpty(dto.ImagePath))
            {
                user.ImagePath = dto.ImagePath;
            }

            if (!string.IsNullOrEmpty(dto.Phone))
            {
                user.Phone = dto.Phone;
            }
            if (!string.IsNullOrEmpty(dto.Password))
            {
                login.Password = dto.Password;
            }
            
            if (dto.BirthDate.HasValue)
            {
                user.BirthDate = dto.BirthDate.Value;
            }
            user.ModifiedDate = DateTime.Now;
            user.ModifiedUserId = 1;

            _dbContext.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUserRepos(UpdateUserAdminDTO dto)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(b => b.Id == dto.Id);

            if (user == null)
            {
                throw new Exception("Admin not found");
            }

            if (!string.IsNullOrEmpty(dto.FirstName))
            {
                user.FirstName = dto.FirstName;
            }

            if (!string.IsNullOrEmpty(dto.LastName))
            {
                user.LastName = dto.LastName;
            }

            if (!string.IsNullOrEmpty(dto.Email))
            {
                user.Email = dto.Email;
            }

            if (!string.IsNullOrEmpty(dto.ImagePath))
            {
                user.ImagePath = dto.ImagePath;
            }

            if (!string.IsNullOrEmpty(dto.Phone))
            {
                user.Phone = dto.Phone;
            }
            if (dto.BirthDate != null)
            {
                user.BirthDate = (DateTime)dto.BirthDate;
            }
            user.ModifiedDate = DateTime.Now;
            user.ModifiedUserId = 1;

            _dbContext.Update(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}
