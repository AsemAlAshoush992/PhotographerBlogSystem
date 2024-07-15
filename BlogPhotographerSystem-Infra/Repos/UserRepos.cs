using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Crud;
using Serilog;
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

        public Task DeleteUserAccountRepos(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteUserRepos(int ID)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(b => b.Id == ID);
            user.ModifiedDate = DateTime.Now;
            user.ModifiedUserId = 1;
            user.IsDeleted = true;

            _dbContext.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<UserDetailsDTO>> FilterUsersByPhoneOrEmailRepos(string? email, string? phone)
        {
            bool flag = email == null && phone == null? true : false;
            var query = from filter in _dbContext.Users
                        where filter.Email == email || filter.Phone == phone || flag
                        select new UserDetailsDTO
                        {
                            Id = filter.Id,
                            FirstName = filter.FirstName,
                            LastName = filter.LastName,
                            Email = filter.Email,
                            BirthDate = filter.BirthDate,
                            ImagePath = filter.ImagePath,
                            Phone = filter.Phone,
                            UserType = filter.UserType.ToString(),
                            CreationDate = filter.CreationDate,
                            ModifiedDate = filter.ModifiedDate,
                            CreatorUserId = filter.CreatorUserId,
                            ModifiedUserId = filter.ModifiedUserId,
                            IsDeleted = filter.IsDeleted

                        };
            return await query.ToListAsync();
        }

        public async Task<List<UserDetailsDTO>> GetAllUsersRepos()
        {
            var query = from user in _dbContext.Users
                        select new UserDetailsDTO
                        {
                            Id = user.Id,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Email = user.Email,
                            BirthDate = user.BirthDate,
                            ImagePath = $"https://localhost:7071/{user.ImagePath}",
                            Phone = user.Phone,
                            UserType = user.UserType.ToString(),
                            IsDeleted = user.IsDeleted
                        };
            return await query.ToListAsync() ;
        }

        public async Task<UserInfoDTO> GetPersonalInformationsByIdRepos(int Id)
        {
            var query = from user in _dbContext.Users
                        join login in _dbContext.Logins
                        on user.Id equals login.UserID
                        where user.Id == Id
                        select new UserInfoDTO
                        {
                            FullName = user.FirstName + " " + user.LastName,
                            Email = user.Email,
                            Password = login.Password,
                            BirthDate = user.BirthDate,
                            ImagePath = $"https://localhost:7071/{user.ImagePath}",
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
                            ImagePath = $"https://localhost:7071/{user.ImagePath}",
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
            var login = await _dbContext.Logins.SingleOrDefaultAsync(b => b.UserID == dto.Id);
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

            if (!string.IsNullOrEmpty(dto.Password))
            {
                login.Password = dto.Password;
            }
            if (!string.IsNullOrEmpty(dto.ImagePath))
            {
                user.ImagePath = dto.ImagePath;
            }

            if (!string.IsNullOrEmpty(dto.Phone))
            {
                user.Phone = dto.Phone;
            }
            if (!string.IsNullOrEmpty(dto.UserType))
            {
                user.UserType = (UserType)Enum.Parse(typeof(UserType), dto.UserType);
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

        public async Task<User> GetUserById (int userId)
        {
            var query = from user in _dbContext.Users
                        where user.Id == userId
                        select user;
            return await query.SingleOrDefaultAsync();

        }
    }
}
