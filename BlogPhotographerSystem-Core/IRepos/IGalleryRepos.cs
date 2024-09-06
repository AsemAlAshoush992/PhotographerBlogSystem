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
        //Update
        Task UpdateFilesForClientByPrivateGallery(UpdatePrivateGalleryDTO dto);
        //Client Management
        Task<List<PrivateGalleryOrderDetails>> GetAllPrivateGalleriesByUserId(int orderId);
        Task<List<PrivateGalleryOrderDetails>> GetAllPrivateGalleriesVideosByUserId(int orderId);
        Task<List<PrivateGalleryDetailsForClientDTO>> GetAllPrivateGalleriesByUserIdWithoutOrdersRepos(int UserId);
        //Send
        Task SendFilesForUserByPrivateGalleryRepos( Gallery gallery);
        //Update
        Task UpdatePrivateGalleryRepos(UpdateGalleryDTO dto);
        //Delete
        Task DeletePrivateGalleryRepos(int ID);
    }
}
