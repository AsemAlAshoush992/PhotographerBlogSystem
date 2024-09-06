using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Comment
{
    public class CommentDTO
    {
        public string AuthorName { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
