using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.BlogAttachement;
using BlogPhotographerSystem_Core.DTOs.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IServices
{
    public interface IBlogAttachementService
    {
        //Admin Management
        Task<BlogAttachementDetailsDTO> GetBlogAttachementDetailsById(int Id);
        Task<List<BlogAttachementDetailsDTO>> GetBlogAttachements();
        //Filter
        Task<BlogAttachementDetailsDTO> FilterBlogAttachementByFileTypeOrBlogID(string? FileType, int? BlogID);

        //Create
        Task CreateNewBlogAttachement(CreateBlogAttachementDTO dto);
        //Update
        Task UpdateBlogAttachement(UpdateBlogAttachementDTO dto);
        //Delete
        Task DeleteBlogAttachement(UpdateBlogAttachementDTO dto);
    }
}
