using BlogPhotographerSystem_Core.DTOs.Category;
using BlogPhotographerSystem_Core.DTOs.Comment;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.IRepos
{
    public interface ICommentRepos
    {
        //Create
        Task CreateCommentRepos(Comment comment);
        //GetAll
        Task<List<CommentsDetailsDTO>> GetAllCommentsRepos();
        //Delete
        Task DeleteCommentRepos(int ID);
    }
}
