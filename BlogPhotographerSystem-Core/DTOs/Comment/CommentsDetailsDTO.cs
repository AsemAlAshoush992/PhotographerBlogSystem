using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Comment
{
    public class CommentsDetailsDTO
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
