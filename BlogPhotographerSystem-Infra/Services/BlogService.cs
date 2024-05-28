using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class BlogService : IBlogService
    {
        public Task CreateBlog(CreateBlogAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBlog(UpdateBlogAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteClientBlog(UpdateBlogClientDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogDetailsForUserDTO>> GetAllBlogsByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogsDetailsDTO>> GetAllBlogsDetails()
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogsCardsDTO>> GetAllBlogsInfo()
        {
            throw new NotImplementedException();
        }

        public Task<BlogDetailsForUserDTO> GetBlogDetailsById(int blogid)
        {
            throw new NotImplementedException();
        }

        public Task<BlogsDetailsDTO> GetBlogDetailsForAdminById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task SendClientBlogRequest(CreateBlogAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBlog(UpdateBlogAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateClientBlog(UpdateBlogClientDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
