using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.ContactRequest;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class ContactRequestRepos : IContactRequestRepos
    {
        private readonly BlogPhotographerSystemDBContext _context;

        public ContactRequestRepos(BlogPhotographerSystemDBContext context)
        {
            _context = context;
        }
        public async Task<int> GetUserID(string email) 
        {
            var query = await _context.Users.SingleOrDefaultAsync(u => u.Email == email);
            if (query != null)
                return query.Id;
            else
                return 0;

        }
        public async Task CreateContactRequestForServiceRepos(ContactRequest contactRequest)
        {
            
            await _context.ContactRequests.AddAsync(contactRequest);
            await _context.SaveChangesAsync();
        }

        public Task CreateNewContactRequestRepos(ContactRequest contactRequest)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteContactRequestRepos(int ID)
        {
            var contact = await _context.ContactRequests.SingleOrDefaultAsync(b => b.Id == ID);
            contact.ModifiedDate = DateTime.Now;
            contact.ModifiedUserId = 1;
            contact.IsDeleted = true;

            _context.Update(contact);
            await _context.SaveChangesAsync();
        }

        public Task<ContactRequestDetailsDTO> FilterContactRequestByPhoneOrEmailOrUserIdRepos(string? Phone, string? Email, int? UserId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ContactRequestDetailsDTO>> GetAllContactRequestsRepos()
        {
            var query = from contact in _context.ContactRequests
                        select new ContactRequestDetailsDTO
                        {
                            Id = contact.Id,
                            ClientName = contact.ClientName,
                            Email = contact.Email,
                            Phone = contact.Phone,
                            Description = contact.Description,
                            Purpose = contact.Purpose,
                            Budget = contact.Budget,
                            UserID = contact.UserID,
                            CreationDate = contact.CreationDate,
                            ModifiedDate = contact.ModifiedDate,
                            CreatorUserId = contact.CreatorUserId,
                            ModifiedUserId = contact.ModifiedUserId,
                            IsDeleted = contact.IsDeleted
                        };
            return await query.ToListAsync();
        }

        public async Task<ContactRequestDetailsDTO> GetContactRequestDetailsByIdRepos(int Id)
        {
            var query = from contact in _context.ContactRequests
                        where contact.Id == Id
                        select new ContactRequestDetailsDTO
                        {
                            Id = contact.Id,
                            ClientName = contact.ClientName,
                            Email = contact.Email,
                            Phone = contact.Phone,
                            Description = contact.Description,
                            Purpose = contact.Purpose,
                            Budget = contact.Budget,
                            UserID = contact.UserID,
                            CreationDate = contact.CreationDate,
                            ModifiedDate = contact.ModifiedDate,
                            CreatorUserId = contact.CreatorUserId,
                            ModifiedUserId = contact.ModifiedUserId,
                            IsDeleted = contact.IsDeleted
                        };
            return await query.SingleOrDefaultAsync();
        }
        public async Task<List<ContactRequestDetailsDTO>> GetAllContactRequestDetailsByUserIdRepos(int userId)
        {
            var query = from contact in _context.ContactRequests
                        where contact.UserID == userId
                        select new ContactRequestDetailsDTO
                        {
                            Id = contact.Id,
                            ClientName = contact.ClientName,
                            Email = contact.Email,
                            Phone = contact.Phone,
                            Description = contact.Description,
                            Purpose = contact.Purpose,
                            Budget = contact.Budget,
                            UserID = contact.UserID,
                            CreationDate = contact.CreationDate,
                            ModifiedDate = contact.ModifiedDate,
                            CreatorUserId = contact.CreatorUserId,
                            ModifiedUserId = contact.ModifiedUserId,
                            IsDeleted = contact.IsDeleted
                        };
            return await query.ToListAsync();
        }
        public async Task UpdateContactRequestRepos(UpdateContactRequestDTO dto)
        {
            var contact = await _context.ContactRequests.SingleOrDefaultAsync(b => b.Id == dto.Id);

            if (contact == null)
            {
                throw new Exception("ContactRequest not found");
            }
            if (!string.IsNullOrEmpty(dto.Email))
            {
                contact.Email = dto.Email;
            }
            if (!string.IsNullOrEmpty(dto.ClientName))
            {
                contact.ClientName = dto.ClientName;
            }

            if (!string.IsNullOrEmpty(dto.Description))
            {
                contact.Description = dto.Description;
            }

            if (!string.IsNullOrEmpty(dto.Phone))
            {
                contact.Phone = dto.Phone;
            }
            if (!string.IsNullOrEmpty(dto.Purpose))
            {
                contact.Purpose = dto.Purpose;
            }

            if (dto.Budget.HasValue)
            {
                contact.Budget = dto.Budget.Value;
            }
            if (dto.UserID.HasValue)
            {
                contact.UserID = dto.UserID.Value;
            }

            contact.ModifiedDate = DateTime.Now;
            contact.ModifiedUserId = 1;

            _context.Update(contact);
            await _context.SaveChangesAsync();
        }
    }
}
