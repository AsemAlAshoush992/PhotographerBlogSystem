using BlogPhotographerSystem_Core.DTOs.Gallery;
using BlogPhotographerSystem_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class GalleryService : IGalleryService
    {
        public Task DeleteFilesForClientByPrivateGallery(UpdatePrivateGalleryDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeletePrivateGallery(UpdatePrivateGalleryDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<PrivateGalleryDetailsDTO> FilterPrivateGalleryByFileTypeOrOrderID(string? FileType, int? orderID)
        {
            throw new NotImplementedException();
        }

        public Task<List<PhotosAndVideosInfoDTO>> GetAllPhotosForPublicGallery()
        {
            throw new NotImplementedException();
        }

        public Task<List<PhotosAndVideosInfoDTO>> GetAllVideosForPublicGallery()
        {
            throw new NotImplementedException();
        }

        public Task<PrivateGalleryDetailsDTO> GetPrivateGalleryDetailsById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PrivateGalleryDetailsDTO>> GetPrivateGallerys()
        {
            throw new NotImplementedException();
        }

        public Task SendFilesForUserByPrivateGallery(CreatePrivateGalleryDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFilesForClientByPrivateGallery(UpdatePrivateGalleryDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePrivateGallery(UpdatePrivateGalleryDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UploadFilesForUserByPrivateGallery(CreatePrivateGalleryDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
