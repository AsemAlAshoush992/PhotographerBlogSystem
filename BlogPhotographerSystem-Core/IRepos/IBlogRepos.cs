using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IRepos
{
    public interface IBlogRepos
    {
        //Guest Management
        Task<List<BlogsCardsDTO>> GetAllBlogsInfoRepos();
        Task<BlogDetailsForUserDTO> GetBlogDetailsById(int blogid);
        //Admin Management
        Task<List<BlogsDetailsDTO>> GetAllBlogsDetailsRepos();
        Task<BlogsDetailsDTO> GetBlogDetailsForAdminByIdRepos(int Id);
        //Create
        Task<int> CreateBlogRepos(Blog blog);
        Task CreateBlogAttachmentsRepos(BlogAttachement attachement);
        //Update
        Task UpdateBlogRepos(UpdateBlogAdminDTO dto);
        //Delete
        Task DeleteBlogRepos(UpdateBlogAdminDTO dto);

        //Client Management
        Task<List<BlogDetailsForUserDTO>> GetAllBlogsByUserIdRepos(int userId);
        //Create
        Task<int> CreateClientBlogRepos(Blog blog);
        Task CreateClientBlogAttachementRepos(BlogAttachement attachement);
        //Update
        Task UpdateClientBlogRepos(Blog blog);
        //Delete
        Task DeleteClientBlogRepos(Blog blog);

    }
}
