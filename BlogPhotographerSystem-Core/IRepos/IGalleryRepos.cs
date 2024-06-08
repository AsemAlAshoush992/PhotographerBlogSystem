using BlogPhotographerSystem_Core.DTOs.BlogAttachement;
using BlogPhotographerSystem_Core.DTOs.Gallery;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IRepos
{
    public interface IGalleryRepos
    {
        //Guest
        Task<List<PhotosAndVideosInfoDTO>> GetAllPhotosForPublicGalleryRepos();
        Task<List<PhotosAndVideosInfoDTO>> GetAllVideosForPublicGalleryRepos();

        //Admin Management
        Task<PrivateGalleryDetailsDTO> GetPublicGalleryDetailsByIdRepos(int Id);
        Task<List<PrivateGalleryDetailsDTO>> GetPublicGalleriesRepos();
        //Filter
        Task<PrivateGalleryDetailsDTO> FilterPrivateGalleryByFileTypeOrOrderIDRepos(string? FileType, int? orderID);
        //Client Management
        Task<List<PrivateGalleryDetailsDTO>> GetAllPrivateGalleriesByUserId(int orderId);
        //Send
        Task SendFilesForUserByPrivateGalleryRepos( Gallery gallery);
        //Update
        Task UpdatePrivateGalleryRepos(UpdatePrivateGalleryDTO dto);
        //Delete
        Task DeletePrivateGalleryRepos(UpdatePrivateGalleryDTO dto);
    }
}
