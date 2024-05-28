using BlogPhotographerSystem_Core.DTOs.Order;
using BlogPhotographerSystem_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class OrderService : IOrderService
    {
        public Task CancelOrderForSpecificService(CancelOrderClientDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateNewOrder(CreateOrderAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrder(UpdateOrderAdminDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailsDTO> FilterOrderByTitleOrUserIdOrServiceIdOrStatus(string? title, int? userId, int? serviceId, string? status)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDetailsDTO>> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailsDTO> GetOrderDetailsById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task SendOrderForSpecificService(CreateOrderClientDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrder(UpdateOrderAdminDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
