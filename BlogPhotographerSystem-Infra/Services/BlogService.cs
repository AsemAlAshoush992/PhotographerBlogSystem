using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Infra.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepos _blogRepos;
        public BlogService(IBlogRepos blogRepos)
        {
            _blogRepos = blogRepos;
        }

        public async Task<List<BlogsDetailsDTO>> GetAllBlogsDetails()
        {
            return await _blogRepos.GetAllBlogsDetailsRepos();

        }
        //Guest Management
        public async Task<List<BlogsCardsDTO>> GetAllBlogsInfo()
        {
            return await _blogRepos.GetAllBlogsInfoRepos();
        }
        public async Task<List<BlogDetailsForUserDTO>> GetAllBlogsByUserId(int userId)
        {
            return await _blogRepos.GetAllBlogsByUserIdRepos(userId);
        }
        public async Task SendClientBlogRequest(CreateBlogAdminDTO dto)
        {
            Blog blog = new Blog()
            {
                Title = dto.Title,
                Description = dto.Description,
                Article = dto.Article,
                BlogDate = DateTime.Now,
                IsApproved = false,
                AuthorID = dto.AuthorId
            };
            int blogId = await _blogRepos.CreateBlogRepos(blog);
            foreach (var attachmentDto in dto.FilePath)
            {
               
                string fileType;
               string extension = Path.GetExtension(attachmentDto).ToUpperInvariant();

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
              
     
                BlogAttachement attachement = new BlogAttachement()
                {
                    Path = attachmentDto,
                    FileName = Path.GetFileNameWithoutExtension(attachmentDto),
                    FileType = (FileType)Enum.Parse(typeof(FileType), fileType),
                    BlogID = blogId,
                    CreatorUserId = 1
                };
                await _blogRepos.CreateBlogAttachmentsRepos(attachement);
            }
        }
       
        //Admin Management 
        public async Task<BlogDetailsForUserDTO> GetBlogDetailsById(int blogid)
        {
            return await _blogRepos.GetBlogDetailsByIdRepos(blogid);
        }

        public async Task<BlogsDetailsDTO> GetBlogDetailsForAdminById(int Id)
        {
            return await _blogRepos.GetBlogDetailsForAdminByIdRepos(Id);
        }

        public async Task CreateBlog(CreateBlogAdminDTO dto)
        {

            Blog blog = new Blog()
            {
                Title = dto.Title,
                Description = dto.Description,
                Article = dto.Article,
                BlogDate = DateTime.Now,
                IsApproved = true,
                AuthorID = 1
            };

            int blogId = await _blogRepos.CreateBlogRepos(blog);

            foreach (var attachmentDto in dto.FilePath)
            {

                string fileType;
                string extension = Path.GetExtension(attachmentDto).ToUpperInvariant();

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

                
                BlogAttachement attachement = new BlogAttachement()
                {
                    Path = attachmentDto,
                    FileName = Path.GetFileNameWithoutExtension(attachmentDto),
                    FileType = (FileType)Enum.Parse(typeof(FileType), fileType),
                    BlogID = blogId
                };
                await _blogRepos.CreateBlogAttachmentsRepos(attachement);
            }
        }

        public async Task UpdateBlog(UpdateBlogAdminDTO dto)
        {
             await _blogRepos.UpdateBlogRepos(dto);
        }

        public async Task DeleteBlog(int ID)
        {
            await _blogRepos.DeleteBlogRepos(ID);
        }

        public async Task ConfirmUserBlog(int blogID)
        {
            await _blogRepos.ConfirmUserBlogRepos(blogID);
        }
        //Client Management
        public async Task UpdateClientBlog(UpdateBlogClientDTO dto)
        {
            await _blogRepos.UpdateClientBlogRepos(dto);
        }
    }
}
