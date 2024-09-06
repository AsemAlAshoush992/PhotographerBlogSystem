using BlogPhotographerSystem_Core.Context;
using BlogPhotographerSystem_Core.IRepos;
using BlogPhotographerSystem_Core.Models.Entity;
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

        public async Task CreateCommentRepos(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
        }
    }
}
