using BlogPhotographerSystem_Core.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.Models.Entity
{
    public class Comment : MainEntity
    {
        public int BlogId { get; set; } 
        public string AuthorName { get; set; } 
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
