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
        Task<BlogDetailsForUserDTO> GetBlogDetailsByIdRepos(int blogid);
        //Admin Management
        Task<List<BlogsDetailsDTO>> GetAllBlogsDetailsRepos();
        Task<BlogsDetailsDTO> GetBlogDetailsForAdminByIdRepos(int Id);
        //Create
        Task<int> CreateBlogRepos(Blog blog);
        Task CreateBlogAttachmentsRepos(BlogAttachement attachement);
        //Update
        Task UpdateBlogRepos(UpdateBlogAdminDTO dto);
        //Delete
        Task DeleteBlogRepos(int ID);
        //Approval
        Task ConfirmUserBlogRepos(int blogID);
        //Cancel
        Task CancelUserBlogRepos(int blogID);
        //Client Management
        Task<List<BlogDetailsForUserDTO>> GetAllBlogsByUserIdRepos(int userId);
        //Update
        Task UpdateClientBlogRepos(UpdateBlogClientDTO dto);

    }
}
