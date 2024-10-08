﻿using BlogPhotographerSystem_Core.DTOs.Problem;
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

        public async Task DeleteProblem(int ID)
        {
            await _problemRepos.DeleteProblemRepos(ID);
        }

        public async Task<List<ProblemDetailsDTO>> FilterProblemByUserIdOrOrderId(int? userId, int? orderId)
        {
            return await _problemRepos.FilterProblemByUserIdOrOrderIdRepos(userId, orderId);
        }

        public async Task<List<ProblemDetailsDTO>> GetAllProblems()
        {
            return await _problemRepos.GetAllProblemsRepos();
        }

        public async Task<ProblemDetailsDTO> GetProblemDetailsById(int Id)
        {
            return await _problemRepos.GetProblemDetailsByIdRepos(Id);
        }

        public async Task SendTechnicalSupportRequest(CreateProblemDTO dto, int userId)
        {
            Problem problem = new Problem()
            {
                Title = dto.Title,
                Purpose = dto.Purpose,
                Description = dto.Description,
                UserID = userId,
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
