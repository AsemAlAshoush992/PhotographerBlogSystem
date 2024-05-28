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
        Task DeleteBlog(UpdateBlogAdminDTO dto);
        //Aprroval
        //Task ApprovalOfUserBlogs(ApprovalDTO approval);

        //Client Management
        Task<List<BlogDetailsForUserDTO>> GetAllBlogsByUserId(int userId);
        //Send
        Task SendClientBlogRequest(CreateBlogAdminDTO dto);
        //Update
        Task UpdateClientBlog(UpdateBlogClientDTO dto);
        //Delete
        Task DeleteClientBlog(UpdateBlogClientDTO dto);
        //GetNotificationOnApprovedBlogsFromEmail

    }
}
