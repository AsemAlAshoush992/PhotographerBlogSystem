using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Blog
{
    public class BlogsDetailsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Article { get; set; }
        public DateTime BlogDate { get; set; }
        public string? Status { get; set; }
        public int AuthorID { get; set; }
        public bool IsDeleted { get; set; }
    }
}
