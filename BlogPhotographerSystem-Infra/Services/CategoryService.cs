using BlogPhotographerSystem_Core.DTOs.Category;
using BlogPhotographerSystem_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class CategoryService : ICategoryService

    {
        public Task CreateCategoryRepos(CreateCategoryAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategory(UpdateCategoryAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoriesInfoDTO>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDetailsDTO>> GetAllCategoriesForAdmin()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDetailsDTO> GetCategoryDetailsById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategory(UpdateCategoryAdminDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
