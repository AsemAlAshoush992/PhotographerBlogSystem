using BlogPhotographerSystem_Core.DTOs.Order;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using BlogPhotographerSystem_Infra.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Infra.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepos _orderRepos;

        public OrderService(IOrderRepos orderRepos)
        {
            _orderRepos = orderRepos;
        }

        public async Task CancelOrderForSpecificService(CancelOrderClientDTO dto)
        {
            await _orderRepos.CancelOrderForServiceRepos(dto);
        }

        public Task CreateNewOrder(CreateOrderAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteOrder(int ID)
        {
            await _orderRepos.DeleteOrderRepos(ID);

        }

        public Task<OrderDetailsDTO> FilterOrderByTitleOrUserIdOrServiceIdOrStatus(string? title, int? userId, int? serviceId, string? status)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDetailsDTO>> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public async Task<OrderDetailsDTO> GetOrderDetailsById(int Id)
        {
            return await _orderRepos.GetOrderDetailsByIdRepos(Id);
        }

        public async Task SendOrderForSpecificService(CreateOrderClientDTO dto)
        {
            Order order = new Order()
            {
                OrderDate = DateTime.Now,
                Title = dto.Title,
                Note = dto.Note,
                Status = Status.Pending,
                PaymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), dto.PaymentMethod),
                UserID = dto.UserID,
                ServiceID = await _orderRepos.GetIdForSpecificService(dto.ServiceName),
            };
            await _orderRepos.CreateOrderForSpecificServiceRepos(order);

        }

        public async Task UpdateOrder(UpdateOrderAdminDTO dto)
        {
            await _orderRepos.UpdateOrderRepos(dto);
        }
    }
}
