using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IServices
{
    public interface IBlogService
    {
        //Guest Management
        Task<List<BlogsCardsDTO>> GetAllBlogsInfo();
        Task<BlogDetailsForUserDTO> GetBlogDetailsById(int blogid);
        //Admin Management
        Task<List<BlogsDetailsDTO>> GetAllBlogsDetails();
        Task<BlogsDetailsDTO> GetBlogDetailsForAdminById(int Id);

        //Create
        Task CreateBlog(CreateBlogAdminDTO dto);
        //Update
        Task UpdateBlog(UpdateBlogAdminDTO dto);
        //Delete
        Task DeleteBlog(int ID);
        //Aprroval
        Task ConfirmUserBlog(int dto);
        //cancel
        Task CancelUserBlog(int dto);
        //Client Management
        Task<List<BlogDetailsForUserDTO>> GetAllBlogsByUserId(int userId);
        //Send
        Task SendClientBlogRequest(CreateBlogAdminDTO dto, int userId);
        //Update
        Task UpdateClientBlog(UpdateBlogClientDTO dto);
        //Delete
        //GetNotificationOnApprovedBlogsFromEmail

    }
}
