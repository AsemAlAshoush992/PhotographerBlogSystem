using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.DTOs.Login;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class LoginRepos : ILoginRepos
    {
        private readonly BlogPhotographerSystemDBContext _context;

        public LoginRepos(BlogPhotographerSystemDBContext context)
        {
            _context = context;
        }
        public async Task<int> GetUserIdAfterLoginOperations(string email, string password)
        {
            //var query = from login in _context.Logins
            //            where login.UserName == email 
            //            && login.Password == password 
            //            && login.IsDeleted == false
            //            select login.UserID;
            var query1 = await _context.Logins.SingleOrDefaultAsync
                (x => x.UserName == email && x.Password == password && x.IsDeleted == false);
            var query2 = await _context.Users.SingleOrDefaultAsync
                (x => x.Email == email && x.UserType == (UserType)Enum.Parse(typeof(UserType), "Client"));
            if (query1 != null && query2 != null)
            {
                query1.LastLoginTime = DateTime.Now;
                query1.IsLoggedIn = true;
                _context.Update(query1);
                await _context.SaveChangesAsync();
                return (int)query1.UserID;
            }
            else
                throw new Exception("Unauthorized");
             
        }
        public async Task LogoutRepos(int userID)
        {
            var query = await _context.Logins.SingleOrDefaultAsync
                (x => x.UserID == userID);
            query.IsLoggedIn = false;
            _context.Update(query);
            await _context.SaveChangesAsync();
        }

        public async Task ResetPasswordRepos(CreateLoginDTO dto)
        {
            var query = await _context.Logins.SingleOrDefaultAsync
                (x => x.UserName == dto.UserName);
            if (query != null)
            {
                query.Password = dto.Password;
                _context.Update(query);
                await _context.SaveChangesAsync();
            }
            else
                throw new Exception("The Email is Wrong ");
        }
        public async Task LoginReposClient(CreateLoginDTO dto)
        {
            var query = await _context.Logins.SingleOrDefaultAsync
                (x => x.UserName == dto.UserName && x.Password == dto.Password);
            if (query != null)
            {
                query.LastLoginTime = DateTime.Now;
                query.IsLoggedIn = true;
                _context.Update(query);
                await _context.SaveChangesAsync();
            }
            else
                throw new Exception("Incorrect username or password");
        }

        public async Task<int> GetAdminIdAfterLoginOperations(string email, string password)
        {
            var query1 = await _context.Logins.SingleOrDefaultAsync
                (x => x.UserName == email && x.Password == password 
                && x.IsDeleted == false);
            var query2 = await _context.Users.SingleOrDefaultAsync
                (x => x.Email == email && x.UserType == (UserType)Enum.Parse(typeof(UserType), "Admin"));
            if (query1 != null && query2 != null)
            {
                query1.LastLoginTime = DateTime.Now;
                query1.IsLoggedIn = true;
                _context.Update(query1);
                await _context.SaveChangesAsync();
                
                return (int)query1.UserID;
            }
            else
                throw new Exception("Unauthorized");
        }
    }
}
