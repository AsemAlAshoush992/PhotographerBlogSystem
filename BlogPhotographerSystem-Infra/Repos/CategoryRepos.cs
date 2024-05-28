using BlogPhotographerSystem_Core.DTOs.Category;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class CategoryRepos : ICategoryRepos
    {
        public Task CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryRepos(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoriesInfoDTO>> GetAllCategoriesRepos()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDetailsDTO> GetCategoryDetailsByIdRepos(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryRepos(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
