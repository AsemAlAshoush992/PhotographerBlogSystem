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

        public async Task DeleteOrder(int ID)
        {
            await _orderRepos.DeleteOrderRepos(ID);

        }

        public async Task<List<OrderDetailsDTO>> FilterOrderByTitleOrUserIdOrServiceIdOrStatus(string? title, int? userId, int? serviceId, string? status)
        {
            return await _orderRepos.FilterOrderByTitleOrUserIdOrServiceIdOrStatusRepos(title, userId, serviceId, status);
        }

        public async Task<List<OrderDetailsDTO>> GetAllOrders()
        {
            return await _orderRepos.GetAllOrdersRepos();
        }

        public async Task<OrderDetailsDTO> GetOrderDetailsById(int Id)
        {
            return await _orderRepos.GetOrderDetailsByIdRepos(Id);
        }

        public async Task SendOrderForSpecificService(CreateOrderClientDTO dto)
        {
            string message;
            if (dto.ServiceName == "Wedding Package")
            {
                message = "Need full wedding coverage.";
            }
            else if (dto.ServiceName == "Portrait Session")
            {
                message = "Portrait session for portfolio.";
            }
            else if (dto.ServiceName == "Travel Photoshoot")
            {
                message = "Travel photos for blog.";
            }
            else if (dto.ServiceName == "Event Coverage")
            {
                message = "Corporate event coverage.";
            }
            else if (dto.ServiceName == "Product Photography")
            {
                message = "Photos for online store.";
            }

            else if (dto.ServiceName == "Fashion Shoot")
            {
                message = "Fashion shoot for magazine.";
            }
            else if (dto.ServiceName == "Sports Photography")
            {
                message = "Photos for sports team.";
            }
            else if (dto.ServiceName == "Wildlife Session")
            {
                message = "Wildlife photography session.";
            }
            else if (dto.ServiceName == "Astrophotography")
            {
                message = "Astrophotography session.";
            }
            else 
            {
                message = "Macro photos for project.";
            }

            Order order = new Order()
            {
                OrderDate = DateTime.Now,
                Title = dto.ServiceName + " " + "Order",
                Note = message,
                Status = Status.Pending,
                PaymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), dto.PaymentMethod),
                UserID = dto.UserID,
                ServiceID = await _orderRepos.GetIdForSpecificService(dto.ServiceName)
            };
            await _orderRepos.CreateOrderForSpecificServiceRepos(order);
        }

        public async Task UpdateOrder(UpdateOrderAdminDTO dto)
        {
            await _orderRepos.UpdateOrderRepos(dto);
        }
    }
}
