using BlogPhotographerSystem_Core.DTOs.Order;
using BlogPhotographerSystem_Core.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IServices
{
    public interface IOrderService
    {
        //Admin Management
        Task<OrderDetailsDTO> GetOrderDetailsById(int Id);
        Task<List<OrderDetailsDTO>> GetAllOrders();
        //Filter
        Task<OrderDetailsDTO> FilterOrderByTitleOrUserIdOrServiceIdOrStatus(string? title, int? userId, int? serviceId, string? status );

        //Create
        Task CreateNewOrder(CreateOrderAdminDTO dto);
        //Update
        Task UpdateOrder(UpdateOrderAdminDTO dto);
        //Delete
        Task DeleteOrder(UpdateOrderAdminDTO dto);
        //Client Management
        //Send
        Task SendOrderForSpecificService(CreateOrderClientDTO dto);
        //Cancel
        Task CancelOrderForSpecificService(CancelOrderClientDTO dto);
    }
}
