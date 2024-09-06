using BlogPhotographerSystem_Core.DTOs.Service;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IRepos
{
    public interface IServiceRepos
    {
        //Guest
        Task<List<ServiceInfoDTO>> GetAllServicesRepos(int Id);
        //Admin
        Task<List<ServiceDetailsDTO>> GetAllServicesForAdminRepos();
        Task<ServiceDetailsDTO> GetServiceDetailsByIdRepos(int Id);
        //Filter
        Task<List<ServiceDetailsDTO>> FilterServicesByNameOrPriceOrQuantityRepos(string? Name, float? Price, int? Quantity);
        //Create
        Task CreateServiceRepos(Service service);
        //Update
        Task UpdateServiceRepos(UpdateServiceAdminDTO dto);
        //Delete
        Task DeleteServiceRepos(int ID);
    }
}
