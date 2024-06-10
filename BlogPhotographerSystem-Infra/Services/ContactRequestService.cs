using BlogPhotographerSystem_Core.DTOs.ContactRequest;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using BlogPhotographerSystem_Infra.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class ContactRequestService : IContactRequestService
    {
        private readonly IContactRequestRepos _contactRequestRepos;

        public ContactRequestService(IContactRequestRepos contactRequestRepos)
        {
            _contactRequestRepos = contactRequestRepos;
        }

        public Task CreateNewContactRequest(CreateContactRequestDTO dto)
        {
            throw new NotImplementedException();
        }
        public Task<ContactRequestDetailsDTO> FilterContactRequestByPhoneOrEmailOrUserId(string? Phone, string? Email, int? UserId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ContactRequestDetailsDTO>> GetAllContactRequests()
        {
            return await _contactRequestRepos.GetAllContactRequestsRepos();
        }

        public async Task<ContactRequestDetailsDTO> GetContactRequestDetailsById(int Id)
        {
            return await _contactRequestRepos.GetContactRequestDetailsByIdRepos(Id);
        }

        public async Task SendContactRequestForService(CreateContactRequestDTO dto)
        {
            ContactRequest contact = new ContactRequest()
            {
                ClientName = dto.ClientName,
                Email = dto.Email,
                Phone = dto.Phone,
                Description = dto.Description,
                Purpose = dto.Purpose,
                Budget = dto.Budget,
                UserID = await _contactRequestRepos.GetUserID(dto.Email) != 0? await _contactRequestRepos.GetUserID(dto.Email) : null,
            };
            await _contactRequestRepos.CreateContactRequestForServiceRepos(contact);
        }

        public async Task UpdateContactRequest(UpdateContactRequestDTO dto)
        {
            await _contactRequestRepos.UpdateContactRequestRepos(dto);
        }
        public async Task DeleteContactRequest(int ID)
        {
            await _contactRequestRepos.DeleteContactRequestRepos(ID);
        }
    }
}
