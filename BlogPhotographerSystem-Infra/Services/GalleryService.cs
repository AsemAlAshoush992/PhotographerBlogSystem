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

        public async Task DeletePrivateGallery(int ID)
        {
            await _galleryRepos.DeletePrivateGalleryRepos(ID);
        }

        //Guest ManagementPhotosAndVideosInfoDTO
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

        public async Task<List<PrivateGalleryOrderDetails>> GetAllPrivateGalleriesByUserId(int UserId)
        {
            return await _galleryRepos.GetAllPrivateGalleriesByUserId(UserId);
        }

        public async Task<List<PrivateGalleryOrderDetails>> GetAllPrivateGalleriesVideosByUserId(int UserId)
        {
            return await _galleryRepos.GetAllPrivateGalleriesVideosByUserId(UserId);
        }
        public async Task<List<PrivateGalleryDetailsForClientDTO>> GetAllPrivateGalleriesByUserIdWithoutOrders(int UserId)
        {
            return await _galleryRepos.GetAllPrivateGalleriesByUserIdWithoutOrdersRepos(UserId);
        }

        public async Task SendFilesForUserByPrivateGallery(SendPrivateGalleryDTO dto)
        {
            string fileType;
            string extension = Path.GetExtension(dto.Path).ToUpperInvariant();

            if (extension == ".JPEG" || extension == ".JPG" || extension == ".PNG" || extension == ".GIF" || extension == ".TIFF" || extension == ".WEBP")
            {
                fileType = "Image";
            }
            else if (extension == ".MP4" || extension == ".AVI" || extension == ".MOV" || extension == ".WMV" || extension == ".MKV" || extension == ".FLV" || extension == ".WEBM")
            {
                fileType = "Video";
            }
            else
            {
                fileType = "Document";
            }
            Gallery gallery = new Gallery()
            {
                Path = dto.Path,
                FileName = Path.GetFileNameWithoutExtension(dto.Path),
                FileType = (FileType)Enum.Parse(typeof(FileType),fileType ),
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

        public async Task UploadFilesForUserByPrivateGallery(CreatePrivateGalleryDTO dto, int userId)
        {
            string fileType;
            string extension = Path.GetExtension(dto.Path).ToUpperInvariant();

            if (extension == ".JPEG" || extension == ".JPG" || extension == ".PNG" || extension == ".GIF" || extension == ".TIFF" || extension == ".WEBP")
            {
                fileType = "Image";
            }
            else if (extension == ".MP4" || extension == ".AVI" || extension == ".MOV" || extension == ".WMV" || extension == ".MKV" || extension == ".FLV" || extension == ".WEBM")
            {
                fileType = "Video";
            }
            else
            {
                fileType = "Document";
            }
            Gallery gallery = new Gallery()
            {
                Path = dto.Path,
                FileName = Path.GetFileNameWithoutExtension(dto.Path),
                FileType = (FileType)Enum.Parse(typeof(FileType), fileType),
                IsPrivate = true,
                UserId = userId
            };
            await _galleryRepos.SendFilesForUserByPrivateGalleryRepos(gallery);
        }

        public async Task<List<PrivateGalleryDetailsDTO>> GetPublicGalleries()
        {
           return await _galleryRepos.GetPublicGalleriesRepos();
        }

        public async Task UploadFilesForPublicGallery(CreatePublicGalleryDTO dto)
        {
            string fileType;
            string extension = Path.GetExtension(dto.Path).ToUpperInvariant();

            if (extension == ".JPEG" || extension == ".JPG" || extension == ".PNG" || extension == ".GIF" || extension == ".TIFF" || extension == ".WEBP")
            {
                fileType = "Image";
            }
            else if (extension == ".MP4" || extension == ".AVI" || extension == ".MOV" || extension == ".WMV" || extension == ".MKV" || extension == ".FLV" || extension == ".WEBM")
            {
                fileType = "Video";
            }
            else
            {
                fileType = "Document";
            }
            Gallery gallery = new Gallery()
            {
                Path = dto.Path,
                FileName = dto.FileName,
                FileType = (FileType)Enum.Parse(typeof(FileType), fileType),
                IsPrivate = false,
                CreatorUserId = 1
            };
            await _galleryRepos.SendFilesForUserByPrivateGalleryRepos(gallery);
        }
    }
}
