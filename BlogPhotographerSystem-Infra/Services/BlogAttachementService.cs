using BlogPhotographerSystem_Core.DTOs.BlogAttachement;
using BlogPhotographerSystem_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class BlogAttachementService : IBlogAttachementService
    {
        public Task CreateNewBlogAttachement(CreateBlogAttachementDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBlogAttachement(UpdateBlogAttachementDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<BlogAttachementDetailsDTO> FilterBlogAttachementByFileTypeOrBlogID(string? FileType, int? BlogID)
        {
            throw new NotImplementedException();
        }

        public Task<BlogAttachementDetailsDTO> GetBlogAttachementDetailsById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogAttachementDetailsDTO>> GetBlogAttachements()
        {
            throw new NotImplementedException();
        }

        public Task UpdateBlogAttachement(UpdateBlogAttachementDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
