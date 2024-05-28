using BlogPhotographerSystem_Core.DTOs.Gallery;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class GalleryRepos : IGalleryRepos
    {
        public Task DeletePrivateGalleryRepos(Gallery gallery)
        {
            throw new NotImplementedException();
        }

        public Task<PrivateGalleryDetailsDTO> FilterPrivateGalleryByFileTypeOrOrderIDRepos(string? FileType, int? orderID)
        {
            throw new NotImplementedException();
        }

        public Task<List<PhotosAndVideosInfoDTO>> GetAllPhotosForPublicGalleryRepos()
        {
            throw new NotImplementedException();
        }

        public Task<List<PhotosAndVideosInfoDTO>> GetAllVideosForPublicGalleryRepos()
        {
            throw new NotImplementedException();
        }

        public Task<PrivateGalleryDetailsDTO> GetPrivateGalleryDetailsByIdRepos(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PrivateGalleryDetailsDTO>> GetPrivateGallerysRepos()
        {
            throw new NotImplementedException();
        }

        public Task SendFilesForUserByPrivateGalleryRepos(Gallery gallery)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePrivateGalleryRepos(Gallery gallery)
        {
            throw new NotImplementedException();
        }
    }
}
