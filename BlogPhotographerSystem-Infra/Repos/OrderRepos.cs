using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.Order;
using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class OrderRepos : IOrderRepos
    {
        private readonly BlogPhotographerSystemDBContext _context;

        public OrderRepos(BlogPhotographerSystemDBContext context)
        {
            _context = context;
        }

        public async Task CancelOrderForServiceRepos(CancelOrderClientDTO dto)
        {
            var order = await _context.Orders.SingleOrDefaultAsync
                (b => b.Id == dto.OrderId);
            order.ModifiedDate = DateTime.Now;
            order.ModifiedUserId = order.UserID;
            order.Status = Status.Cancelled;
            if(!string.IsNullOrEmpty(dto.Reason)) 
            { 
                order.Note = dto.Reason;
            }

            _context.Update(order);
            await _context.SaveChangesAsync();
        }

        public Task CreateNewOrderRepos(Order order)
        {
            throw new NotImplementedException();
        }

        public async Task CreateOrderForSpecificServiceRepos(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrderRepos(int ID)
        {
            var order = await _context.Orders.SingleOrDefaultAsync(b => b.Id == ID);
            order.ModifiedDate = DateTime.Now;
            order.ModifiedUserId = 1;
            order.IsDeleted = true;

            _context.Update(order);
            await _context.SaveChangesAsync();
        }

        public async Task<List<OrderDetailsDTO>> FilterOrderByTitleOrUserIdOrServiceIdOrStatusRepos(string? title, int? userId, int? serviceId, string? status)
        {
            Status foo = Status.None;
            if (!string.IsNullOrEmpty(status) && Enum.IsDefined(typeof(Status), status))
            {
                foo = (Status)Enum.Parse(typeof(Status), status);
            }

            bool flag = title == null && userId == null && serviceId == null && status == null ? true : false;
            var query = from filter in _context.Orders
                        where filter.Title == title || filter.UserID == userId || filter.ServiceID == serviceId || filter.Status == foo || flag
                        select new OrderDetailsDTO
                        {
                            Id = filter.Id,
                            OrderDate = filter.OrderDate,
                            Title = filter.Title,
                            Note = filter.Note,
                            Status = filter.Status.ToString(),
                            PaymentMethod = filter.PaymentMethod.ToString(),
                            UserID = filter.UserID,
                            ServiceID = filter.ServiceID,
                            CreationDate = filter.CreationDate,
                            ModifiedDate = filter.ModifiedDate,
                            CreatorUserId = filter.CreatorUserId,
                            ModifiedUserId = filter.ModifiedUserId,
                            IsDeleted = filter.IsDeleted

                        };
            return await query.ToListAsync();

        }

        public async Task<List<OrderDetailsDTO>> GetAllOrdersRepos()
        {
            var query = from order in _context.Orders
                        select new OrderDetailsDTO
                        {
                            Id= order.Id,
                            OrderDate = order.OrderDate,
                            Title = order.Title,
                            Note = order.Note,
                            Status = order.Status.ToString(),
                            PaymentMethod = order.PaymentMethod.ToString(),
                            UserID = order.UserID,
                            ServiceID = order.ServiceID,
                            CreationDate = order.CreationDate,
                            ModifiedDate = order.ModifiedDate,
                            CreatorUserId = order.CreatorUserId,
                            ModifiedUserId = order.ModifiedUserId,
                            IsDeleted = order.IsDeleted,
                        };
            return await query.ToListAsync();
        }

        public async Task<int> GetIdForSpecificService(string serviceName)
        {
            var getID = await _context.Services.SingleOrDefaultAsync(x => x.Name == serviceName);
            return getID.Id;
        }

        public async Task<OrderDetailsDTO> GetOrderDetailsByIdRepos(int Id)
        {
            var query = from order in _context.Orders
                        where order.Id == Id
                        select new OrderDetailsDTO
                        {
                            Id = order.Id,
                            OrderDate = order.OrderDate,
                            Title = order.Title,
                            Note = order.Note,
                            Status = order.Status.ToString(),
                            PaymentMethod = order.PaymentMethod.ToString(),
                            UserID = order.UserID,
                            ServiceID = order.ServiceID,
                            CreationDate = order.CreationDate,
                            ModifiedDate = order.ModifiedDate,
                            CreatorUserId = order.CreatorUserId,
                            ModifiedUserId = order.ModifiedUserId,
                            IsDeleted = order.IsDeleted,
                        };
            return await query.SingleOrDefaultAsync();
        }

        public async Task UpdateOrderRepos(UpdateOrderAdminDTO dto)
        {
            var oder = await _context.Orders.SingleOrDefaultAsync(b => b.Id == dto.Id);

            if (oder == null)
            {
                throw new Exception("The order not found");
            }

            if (!string.IsNullOrEmpty(dto.Title))
            {
                oder.Title = dto.Title;
            }

            if (!string.IsNullOrEmpty(dto.Note))
            {
                oder.Note = dto.Note;
            }

            if (!string.IsNullOrEmpty(dto.Status))
            {
                oder.Status = (Status)Enum.Parse(typeof(Status), dto.Status);

            }

            if (!string.IsNullOrEmpty(dto.PaymentMethod))
            {
                oder.PaymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), dto.PaymentMethod);

            }

            if (dto.UserID.HasValue)
            {
                oder.UserID = dto.UserID.Value;
            }

            if (dto.ServiceID.HasValue)
            {
                oder.ServiceID = dto.ServiceID.Value;
            }
            oder.ModifiedDate = DateTime.Now;
            oder.ModifiedUserId = 1;

            _context.Update(oder);
            await _context.SaveChangesAsync();
        }
    }
}
