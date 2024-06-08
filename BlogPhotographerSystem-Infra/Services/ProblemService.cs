using BlogPhotographerSystem_Core.DTOs.Problem;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class ProblemService : IProblemService
    {
        private readonly IProblemRepos _problemRepos;

        public ProblemService(IProblemRepos problemRepos)
        {
            _problemRepos = problemRepos;
        }

        public Task CreateNewProblem(CreateProblemDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProblem(UpdateProblemDTO dto)
        {
            await _problemRepos.DeleteProblemRepos(dto);
        }

        public Task<ProblemDetailsDTO> FilterProblemByUserIdOrOrderId(int? orderId, int? userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProblemDetailsDTO>> GetAllProblems()
        {
            throw new NotImplementedException();
        }

        public async Task<ProblemDetailsDTO> GetProblemDetailsById(int Id)
        {
            return await _problemRepos.GetProblemDetailsByIdRepos(Id);
        }

        public async Task SendTechnicalSupportRequest(CreateProblemDTO dto)
        {
            Problem problem = new Problem()
            {
                Title = dto.Title,
                Purpose = dto.Purpose,
                Description = dto.Description,
                UserID = dto.UserID,
                OrderID = dto.OrderId
            };
            await _problemRepos.CreateNewProblemRepos(problem);
        }

        public async Task UpdateProblem(UpdateProblemDTO dto)
        {
            await _problemRepos.UpdateProblemRepos(dto);
        }
    }
}
