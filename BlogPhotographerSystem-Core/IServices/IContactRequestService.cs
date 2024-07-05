using BlogPhotographerSystem_Core.DTOs.BlogAttachement;
using BlogPhotographerSystem_Core.DTOs.ContactRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IServices
{
    public interface IContactRequestService
    {
        //Admin Management
        Task<ContactRequestDetailsDTO> GetContactRequestDetailsById(int Id);
        Task<List<ContactRequestDetailsDTO>> GetAllContactRequests();
        Task<List<ContactRequestDetailsDTO>> GetAllContactRequestDetailsByUserId(int UserId);
        //Update
        Task UpdateContactRequest(UpdateContactRequestDTO dto);
        //Delete
        Task DeleteContactRequest(int ID);
        //Client Management
        //Send
        Task SendContactRequestForService(CreateContactRequestDTO dto);
        
    }
}
