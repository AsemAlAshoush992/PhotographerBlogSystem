using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.Category;
using BlogPhotographerSystem_Core.DTOs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IServices
{
    public interface IServiceService
    {
        //Guest Management
        Task<List<ServiceInfoDTO>> GetAllServices();
        //Admin Management
        Task<List<ServiceDetailsDTO>> GetAllServicesForAdmin();
        Task<ServiceDetailsDTO> GetServiceDetailsById(int Id);

        //Create
        Task CreateService(CreateServiceAdminDTO dto);
        //Update
        Task UpdateService(UpdateServiceAdminDTO dto);
        //Delete
        Task DeleteService(UpdateServiceAdminDTO dto);
    }
}
