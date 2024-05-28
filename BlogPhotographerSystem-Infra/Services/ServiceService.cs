using BlogPhotographerSystem_Core.DTOs.Service;
using BlogPhotographerSystem_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class ServiceService : IServiceService
    {
        public Task CreateService(CreateServiceAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteService(UpdateServiceAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ServiceInfoDTO>> GetAllServices()
        {
            throw new NotImplementedException();
        }

        public Task<List<ServiceDetailsDTO>> GetAllServicesForAdmin()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceDetailsDTO> GetServiceDetailsById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateService(UpdateServiceAdminDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
