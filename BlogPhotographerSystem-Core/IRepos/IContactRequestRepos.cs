using BlogPhotographerSystem_Core.DTOs.ContactRequest;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IRepos
{
    public interface IContactRequestRepos
    {
        //Admin Management
        Task<ContactRequestDetailsDTO> GetContactRequestDetailsByIdRepos(int Id);
        Task<List<ContactRequestDetailsDTO>> GetAllContactRequestsRepos();
        //Filter
        Task<ContactRequestDetailsDTO> FilterContactRequestByPhoneOrEmailOrUserIdRepos(string? Phone, string? Email, int? UserId);

        //Create
        Task CreateNewContactRequestRepos(ContactRequest contactRequest);
        //Update
        Task UpdateContactRequestRepos(ContactRequest contactRequest);
        //Delete
        Task DeleteContactRequestRepos(ContactRequest contactRequest);
        //Client Management
        //Create
        Task CreateContactRequestForServiceRepos(ContactRequest contactRequest);
    }
}
