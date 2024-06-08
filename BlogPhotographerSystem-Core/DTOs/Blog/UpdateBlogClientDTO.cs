using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Blog
{
    public class UpdateBlogClientDTO
    {
        public int Id { get; set; }
        public int? AttachementId { get; set; }
        public string? Title { get; set; }
        public string? Article { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUserId { get; set; }
        public string? Path { get; set; }
        public string? FileType { get; set; }
        public string? FileName { get; set; }
    }
}
