using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.Service;
using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class ServiceRepos : IServiceRepos
    {
        private readonly BlogPhotographerSystemDBContext _context;

        public ServiceRepos(BlogPhotographerSystemDBContext context)
        {
            _context = context;
        }
        public async Task<List<ServiceDetailsDTO>> FilterServicesByNameOrPriceOrQuantityRepos(string? name, float? price, int? quantity)
        {
            bool flag = name == null && price == null && quantity == null ? true : false;
            var query = from filter in _context.Services
                        where filter.Name == name || filter.Price >= price || filter.Quantity >= quantity || flag
                        select new ServiceDetailsDTO
                        {
                            Id = filter.Id,
                            Name = filter.Name,
                            Description = filter.Description,
                            ImagePath = $"https://localhost:7071/{filter.ImagePath}",
                            Price = filter.Price,
                            Quantity = filter.Quantity,
                            IsHaveDiscount = filter.IsHaveDiscount,
                            DisacountAmount = filter.DisacountAmount,
                            DiscountType = filter.DiscountType.ToString(),
                            CategoryID = filter.CategoryID,
                            CreationDate = filter.CreationDate,
                            ModifiedDate = filter.ModifiedDate,
                            CreatorUserId = filter.CreatorUserId,
                            ModifiedUserId = filter.ModifiedUserId,
                            IsDeleted = filter.IsDeleted

                        };
            return await query.ToListAsync();

        }
        public async Task<List<ServiceInfoDTO>> GetAllServicesRepos()
        {
            var query = from service in _context.Services
                        join category in _context.Categories
                        on service.CategoryID equals category.Id
                        where service.IsDeleted == false
                        select new ServiceInfoDTO
                        {
                            Name = service.Name,
                            Description = service.Description,
                            ImagePath = $"https://localhost:7071/{service.ImagePath}",
                            Price = service.Price,
                            Quantity = service.Quantity != null ? service.Quantity.Value : 0,
                            DisacountAmount = service.DisacountAmount != null ? service.DisacountAmount + "%" : 0 + "%",
                            CategoryName = category.Title
                        };
            return await query.ToListAsync();
        }
        //Admin Management
        //Create Service
        public async Task CreateServiceRepos(Service service)
        {
            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();
        }
        //Update Service
        public async Task UpdateServiceRepos(UpdateServiceAdminDTO dto)
        {
            var service = await _context.Services.SingleOrDefaultAsync(b => b.Id == dto.Id);

            if (service == null)
            {
                throw new Exception("Service not found");
            }

            if (!string.IsNullOrEmpty(dto.Name))
            {
                service.Name = dto.Name;
            }

            if (!string.IsNullOrEmpty(dto.Description))
            {
                service.Description = dto.Description;
            }

            if (!string.IsNullOrEmpty(dto.ImagePath))
            {
                service.ImagePath = dto.ImagePath;
            }
            if (!string.IsNullOrEmpty(dto.DiscountType))
            {
                service.DiscountType = (DiscountType)Enum.Parse(typeof(DiscountType), dto.DiscountType);
            }
            if (dto.Price.HasValue)
            {
                service.Price = dto.Price.Value;
            }

            if (dto.Quantity.HasValue)
            {
                service.Quantity = dto.Quantity.Value;
            }

            if (dto.IsHaveDiscount.HasValue)
            {
                service.IsHaveDiscount = dto.IsHaveDiscount.Value;
            }
            if (dto.DisacountAmount.HasValue)
            {
                service.DisacountAmount = dto.DisacountAmount.Value;
            }

            if (dto.CategoryID.HasValue)
            {
                service.CategoryID = dto.CategoryID.Value;
            }

            service.ModifiedDate = DateTime.Now;
            service.ModifiedUserId = 1;

            _context.Update(service);
            await _context.SaveChangesAsync();
        }

        //Delete Service
        public async Task DeleteServiceRepos(int ID)
        {
            var service = await _context.Services.SingleOrDefaultAsync(b => b.Id == ID);
            service.ModifiedDate = DateTime.Now;
            service.ModifiedUserId = 1;
            service.IsDeleted = true;

            _context.Update(service);
            await _context.SaveChangesAsync();
        }
        //Get All Services Details
        public async Task<List<ServiceDetailsDTO>> GetAllServicesForAdminRepos()
        {
            var query = from service in _context.Services
                        select new ServiceDetailsDTO
                        {
                            Id = service.Id,
                            Name = service.Name,
                            Description = service.Description,
                            ImagePath = $"https://localhost:7071/{service.ImagePath}",
                            Price = service.Price,
                            Quantity = service.Quantity,
                            IsHaveDiscount = service.IsHaveDiscount,
                            DisacountAmount = service.DisacountAmount,
                            DiscountType = service.DiscountType.ToString(),
                            CategoryID = service.CategoryID,
                            IsDeleted = service.IsDeleted
                        };
            return await query.ToListAsync();
        }

        //Get Services Details By Id
        public async Task<ServiceDetailsDTO> GetServiceDetailsByIdRepos(int Id)
        {
            var query = from service in _context.Services
                        where service.Id == Id
                        select new ServiceDetailsDTO
                        {
                            Id = service.Id,
                            Name = service.Name,
                            Description = service.Description,
                            ImagePath = $"https://localhost:7071/{service.ImagePath}",
                            Price = service.Price,
                            Quantity = service.Quantity,
                            IsHaveDiscount = service.IsHaveDiscount,
                            DisacountAmount = service.DisacountAmount,
                            DiscountType = service.DiscountType.ToString(),
                            CategoryID = service.CategoryID,
                            CreationDate = service.CreationDate,
                            ModifiedDate = service.ModifiedDate,
                            CreatorUserId = service.CreatorUserId,
                            ModifiedUserId = service.ModifiedUserId,
                            IsDeleted = service.IsDeleted
                        };
            return await query.SingleOrDefaultAsync();
        }


    }
}
