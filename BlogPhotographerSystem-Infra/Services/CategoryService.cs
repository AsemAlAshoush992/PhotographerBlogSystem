using BlogPhotographerSystem_Core.DTOs.Category;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using BlogPhotographerSystem_Infra.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class CategoryService : ICategoryService

    {
        private readonly ICategoryRepos _categoryRepos;

        public CategoryService(ICategoryRepos categoryRepos)
        {
            _categoryRepos = categoryRepos;
        }
        //Guest Management
        //Get All Categories Info
        public async Task<List<CategoriesInfoDTO>> GetAllCategories()
        {
            return await _categoryRepos.GetAllCategoriesRepos();
        }
        //Admin Management
        //Create Category
        public async Task CreateCategory(CreateCategoryAdminDTO dto)
        {
            Category category = new Category()
            {
                Title = dto.Title,
                Description = dto.Description,
                ImagePath = dto.ImagePath
            };
            await _categoryRepos.CreateCategoryRepos(category);
        }
        //Update Category
        public async Task UpdateCategory(UpdateCategoryAdminDTO dto)
        {
            await _categoryRepos.UpdateCategoryRepos(dto);
        }
        //Delete Category
        public async Task DeleteCategory(UpdateCategoryAdminDTO dto)
        {
            await _categoryRepos.DeleteCategoryRepos(dto);
        }
        //Get Category Details
        public async Task<List<CategoryDetailsDTO>> GetAllCategoriesForAdmin()
        {
            return await _categoryRepos.GetCategoryDetailsRepos();
        }
        //Get Category Details ById
        public async Task<CategoryDetailsDTO> GetCategoryDetailsById(int Id)
        {
            return await _categoryRepos.GetCategoryDetailsByIdRepos(Id);
        }
     
      
      
     
    }
}
