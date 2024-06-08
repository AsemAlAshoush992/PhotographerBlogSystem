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
        Task<List<CategoryDetailsDTO>> GetCategoryDetailsRepos();

        //Create
        Task CreateCategoryRepos(Category category);
        //Update
        Task UpdateCategoryRepos(UpdateCategoryAdminDTO dto);
        //Delete
        Task DeleteCategoryRepos(UpdateCategoryAdminDTO dto);
    }
}
