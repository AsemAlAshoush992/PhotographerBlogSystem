using BlogPhotographerSystem_Core.DTOs.Comment;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class CommentService : ICommentService 
    {
        private readonly ICommentRepos _commentRepos;

        public CommentService(ICommentRepos commentRepos)
        {
            _commentRepos = commentRepos;
        }

        public  async Task CreateComment(CreateCommentDTO dto)
        {
            Comment comment = new Comment()
            {
                BlogId = dto.BlogId,
                AuthorName = dto.AuthorName,
                Content = dto.Content,
                CommentDate = DateTime.Now
            };
            await _commentRepos.CreateCommentRepos(comment);
        }

        public async Task DeleteComment(int ID)
        {
             await _commentRepos.DeleteCommentRepos(ID);
        }

        public async Task<List<CommentsDetailsDTO>> GetAllComments()
        {
            return await _commentRepos.GetAllCommentsRepos();
        }
    }
}
