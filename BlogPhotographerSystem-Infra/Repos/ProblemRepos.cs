using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.Problem;
using BlogPhotographerSystem_Core.DTOs.Service;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlogPhotographerSystem_Infra.Repos
{

    public class ProblemRepos : IProblemRepos
    {
        private readonly BlogPhotographerSystemDBContext _context;

        public ProblemRepos(BlogPhotographerSystemDBContext context)
        {
            _context = context;
        }
        public async Task CreateNewProblemRepos(Problem problem)
        {
            await _context.Problems.AddAsync(problem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProblemRepos(int ID)
        {
            var problem = await _context.Problems.SingleOrDefaultAsync(b => b.Id == ID);
            problem.ModifiedDate = DateTime.Now;
            problem.ModifiedUserId = 1;
            problem.IsDeleted = true;

            _context.Update(problem);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ProblemDetailsDTO>> FilterProblemByUserIdOrOrderIdRepos(int? userId , int? orderId)
        {
            bool flag = userId == null && orderId == null? true : false;
            var query = from filter in _context.Problems
                        where filter.UserID == userId || filter.OrderID == orderId || flag
                        select new ProblemDetailsDTO
                        {
                            Id = filter.Id,
                            Title = filter.Title,
                            Purpose = filter.Purpose,
                            Description = filter.Description,
                            UserID = filter.UserID,
                            OrderID = filter.OrderID,
                            CreationDate = filter.CreationDate,
                            ModifiedDate = filter.ModifiedDate,
                            CreatorUserId = filter.CreatorUserId,
                            ModifiedUserId = filter.ModifiedUserId,
                            IsDeleted = filter.IsDeleted

                        };
            return await query.ToListAsync();
        }

        public async Task<List<ProblemDetailsDTO>> GetAllProblemsRepos()
        {
            var query = from problem in _context.Problems
                        select new ProblemDetailsDTO
                        {
                            Id = problem.Id,
                            Title = problem.Title,
                            Purpose = problem.Purpose,
                            Description = problem.Description,
                            UserID = problem.UserID,
                            OrderID = problem.OrderID,
                            CreationDate = problem.CreationDate,
                            ModifiedDate = problem.ModifiedDate,
                            CreatorUserId = problem.CreatorUserId,
                            ModifiedUserId = problem.ModifiedUserId,
                            IsDeleted = problem.IsDeleted
                        };
            return await query.ToListAsync();
        }

        public async Task<ProblemDetailsDTO> GetProblemDetailsByIdRepos(int Id)
        {
            var query = from problem in _context.Problems
                        where problem.Id == Id
                        select new ProblemDetailsDTO
                        {
                            Id = problem.Id,
                            Title = problem.Title,
                            Purpose = problem.Purpose,
                            Description = problem.Description,
                            UserID = problem.UserID,
                            OrderID = problem.OrderID,
                            CreationDate = problem.CreationDate,
                            ModifiedDate = problem.ModifiedDate,
                            CreatorUserId = problem.CreatorUserId,
                            ModifiedUserId = problem.ModifiedUserId,
                            IsDeleted = problem.IsDeleted
                        };
            return await query.SingleOrDefaultAsync();
        }

        public async Task UpdateProblemRepos(UpdateProblemDTO dto)
        {
            var problem = await _context.Problems.SingleOrDefaultAsync(b => b.Id == dto.Id);

            if (problem == null)
            {
                throw new Exception("The problem not found");
            }

            if (!string.IsNullOrEmpty(dto.Title))
            {
                problem.Title = dto.Title;
            }

            if (!string.IsNullOrEmpty(dto.Description))
            {
                problem.Description = dto.Description;
            }

            if (!string.IsNullOrEmpty(dto.Purpose))
            {
                problem.Purpose = dto.Purpose;
            }

            if (dto.UserID.HasValue)
            {
                problem.UserID = dto.UserID.Value;
            }

            if (dto.OrderID.HasValue)
            {
                problem.OrderID = dto.OrderID.Value;
            }
            problem.ModifiedDate = DateTime.Now;
            problem.ModifiedUserId = 1;

            _context.Update(problem);
            await _context.SaveChangesAsync();
        }
    }
}
