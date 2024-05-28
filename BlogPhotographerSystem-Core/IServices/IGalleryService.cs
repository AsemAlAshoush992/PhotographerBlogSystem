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
        Task<PrivateGalleryDetailsDTO> GetPrivateGalleryDetailsById(int Id);
        Task<List<PrivateGalleryDetailsDTO>> GetPrivateGallerys();
        //Filter
        Task<PrivateGalleryDetailsDTO> FilterPrivateGalleryByFileTypeOrOrderID(string? FileType, int? orderID);

        //Send
        Task SendFilesForUserByPrivateGallery(CreatePrivateGalleryDTO dto);
        //Update
        Task UpdatePrivateGallery(UpdatePrivateGalleryDTO dto);
        //Delete
        Task DeletePrivateGallery(UpdatePrivateGalleryDTO dto);
        //Client Management
        //Upload
        Task UploadFilesForUserByPrivateGallery(CreatePrivateGalleryDTO dto);
        //Update
        Task UpdateFilesForClientByPrivateGallery(UpdatePrivateGalleryDTO dto);
        //Delete
        Task DeleteFilesForClientByPrivateGallery(UpdatePrivateGalleryDTO dto);

    }
}
