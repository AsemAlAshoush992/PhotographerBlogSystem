using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.Order;
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
                (b => b.UserID == dto.UserId && b.Id == dto.OrderId);
            order.ModifiedDate = DateTime.Now;
            order.ModifiedUserId = order.UserID;
            order.Status = Status.Cancelled;
            order.Note = dto.Reason;

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

        public async Task DeleteOrderRepos(UpdateOrderAdminDTO dto)
        {
            var order = await _context.Orders.SingleOrDefaultAsync(b => b.Id == dto.Id);
            order.ModifiedDate = DateTime.Now;
            order.ModifiedUserId = 1;
            order.IsDeleted = true;

            _context.Update(order);
            await _context.SaveChangesAsync();
        }

        public Task<OrderDetailsDTO> FilterOrderByTitleOrUserIdOrServiceIdOrStatusRepos(string? title, int? userId, int? serviceId, string? status)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDetailsDTO>> GetAllOrdersRepos()
        {
            throw new NotImplementedException();
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
                throw new Exception("Order not found");
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
