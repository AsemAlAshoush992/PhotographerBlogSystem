using BlogPhotographerSystem_Core.DTOs.Category;
using BlogPhotographerSystem_Core.DTOs.Gallery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IServices
{
    public interface IGalleryService
    {
        //Guest Management
        Task<List<PhotosAndVideosInfoDTO>> GetAllPhotosForPublicGallery();
        Task<List<PhotosAndVideosInfoDTO>> GetAllVideosForPublicGallery();
        //Admin Management
        Task<PrivateGalleryDetailsDTO> GetPublicGalleryDetailsById(int Id);
        Task<List<PrivateGalleryDetailsDTO>> GetPublicGalleries();
        //Send
        Task SendFilesForUserByPrivateGallery(SendPrivateGalleryDTO dto);
        //Update
        Task UpdatePrivateGallery(UpdateGalleryDTO dto);
        //Delete
        Task DeletePrivateGallery(int ID);
        //Client Management
        Task<List<PrivateGalleryOrderDetails>> GetAllPrivateGalleriesByUserId(int orderId);
        Task<List<PrivateGalleryOrderDetails>> GetAllPrivateGalleriesVideosByUserId(int orderId);
        Task<List<PrivateGalleryDetailsForClientDTO>> GetAllPrivateGalleriesByUserIdWithoutOrders(int UserId);
        //Upload
        Task UploadFilesForUserByPrivateGallery(CreatePrivateGalleryDTO dto, int userId);
        Task UploadFilesForPublicGallery(CreatePublicGalleryDTO dto);
        //Update
        Task UpdateFilesForClientByPrivateGallery(UpdatePrivateGalleryDTO dto);

    }
}
