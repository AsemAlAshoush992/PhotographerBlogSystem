using BlogPhotographerSystem_Core.DTOs.Category;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IRepos
{
    public interface ICategoryRepos
    {
        //Guest
        Task<List<CategoriesInfoDTO>> GetAllCategoriesRepos();
        //Admin
        Task<CategoryDetailsDTO> GetCategoryDetailsByIdRepos(int Id);

        //Create
        Task CreateCategory(Category category);
        //Update
        Task UpdateCategoryRepos(Category category);
        //Delete
        Task DeleteCategoryRepos(Category category);
    }
}
