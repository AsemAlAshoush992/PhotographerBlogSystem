using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class BlogRepos : IBlogRepos
    {
        public Task CreateBlogAttachmentsRepos(BlogAttachement attachement)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateBlogRepos(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task CreateClientBlogAttachementRepos(BlogAttachement attachement)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateClientBlogRepos(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBlogRepos(UpdateBlogAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteClientBlogRepos(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogDetailsForUserDTO>> GetAllBlogsByUserIdRepos(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogsDetailsDTO>> GetAllBlogsDetailsRepos()
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogsCardsDTO>> GetAllBlogsInfoRepos()
        {
            throw new NotImplementedException();
        }

        public Task<BlogDetailsForUserDTO> GetBlogDetailsById(int blogid)
        {
            throw new NotImplementedException();
        }

        public Task<BlogsDetailsDTO> GetBlogDetailsForAdminByIdRepos(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBlogRepos(UpdateBlogAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateClientBlogRepos(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
