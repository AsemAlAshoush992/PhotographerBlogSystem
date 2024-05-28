using BlogPhotographerSystem_Core.DTOs.Problem;
using BlogPhotographerSystem_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class ProblemService : IProblemService
    {
        public Task CreateNewProblem(CreateProblemDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProblem(UpdateProblemDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<ProblemDetailsDTO> FilterProblemByUserIdOrOrderId(int? orderId, int? userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProblemDetailsDTO>> GetAllProblems()
        {
            throw new NotImplementedException();
        }

        public Task<ProblemDetailsDTO> GetProblemDetailsById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task SendTechnicalSupportRequest(CreateProblemDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProblem(UpdateProblemDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
