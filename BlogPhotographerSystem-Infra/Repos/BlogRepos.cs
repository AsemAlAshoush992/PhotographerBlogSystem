using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;
using static System.Reflection.Metadata.BlobBuilder;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class BlogRepos : IBlogRepos
    {
        private readonly BlogPhotographerSystemDBContext _context;

        public BlogRepos(BlogPhotographerSystemDBContext context)
        {
            _context = context;
        }
        //Admin Management
        public async Task<int> CreateBlogRepos(Blog blog)
        {
            await _context.Blogs.AddAsync(blog);
            await _context.SaveChangesAsync();
            return blog.Id;
        }
        public async Task CreateBlogAttachmentsRepos(BlogAttachement attachement)
        {
            await _context.BlogAttachements.AddAsync(attachement);
            await _context.SaveChangesAsync();
        }
        public async Task<List<BlogDetailsForUserDTO>> GetAllBlogsByUserIdRepos(int userId)
        {
            var query = from user in _context.Users
                        join blog in _context.Blogs
                        on user.Id equals blog.AuthorID
                        join attachement in _context.BlogAttachements
                        on blog.Id equals attachement.BlogID
                        where blog.AuthorID == userId
                        && blog.IsDeleted == false
                        && blog.IsApproved == true
            group new { blog, user, attachement } by new { blog.Id, blog.Title, blog.Article, blog.BlogDate, user.FirstName, user.LastName } into blogGroup
            select new BlogDetailsForUserDTO
            {
                Title = blogGroup.Key.Title,
                Article = blogGroup.Key.Article,
                BlogDate = blogGroup.Key.BlogDate,
                AuthorName = blogGroup.Key.FirstName + " " + blogGroup.Key.LastName,
                FilePaths = blogGroup.Select(bg => bg.attachement.Path).ToList()
            };
            return await query.ToListAsync();
        }
        public async Task<List<BlogsDetailsDTO>> GetAllBlogsDetailsRepos()
        {
            var query = from blog in _context.Blogs
                        select new BlogsDetailsDTO
                        {
                            ID = blog.Id,
                            Title = blog.Title,
                            Description = blog.Description,
                            Article = blog.Article,
                            BlogDate = blog.BlogDate,
                            IsApproved = blog.IsApproved,
                            AuthorID = blog.AuthorID,
                            CreationDate = blog.CreationDate,
                            CreatorUserId = blog.CreatorUserId,
                            ModifiedDate = blog.ModifiedDate,
                            ModifiedUserId = blog.ModifiedUserId,
                            IsDeleted = blog.IsDeleted
                        };
            return await query.ToListAsync();

        }

        public async Task<List<BlogsCardsDTO>> GetAllBlogsInfoRepos()
        {
            var query = from blogCards in _context.Blogs
                        join attachement in _context.BlogAttachements
                        on blogCards.Id equals attachement.BlogID
                        join user in _context.Users
                        on blogCards.AuthorID equals user.Id
                        where blogCards.IsDeleted == false
                        && blogCards.IsApproved == true
                        group new { blogCards, attachement, user } by new { blogCards.Id } into blogGroup
                        select new BlogsCardsDTO
                        {
                            Title = blogGroup.FirstOrDefault().blogCards.Title,
                            Description = blogGroup.FirstOrDefault().blogCards.Description,
                            BlogDate = blogGroup.FirstOrDefault().blogCards.BlogDate,
                            AuthorName = blogGroup.FirstOrDefault().user.FirstName + " " + blogGroup.FirstOrDefault().user.LastName,
                            ImagePath = blogGroup.FirstOrDefault().attachement.Path
                        } into blogCardsDTO
                        orderby blogCardsDTO.BlogDate descending
                        select blogCardsDTO;

            return await query.ToListAsync();
        }

        public async Task<BlogDetailsForUserDTO> GetBlogDetailsByIdRepos(int blogid)
        {
            var query = from blogD in _context.Blogs
                        join user in _context.Users
                        on blogD.AuthorID equals user.Id
                        join file in _context.BlogAttachements
                        on blogD.Id equals file.BlogID
                        where blogD.Id == blogid
                        && blogD.IsDeleted == false
                        && blogD.IsApproved == true
                        group new { blogD, user, file } by new { blogD.Id, blogD.Title, blogD.Article, blogD.BlogDate, user.FirstName, user.LastName } into blogGroup
                        select new BlogDetailsForUserDTO
                        {
                            Title = blogGroup.Key.Title,
                            Article = blogGroup.Key.Article,
                            BlogDate = blogGroup.Key.BlogDate,
                            AuthorName = blogGroup.Key.FirstName + " " + blogGroup.Key.LastName,
                            FilePaths = blogGroup.Select(bg => bg.file.Path).ToList()
                        };
            return await query.SingleOrDefaultAsync();
        }

        public async Task<BlogsDetailsDTO> GetBlogDetailsForAdminByIdRepos(int Id)
        {
            var query = from blogD in _context.Blogs
                        where blogD.Id == Id
                        select new BlogsDetailsDTO
                        {
                            ID = blogD.Id,
                            Title = blogD.Title,
                            Description = blogD.Description,
                            Article = blogD.Article,
                            BlogDate = blogD.BlogDate,
                            IsApproved = blogD.IsApproved,
                            AuthorID = blogD.AuthorID,
                            CreationDate = blogD.CreationDate,
                            ModifiedDate = blogD.ModifiedDate,
                            CreatorUserId = blogD.CreatorUserId,
                            ModifiedUserId = blogD.ModifiedUserId,
                            IsDeleted = blogD.IsDeleted
                        };
            return await query.SingleOrDefaultAsync();
        }

        public async Task UpdateBlogRepos(UpdateBlogAdminDTO dto)
        {
            var blog = await _context.Blogs.SingleOrDefaultAsync(b => b.Id == dto.Id);
            var Attachement = await _context.BlogAttachements.SingleOrDefaultAsync
                (b => b.BlogID == dto.Id && b.Id == dto.AttachementId);
            if (blog == null)
            {
                throw new Exception("Blog not found");
            }
            if (Attachement == null)
            {
                throw new Exception("File not found");
            }
            if (!string.IsNullOrEmpty(dto.Title))
            {
                blog.Title = dto.Title;
            }

            if (!string.IsNullOrEmpty(dto.Description))
            {
                blog.Description = dto.Description;
            }

            if (!string.IsNullOrEmpty(dto.Article))
            {
                blog.Article = dto.Article;
            }

            if (dto.IsApproved.HasValue)
            {
                blog.IsApproved = dto.IsApproved.Value;
            }

            if (dto.AuthorID.HasValue)
            {
                blog.AuthorID = dto.AuthorID.Value;
            }

            if (dto.BlogDate.HasValue)
            {
                blog.BlogDate = dto.BlogDate.Value;
            }
            if (!string.IsNullOrEmpty(dto.Path))
            {
                Attachement.Path = dto.Path;
            }

            if (!String.IsNullOrEmpty(dto.Path))
            {
                Attachement.FileName = Path.GetFileNameWithoutExtension(dto.Path);
            }
            if (!String.IsNullOrEmpty(dto.Path))
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
                Attachement.FileType = (FileType)Enum.Parse(typeof(FileType), fileType);
            }
            blog.BlogDate = DateTime.Now;
            blog.ModifiedDate = DateTime.Now;
            blog.ModifiedUserId = 1;

            _context.Blogs.Update(blog);
            _context.BlogAttachements.Update(Attachement);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteBlogRepos(int ID)
        {
            var blog = await _context.Blogs.SingleOrDefaultAsync(b => b.Id == ID);
            blog.ModifiedDate = DateTime.Now;
            blog.ModifiedUserId = blog.AuthorID;
            blog.IsDeleted = true;

            _context.Update(blog);
            await _context.SaveChangesAsync();
        }
        public async Task ConfirmUserBlogRepos(int blogID)
        {
            var blog = await _context.Blogs.SingleOrDefaultAsync(b => b.Id == blogID);
            blog.ModifiedDate = DateTime.Now;
            blog.ModifiedUserId = 1;
            blog.IsApproved = true;

            _context.Update(blog);
            await _context.SaveChangesAsync();
        }
        //Client Management

        public async Task UpdateClientBlogRepos(UpdateBlogClientDTO dto)
        {
            var blog = await _context.Blogs.SingleOrDefaultAsync(b => b.Id == dto.Id);
            var Attachement = await _context.BlogAttachements.SingleOrDefaultAsync
                (b => b.BlogID == dto.Id && b.Id == dto.AttachementId);

            if (blog == null)
            {
                throw new Exception("Blog not found");
            }

            if (Attachement == null)
            {
                throw new Exception("File not found");
            }

            if (!string.IsNullOrEmpty(dto.Title))
            {
                blog.Title = dto.Title;
            }

            if (!string.IsNullOrEmpty(dto.Article))
            {
                blog.Article = dto.Article;
            }
            if (!string.IsNullOrEmpty(dto.Path))
            {
                Attachement.Path = dto.Path;
            }
           
            if(!String.IsNullOrEmpty(dto.Path))
            {
                Attachement.FileName = Path.GetFileNameWithoutExtension(dto.Path);
            }
            if (!String.IsNullOrEmpty(dto.Path))
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
                Attachement.FileType = (FileType)Enum.Parse(typeof(FileType), fileType);
            }
            blog.BlogDate = DateTime.Now;
            blog.ModifiedDate = DateTime.Now;
            blog.ModifiedUserId = blog.AuthorID;

            _context.Blogs.Update(blog);
            _context.BlogAttachements.Update(Attachement);
            await _context.SaveChangesAsync();
        }
    }
}
