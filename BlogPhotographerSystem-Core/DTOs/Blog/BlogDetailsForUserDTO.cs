using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Blog
{
    public class BlogDetailsForUserDTO
    {
        public string Title { get; set; }
        public string Article { get; set; }
        public DateTime BlogDate { get; set; }
        public string AuthorName { get; set; }
        public List<string>? FilePaths { get; set; }
    }
}
