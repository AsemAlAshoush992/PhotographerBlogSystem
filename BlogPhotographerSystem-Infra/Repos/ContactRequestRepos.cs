using BlogPhotographerSystem_Core.DTOs.ContactRequest;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class ContactRequestRepos : IContactRequestRepos
    {
        public Task CreateContactRequestForServiceRepos(ContactRequest contactRequest)
        {
            throw new NotImplementedException();
        }

        public Task CreateNewContactRequestRepos(ContactRequest contactRequest)
        {
            throw new NotImplementedException();
        }

        public Task DeleteContactRequestRepos(ContactRequest contactRequest)
        {
            throw new NotImplementedException();
        }

        public Task<ContactRequestDetailsDTO> FilterContactRequestByPhoneOrEmailOrUserIdRepos(string? Phone, string? Email, int? UserId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactRequestDetailsDTO>> GetAllContactRequestsRepos()
        {
            throw new NotImplementedException();
        }

        public Task<ContactRequestDetailsDTO> GetContactRequestDetailsByIdRepos(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateContactRequestRepos(ContactRequest contactRequest)
        {
            throw new NotImplementedException();
        }
    }
}
