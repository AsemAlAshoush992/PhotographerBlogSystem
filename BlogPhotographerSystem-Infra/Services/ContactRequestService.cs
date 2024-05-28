using BlogPhotographerSystem_Core.DTOs.ContactRequest;
using BlogPhotographerSystem_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class ContactRequestService : IContactRequestService
    {
        public Task CreateNewContactRequest(CreateContactRequestDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteContactRequest(UpdateContactRequestDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<ContactRequestDetailsDTO> FilterContactRequestByPhoneOrEmailOrUserId(string? Phone, string? Email, int? UserId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactRequestDetailsDTO>> GetAllContactRequests()
        {
            throw new NotImplementedException();
        }

        public Task<ContactRequestDetailsDTO> GetContactRequestDetailsById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task SendContactRequestForService(CreateContactRequestDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateContactRequest(UpdateContactRequestDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
