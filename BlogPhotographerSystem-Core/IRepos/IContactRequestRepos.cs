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
        Task<List<ContactRequestDetailsDTO>> GetAllContactRequestDetailsByUserIdRepos(int userId);

        //Create
        Task CreateNewContactRequestRepos(ContactRequest contactRequest);
        //Update
        Task UpdateContactRequestRepos(UpdateContactRequestDTO dto);
        //Delete
        Task DeleteContactRequestRepos(int ID);
        //Client Management
        //Create
        Task CreateContactRequestForServiceRepos(ContactRequest contactRequest);
        Task<int> GetUserID(string email);
    }
}
