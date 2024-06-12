using BlogPhotographerSystem_Core.DTOs.Gallery;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Infra.Services
{
    public class GalleryService : IGalleryService
    {
        private readonly IGalleryRepos _galleryRepos;

        public GalleryService(IGalleryRepos galleryRepos)
        {
            _galleryRepos = galleryRepos;
        }

        public async Task DeleteFilesForClientByPrivateGallery(int ID)
        {
            await _galleryRepos.DeletePrivateGalleryRepos(ID);
        }

        public async Task DeletePrivateGallery(int ID)
        {
            await _galleryRepos.DeletePrivateGalleryRepos(ID);
        }

        public Task<PrivateGalleryDetailsDTO> FilterPrivateGalleryByFileTypeOrOrderID(string? FileType, int? orderID)
        {
            throw new NotImplementedException();
        }
        //Guest Management
        public async Task<List<PhotosAndVideosInfoDTO>> GetAllPhotosForPublicGallery()
        {
            return await _galleryRepos.GetAllPhotosForPublicGalleryRepos();
        }

        public async Task<List<PhotosAndVideosInfoDTO>> GetAllVideosForPublicGallery()
        {
            return await _galleryRepos.GetAllVideosForPublicGalleryRepos();
        }

        public async Task<PrivateGalleryDetailsDTO> GetPublicGalleryDetailsById(int Id)
        {
            return await _galleryRepos.GetPublicGalleryDetailsByIdRepos(Id);
        }

        public async Task<List<PrivateGalleryDetailsForClientDTO>> GetAllPrivateGalleriesByUserId(int UserId)
        {
            return await _galleryRepos.GetAllPrivateGalleriesByUserId(UserId);
        }

        public async Task SendFilesForUserByPrivateGallery(SendPrivateGalleryDTO dto)
        {
            Gallery gallery = new Gallery()
            {
                Path = dto.Path,
                FileName = dto.FileName,
                FileType = (FileType)Enum.Parse(typeof(FileType), dto.FileType),
                IsPrivate = true,
                OrderID = dto.OrderID
            };
            await _galleryRepos.SendFilesForUserByPrivateGalleryRepos(gallery);
        }

        public async Task UpdateFilesForClientByPrivateGallery(UpdatePrivateGalleryDTO dto)
        {
            await _galleryRepos.UpdateFilesForClientByPrivateGallery(dto);
        }

        public async Task UpdatePrivateGallery(UpdateGalleryDTO dto)
        {
            await _galleryRepos.UpdatePrivateGalleryRepos(dto);
        }

        public async Task UploadFilesForUserByPrivateGallery(CreatePrivateGalleryDTO dto)
        {
            Gallery gallery = new Gallery()
            {
                Path = dto.Path,
                FileName = dto.FileName,
                FileType = (FileType)Enum.Parse(typeof(FileType), dto.FileType),
                IsPrivate = true,
            };
            await _galleryRepos.SendFilesForUserByPrivateGalleryRepos(gallery);
        }

        public async Task<List<PrivateGalleryDetailsDTO>> GetPublicGalleries()
        {
           return await _galleryRepos.GetPublicGalleriesRepos();
        }
    }
}
