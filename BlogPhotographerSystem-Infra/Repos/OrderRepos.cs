using BlogPhotographerSystem_Core.DTOs.Order;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class OrderRepos : IOrderRepos
    {
        public Task CreateNewOrderRepos(Order order)
        {
            throw new NotImplementedException();
        }

        public Task CreateOrderForSpecificService(Order order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrderRepos(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailsDTO> FilterOrderByTitleOrUserIdOrServiceIdOrStatusRepos(string? title, int? userId, int? serviceId, string? status)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDetailsDTO>> GetAllOrdersRepos()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailsDTO> GetOrderDetailsByIdRepos(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderRepos(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
