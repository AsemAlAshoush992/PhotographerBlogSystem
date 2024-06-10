using BlogPhotographerSystem_Core.DTOs.BlogAttachement;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class BlogAttachementRepos : IBlogAttachementRepos
    {
        public Task CreateNewBlogAttachementRepos(BlogAttachement attachement)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBlogAttachementRepos(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<BlogAttachementDetailsDTO> FilterBlogAttachementByFileTypeOrBlogIDRepos(string? FileType, int? BlogID)
        {
            throw new NotImplementedException();
        }

        public Task<BlogAttachementDetailsDTO> GetBlogAttachementDetailsByIdRepos(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogAttachementDetailsDTO>> GetBlogAttachementsRepos()
        {
            throw new NotImplementedException();
        }

        public Task UpdateBlogAttachementRepos(BlogAttachement attachement)
        {
            throw new NotImplementedException();
        }
    }
}
