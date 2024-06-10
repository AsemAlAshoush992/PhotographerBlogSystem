using BlogPhotographerSystem_Core.DTOs.BlogAttachement;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IRepos
{
    public interface IBlogAttachementRepos
    {
        //Admin Management
        Task<BlogAttachementDetailsDTO> GetBlogAttachementDetailsByIdRepos(int Id);
        Task<List<BlogAttachementDetailsDTO>> GetBlogAttachementsRepos();
        //Filter
        Task<BlogAttachementDetailsDTO> FilterBlogAttachementByFileTypeOrBlogIDRepos(string? FileType, int? BlogID);

        //Create
        Task CreateNewBlogAttachementRepos(BlogAttachement attachement);
        //Update
        Task UpdateBlogAttachementRepos(BlogAttachement attachement);
        //Delete
        Task DeleteBlogAttachementRepos(int ID);
    }
}
