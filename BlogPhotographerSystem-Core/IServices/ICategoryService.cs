using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.Category;
using BlogPhotographerSystem_Core.DTOs.Service;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IServices
{
    public interface ICategoryService
    {
        //Guest Management
        Task<List<CategoriesInfoDTO>> GetAllCategories();
        //Admin Management
        Task<List<CategoryDetailsDTO>> GetAllCategoriesForAdmin();
        Task<CategoryDetailsDTO> GetCategoryDetailsById(int Id);

        //Create
        Task CreateCategory(CreateCategoryAdminDTO dto);
        //Update
        Task UpdateCategory(UpdateCategoryAdminDTO dto);
        //Delete
        Task DeleteCategory(int ID);
    }
}
