using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.DTOs.Category;
using BlogPhotographerSystem_Core.DTOs.Comment;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Repos
{
    public class CommentRepos : ICommentRepos
    {
        private readonly BlogPhotographerSystemDBContext _context;

        public CommentRepos(BlogPhotographerSystemDBContext context)
        {
            _context = context;
        }
        //Create
        public async Task CreateCommentRepos(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
        }
        //Delete
        public async Task DeleteCommentRepos(int ID)
        {
            var query = await _context.Comments.SingleOrDefaultAsync(b => b.Id == ID);
            if (query == null)
                throw new Exception("Comment not found");
            query.ModifiedDate = DateTime.Now;
            query.ModifiedUserId = 1;
            query.IsDeleted = true;

            _context.Update(query);
            await _context.SaveChangesAsync();
        }
        //GetAll
        public async Task<List<CommentsDetailsDTO>> GetAllCommentsRepos()
        {
            var query = from comment in _context.Comments
                        where comment.IsDeleted == false
                        select new CommentsDetailsDTO
                        {
                            Id = comment.Id,
                            AuthorName = comment.AuthorName,
                            Content = comment.Content,
                            CommentDate = comment.CommentDate,
                            IsDeleted = comment.IsDeleted
                        };
            return await query.ToListAsync();
        }
    }
}
