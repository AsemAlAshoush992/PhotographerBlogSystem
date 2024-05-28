using BlogPhotographerSystem_Core.DTOs.Service;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class ServiceRepos : IServiceRepos
    {
        public Task CreateServiceRepos(Service service)
        {
            throw new NotImplementedException();
        }

        public Task DeleteServiceRepos(Service service)
        {
            throw new NotImplementedException();
        }

        public Task<List<ServiceDetailsDTO>> GetAllServicesForAdminRepos()
        {
            throw new NotImplementedException();
        }

        public Task<List<ServiceInfoDTO>> GetAllServicesRepos()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceDetailsDTO> GetServiceDetailsByIdRepos(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateServiceRepos(Service service)
        {
            throw new NotImplementedException();
        }
    }
}
