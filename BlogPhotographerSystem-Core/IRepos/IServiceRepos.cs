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
        Task<List<ServiceInfoDTO>> GetAllServicesRepos();
        //Admin
        Task<List<ServiceDetailsDTO>> GetAllServicesForAdminRepos();
        Task<ServiceDetailsDTO> GetServiceDetailsByIdRepos(int Id);

        //Create
        Task CreateServiceRepos(Service service);
        //Update
        Task UpdateServiceRepos(UpdateServiceAdminDTO dto);
        //Delete
        Task DeleteServiceRepos(UpdateServiceAdminDTO dto);
    }
}
