﻿using BlogPhotographerSystem_Core.DTOs.Problem;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IRepos
{
    public interface IProblemRepos
    {
        //Admin Management
        Task<ProblemDetailsDTO> GetProblemDetailsByIdRepos(int Id);
        Task<List<ProblemDetailsDTO>> GetAllProblemsRepos();
        //Filter
        Task<List<ProblemDetailsDTO>> FilterProblemByUserIdOrOrderIdRepos(int? userId, int? orderId);

        //Create
        Task CreateNewProblemRepos(Problem problem);
        //Update
        Task UpdateProblemRepos(UpdateProblemDTO dto);
        //Delete
        Task DeleteProblemRepos(int ID);
    }
}
