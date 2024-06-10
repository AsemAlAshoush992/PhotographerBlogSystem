using BlogPhotographerSystem_Core.DTOs.ContactRequest;
using BlogPhotographerSystem_Core.DTOs.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IServices
{
    public interface IProblemService
    {
        //Admin Management
        Task<ProblemDetailsDTO> GetProblemDetailsById(int Id);
        Task<List<ProblemDetailsDTO>> GetAllProblems();
        //Filter
        Task<ProblemDetailsDTO> FilterProblemByUserIdOrOrderId(int? orderId, int? userId);

        //Create
        Task CreateNewProblem(CreateProblemDTO dto);
        //Update
        Task UpdateProblem(UpdateProblemDTO dto);
        //Delete
        Task DeleteProblem(int ID);
        //Client Management
        //Send
        Task SendTechnicalSupportRequest(CreateProblemDTO dto);
    }
}
