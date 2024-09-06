using BlogPhotographerSystem_Core.DTOs.BlogAttachement;
using BlogPhotographerSystem_Core.DTOs.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Blog
{
    public class BlogDetailsForUserDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Article { get; set; }
        public DateTime BlogDate { get; set; }
        public string AuthorName { get; set; }
        public string Status { get; set; }
        public List<BlogAttachementDTO>? BlogAttachments { get; set; }
        public List<CommentDTO>? Comments { get; set; }
    }
}
