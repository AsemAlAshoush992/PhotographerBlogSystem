using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.Category;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class CategoryRepos : ICategoryRepos
    {
        private readonly BlogPhotographerSystemDBContext _context;

        public CategoryRepos(BlogPhotographerSystemDBContext context)
        {
            _context = context;
        }
        //Guest Management 
        //Get All Categories Info
        public async Task<List<CategoriesInfoDTO>> GetAllCategoriesRepos()
        {
            var query = from category in _context.Categories
                        where category.IsDeleted == false
                        select new CategoriesInfoDTO
                        {
                            Id = category.Id,
                            Title = category.Title,
                            Description = category.Description,
                            ImagePath = $"https://localhost:44358/{category.ImagePath}"
                        };
            return await query.ToListAsync();
        }
        //Admin Management

        //Get Category Details
        public async Task<List<CategoryDetailsDTO>> GetCategoryDetailsRepos()
        {
            var query = from category in _context.Categories
                        where category.IsDeleted == false
                        select new CategoryDetailsDTO
                        {
                            Id = category.Id,
                            Title = category.Title,
                            Description = category.Description,
                            ImagePath = $"https://localhost:44358/{category.ImagePath}",
                            IsDeleted = category.IsDeleted
                        };
            return await query.ToListAsync();
        }
        //Get Category Details ById
        public async Task<CategoryDetailsDTO> GetCategoryDetailsByIdRepos(int Id)
        {
            var query = from category in _context.Categories
                        where category.Id == Id
                        select new CategoryDetailsDTO
                        {
                            Id = category.Id,
                            Title = category.Title,
                            Description = category.Description,
                            ImagePath = $"https://localhost:7071/{category.ImagePath}",                       
                            IsDeleted = category.IsDeleted
                        };
            return await query.SingleOrDefaultAsync();
        }

        //Create Category
        public async Task CreateCategoryRepos(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }
        //Update Category
        public async Task UpdateCategoryRepos(UpdateCategoryAdminDTO dto)
        {
            var query = await _context.Categories.SingleOrDefaultAsync(b => b.Id == dto.Id);

            if (query == null)
            {
                throw new Exception("Category not found");
            }

            if (!string.IsNullOrEmpty(dto.Title))
            {
                query.Title = dto.Title;
            }

            if (!string.IsNullOrEmpty(dto.Description))
            {
                query.Description = dto.Description;
            }
            if (!string.IsNullOrEmpty(dto.ImagePath))
            {
                query.ImagePath = dto.ImagePath;
            }

            query.ModifiedDate = DateTime.Now;
            query.ModifiedUserId = 1;

            _context.Update(query);
            await _context.SaveChangesAsync();
        }
        //Delete Category
        public async Task DeleteCategoryRepos(int ID)
        {
            var query = await _context.Categories.SingleOrDefaultAsync(b => b.Id == ID);
            if (query == null)
                throw new Exception("Category not found");
            query.ModifiedDate = DateTime.Now;
            query.ModifiedUserId = 1;
            query.IsDeleted = true;

            _context.Update(query);
            await _context.SaveChangesAsync();
        }
  
    }
}
