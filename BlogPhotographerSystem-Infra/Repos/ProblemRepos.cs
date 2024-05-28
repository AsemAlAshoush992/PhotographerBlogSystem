using BlogPhotographerSystem_Core.DTOs.Problem;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class ProblemRepos : IProblemRepos
    {
        public Task CreateNewProblemRepos(Problem problem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProblemRepos(Problem problem)
        {
            throw new NotImplementedException();
        }

        public Task<ProblemDetailsDTO> FilterProblemByUserIdOrOrderIdRepos(int? orderId, int? userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProblemDetailsDTO>> GetAllProblemsRepos()
        {
            throw new NotImplementedException();
        }

        public Task<ProblemDetailsDTO> GetProblemDetailsByIdRepos(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProblemRepos(Problem problem)
        {
            throw new NotImplementedException();
        }
    }
}
