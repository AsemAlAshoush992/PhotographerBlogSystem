using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.Gallery;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
            if (gallery == null)
                throw new Exception("Gallery not found");
            gallery.ModifiedDate = DateTime.Now;
            gallery.ModifiedUserId = 1;
            gallery.IsDeleted = true;

            _context.Update(gallery);
            await _context.SaveChangesAsync();
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
                            Path = $"https://localhost:44358/{photo.Path}",
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
                            Path = $"https://localhost:44358/{video.Path}",
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
                            Path = $"https://localhost:44358/{gallery.Path}",
                            FileName = gallery.FileName,
                            FileType = gallery.FileType.ToString(),
                            IsPrivate = gallery.IsPrivate,
                            OrderID = gallery.OrderID,                           
                            IsDeleted = gallery.IsDeleted
                        };
            
            return await query.SingleOrDefaultAsync();
        }

        public async Task<List<PrivateGalleryDetailsForClientDTO>> GetAllPrivateGalleriesByUserIdWithoutOrdersRepos(int UserId)
        {
            var query = from privateGallery in _context.Galleries
                        where privateGallery.UserId == UserId
                        && privateGallery.IsPrivate == true
                        && privateGallery.IsDeleted == false
                        && privateGallery.OrderID == null
                        select new PrivateGalleryDetailsForClientDTO
                        {
                            Id = privateGallery.Id,
                            Path = $"https://localhost:44358/{privateGallery.Path}",
                            FileName = privateGallery.FileName,
                            FileType = privateGallery.FileType.ToString(),
                        };
            return await query.ToListAsync();
        }


        public async Task<List<PrivateGalleryOrderDetails>> GetAllPrivateGalleriesByUserId(int UserId)
        {
            var query = from user in _context.Users
                        join order in _context.Orders
                        on user.Id equals order.UserID
                        where user.Id == UserId
                        select new PrivateGalleryOrderDetails
                        {
                            OrderID = order.Id,
                            Images = (from privateGallery in _context.Galleries
                                      where privateGallery.OrderID == order.Id
                                      && privateGallery.IsPrivate == true
                                      && privateGallery.IsDeleted == false
                                      && privateGallery.FileType == (FileType)Enum.Parse(typeof(FileType), "Image")
                                      select $"https://localhost:44358/{privateGallery.Path}")
                                      .Distinct()
                                      .ToList()
                        };

            var result = await query.Where(o => o.Images.Any()).ToListAsync();

            return result;
        }


        public async Task<List<PrivateGalleryOrderDetails>> GetAllPrivateGalleriesVideosByUserId(int UserId)
        {
            var query = from user in _context.Users
                        join order in _context.Orders
                        on user.Id equals order.UserID
                        where user.Id == UserId
                        select new PrivateGalleryOrderDetails
                        {
                            OrderID = order.Id,
                            Images = (from privateGallery in _context.Galleries
                                      where privateGallery.OrderID == order.Id
                                      && privateGallery.IsPrivate == true
                                      && privateGallery.IsDeleted == false
                                      && privateGallery.FileType == (FileType)Enum.Parse(typeof(FileType), "Video")
                                      select $"https://localhost:44358/{privateGallery.Path}")
                                      .Distinct()
                                      .ToList()
                        };

            var result = await query.Where(o => o.Images.Any()).ToListAsync();

            return result;
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

            gallery.ModifiedDate = DateTime.Now;
            gallery.ModifiedUserId = 1;

            _context.Update(gallery);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PrivateGalleryDetailsDTO>> GetPublicGalleriesRepos()
        {
            var query = from gallery in _context.Galleries
                        where gallery.IsPrivate == false
                        && gallery.IsDeleted == false
                        select new PrivateGalleryDetailsDTO
                        {
                            Id = gallery.Id,
                            Path = $"https://localhost:44358/{gallery.Path}", 
                            FileName = gallery.FileName,
                            FileType = gallery.FileType.ToString(),
                            IsPrivate = gallery.IsPrivate,
                            OrderID = gallery.OrderID,
                            IsDeleted = gallery.IsDeleted
                        };
            return await query.ToListAsync();
        }

        public async Task UpdateFilesForClientByPrivateGallery(UpdatePrivateGalleryDTO dto)
        {
            var gallery = await _context.Galleries.SingleOrDefaultAsync(b => b.Id == dto.Id);

            if (gallery == null)
            {
                throw new Exception("Private Gallery File not found");
            }

            if (!string.IsNullOrEmpty(dto.Path))
            {
                gallery.Path = dto.Path;
            }

            if (!string.IsNullOrEmpty(dto.Path))
            {
                gallery.Path = dto.Path;
                gallery.FileName = Path.GetFileNameWithoutExtension(dto.Path);
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
                gallery.FileType = (FileType)Enum.Parse(typeof(FileType), fileType);
            }

            gallery.ModifiedDate = DateTime.Now;
            gallery.ModifiedUserId = 1;

            _context.Update(gallery);
            await _context.SaveChangesAsync();
        }
    }
}
