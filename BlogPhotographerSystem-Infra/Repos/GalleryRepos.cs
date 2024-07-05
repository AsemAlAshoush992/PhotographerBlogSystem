using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.Gallery;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class GalleryRepos : IGalleryRepos
    {
        private readonly BlogPhotographerSystemDBContext _context;

        public GalleryRepos(BlogPhotographerSystemDBContext context)
        {
            _context = context;
        }
        public async Task DeletePrivateGalleryRepos(int ID)
        {
            var gallery = await _context.Galleries.SingleOrDefaultAsync(b => b.Id == ID);
            gallery.ModifiedDate = DateTime.Now;
            gallery.ModifiedUserId = 1;
            gallery.IsDeleted = true;

            _context.Update(gallery);
            await _context.SaveChangesAsync();
        }

        public Task<PrivateGalleryDetailsDTO> FilterPrivateGalleryByFileTypeOrOrderIDRepos(string? FileType, int? orderID)
        {
            throw new NotImplementedException();
        }
        //Guest Management
        public async Task<List<PhotosAndVideosInfoDTO>> GetAllPhotosForPublicGalleryRepos()
        {
            var query = from photo in _context.Galleries
                        where photo.FileType == FileType.Image
                        && photo.IsPrivate == false
                        && photo.IsDeleted == false
                        orderby photo.CreationDate descending
                        select new PhotosAndVideosInfoDTO
                        {
                            Path = photo.Path,
                            FileName = photo.FileName
                        };
            return await query.ToListAsync();
        }

        public async Task<List<PhotosAndVideosInfoDTO>> GetAllVideosForPublicGalleryRepos()
        {
            var query = from video in _context.Galleries
                        where video.FileType == FileType.Video
                        && video.IsPrivate == false
                        && video.IsDeleted == false
                        orderby video.CreationDate descending
                        select new PhotosAndVideosInfoDTO
                        {
                            Path = video.Path,
                            FileName = video.FileName
                        };
            return await query.ToListAsync();
        }

        public async Task<PrivateGalleryDetailsDTO> GetPublicGalleryDetailsByIdRepos(int Id)
        {
            var query = from gallery in _context.Galleries
                        where gallery.Id == Id
                        && gallery.IsPrivate == false
                        select new PrivateGalleryDetailsDTO
                        {
                            Id = gallery.Id,
                            Path = gallery.Path,
                            FileName = gallery.FileName,
                            FileType = gallery.FileType.ToString(),
                            IsPrivate = gallery.IsPrivate,
                            OrderID = gallery.OrderID,
                            CreationDate = gallery.CreationDate,
                            ModifiedDate = gallery.ModifiedDate,
                            CreatorUserId = gallery.CreatorUserId,
                            ModifiedUserId = gallery.ModifiedUserId,
                            IsDeleted = gallery.IsDeleted
                        };
            
            return await query.SingleOrDefaultAsync();
        }

        public async Task<List<PrivateGalleryDetailsForClientDTO>> GetAllPrivateGalleriesByUserIdWithoutOrdersRepos(int UserId)
        {
            var query = from privateGallery in _context.Galleries
                        where privateGallery.CreatorUserId == UserId
                        && privateGallery.IsPrivate == true
                        && privateGallery.IsDeleted == false
                        && privateGallery.OrderID == null
                        select new PrivateGalleryDetailsForClientDTO
                        {
                            Path = privateGallery.Path,
                            FileName = privateGallery.FileName,
                            FileType = privateGallery.FileType.ToString(),
                            OrderID = privateGallery.OrderID
                        };
            return await query.ToListAsync();
        }


        public async Task<List<PrivateGalleryDetailsForClientDTO>> GetAllPrivateGalleriesByUserId(int UserId)
        {
            var query = from user in _context.Users
                        join order in _context.Orders
                        on user.Id equals order.UserID
                        join privateGallery in _context.Galleries
                        on order.Id equals privateGallery.OrderID
                        where user.Id == UserId
                        && privateGallery.IsPrivate == true
                        && privateGallery.IsDeleted == false
                        select new PrivateGalleryDetailsForClientDTO
                        {
                            Path = privateGallery.Path,
                            FileName = privateGallery.FileName,
                            FileType = privateGallery.FileType.ToString(),
                            OrderID = privateGallery.OrderID
                        };
            return await query.ToListAsync();
        }

        public async Task SendFilesForUserByPrivateGalleryRepos(Gallery gallery)
        {
            await _context.Galleries.AddAsync(gallery);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePrivateGalleryRepos(UpdateGalleryDTO dto)
        {
            var gallery = await _context.Galleries.SingleOrDefaultAsync(b => b.Id == dto.Id);

            if (gallery == null)
            {
                throw new Exception("Gallery File not found");
            }

            if (!string.IsNullOrEmpty(dto.Path))
            {
                gallery.Path = dto.Path;
            }

            if (!string.IsNullOrEmpty(dto.FileName))
            {
                gallery.FileName = dto.FileName;
            }

            if (!string.IsNullOrEmpty(dto.FileType))
            {
                gallery.FileType = (FileType)Enum.Parse(typeof(FileType), dto.FileType);

            }
            if (dto.IsPrivate.HasValue)
            {
                gallery.IsPrivate = dto.IsPrivate.Value;

            }
            if (dto.OrderID.HasValue)
            {
                gallery.OrderID = dto.OrderID.Value;

            }
            gallery.ModifiedDate = DateTime.Now;
            gallery.ModifiedUserId = 1;

            _context.Update(gallery);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PrivateGalleryDetailsDTO>> GetPublicGalleriesRepos()
        {
            var query = from gallery in _context.Galleries
                        where gallery.IsPrivate == true
                        select new PrivateGalleryDetailsDTO
                        {
                            Id = gallery.Id,
                            Path = gallery.Path,
                            FileName = gallery.FileName,
                            FileType = gallery.FileType.ToString(),
                            IsPrivate = gallery.IsPrivate,
                            OrderID = gallery.OrderID,
                            CreationDate = gallery.CreationDate,
                            ModifiedDate = gallery.ModifiedDate,
                            CreatorUserId = gallery.CreatorUserId,
                            ModifiedUserId = gallery.ModifiedUserId,
                            IsDeleted = gallery.IsDeleted
                        };
            return await query.ToListAsync();
        }

        public async Task UpdateFilesForClientByPrivateGallery(UpdatePrivateGalleryDTO dto)
        {
            var gallery = await _context.Galleries.SingleOrDefaultAsync(b => b.Id == dto.Id);

            if (gallery == null)
            {
                throw new Exception("PrivateGallery File not found");
            }

            if (!string.IsNullOrEmpty(dto.Path))
            {
                gallery.Path = dto.Path;
            }

            if (!string.IsNullOrEmpty(dto.FileName))
            {
                gallery.FileName = dto.FileName;
            }

            if (!string.IsNullOrEmpty(dto.FileType))
            {
                gallery.FileType = (FileType)Enum.Parse(typeof(FileType), dto.FileType);

            }
           
            gallery.ModifiedDate = DateTime.Now;
            gallery.ModifiedUserId = 1;

            _context.Update(gallery);
            await _context.SaveChangesAsync();
        }
    }
}
