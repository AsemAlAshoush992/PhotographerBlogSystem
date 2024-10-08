﻿using BlogPhotographerSystem_Core.DTOs.Order;
using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IRepos
{
    public interface IOrderRepos
    {
        //Admin
        Task<OrderDetailsDTO> GetOrderDetailsByIdRepos(int Id);
        Task<List<OrderDetailsDTO>> GetAllOrdersRepos();
        //Filter
        Task<List<OrderDetailsDTO>> FilterOrderByTitleOrUserIdOrServiceIdOrStatusRepos(string? title, int? userId, int? serviceId, string? status);

        //Create
        Task CreateNewOrderRepos(Order order);
        //Update
        Task UpdateOrderRepos(UpdateOrderAdminDTO dto);
        //Delete
        Task DeleteOrderRepos(int ID);
        //Client Management
        //Create
        Task<int> CreateOrderForSpecificServiceRepos(Order order);
        Task<int> GetIdForSpecificService (string serviceName);
        Task CancelOrderForServiceRepos(CancelOrderClientDTO dto);

        //change status
        Task ChangeStatusSpecificOrderRepos(ChangeSatausDTO dto);
    }
}
