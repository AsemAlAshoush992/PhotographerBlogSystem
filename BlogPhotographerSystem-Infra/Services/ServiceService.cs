using BlogPhotographerSystem_Core.DTOs.Service;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using BlogPhotographerSystem_Infra.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Infra.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepos _serviceRepos;
        public ServiceService(IServiceRepos serviceRepos)
        {
            _serviceRepos = serviceRepos;
        }
        public async Task CreateService(CreateServiceAdminDTO dto)
        {
            Service service = new Service()
            {
                Name = dto.Name,
                Description = dto.Description,
                ImagePath = dto.ImagePath,
                Price = dto.Price,
                Quantity = dto.Quantity,
                IsHaveDiscount = dto.IsHaveDiscount,
                DisacountAmount = dto.DisacountAmount,
                DiscountType = (DiscountType)Enum.Parse(typeof(DiscountType), dto.DiscountType) ,
                CategoryID = dto.CategoryID
            };

            await _serviceRepos.CreateServiceRepos(service);
        }

        public async Task DeleteService(UpdateServiceAdminDTO dto)
        {
            await _serviceRepos.DeleteServiceRepos(dto);
        }

        public async Task<List<ServiceInfoDTO>> GetAllServices()
        {
            return await _serviceRepos.GetAllServicesRepos();
        }

        public Task<List<ServiceDetailsDTO>> GetAllServicesForAdmin()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceDetailsDTO> GetServiceDetailsById(int Id)
        {
            return await _serviceRepos.GetServiceDetailsByIdRepos(Id);
        }

        public async Task UpdateService(UpdateServiceAdminDTO dto)
        {
            await _serviceRepos.UpdateServiceRepos(dto);
        }
    }
}
