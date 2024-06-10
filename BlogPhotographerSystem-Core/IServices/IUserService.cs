﻿using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.Login;
using BlogPhotographerSystem_Core.DTOs.Service;
using BlogPhotographerSystem_Core.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IServices
{
    public interface IUserService
    {
        //Guest Management
        Task Register(RegisterDTO dto);

        //Admin Management
        Task<UserDetailsDTO> GetUserDetailsById(int Id);
        //Filter
        Task<List<UserDetailsDTO>> FilterUsersByPhoneOrEmail(string? email, string? phone);

        //Create
        Task CreateNewAdmin(CreateUserAdminDTO dto);
        //Update
        Task UpdateUser(UpdateUserAdminDTO dto);
        //Delete
        Task DeleteUser(int ID);

        //User Management
        Task<UserInfoDTO> GetPersonalInformationsById(int Id);
        //Update
        Task UpdateUserAccount(UpdateUserDTO dto);
        //Delete
        Task DeleteUserAccount(int ID);
    }
}
