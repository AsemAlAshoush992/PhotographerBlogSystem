using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Comment
{
    public class CreateCommentDTO
    {
        public int BlogId { get; set; }
        public string AuthorName { get; set; }
        public string Content { get; set; }
    }
}
