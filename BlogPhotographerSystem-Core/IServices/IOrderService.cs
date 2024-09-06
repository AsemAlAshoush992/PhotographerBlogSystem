using BlogPhotographerSystem_Core.DTOs.Order;
using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.Models.Entity;
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
        Task<List<OrderDetailsDTO>> FilterOrderByTitleOrUserIdOrServiceIdOrStatus(string? title, int? userId, int? serviceId, string? status );

        //Update
        Task UpdateOrder(UpdateOrderAdminDTO dto);
        //Delete
        Task DeleteOrder(int ID);
        //Client Management
        //Send
        Task<int> SendOrderForSpecificService(CreateOrderClientDTO dto,int userId);
        //Cancel
        Task CancelOrderForSpecificService(CancelOrderClientDTO dto);
        //change status
        Task ChangeStatusSpecificOrder(ChangeSatausDTO dto);
    }
}
