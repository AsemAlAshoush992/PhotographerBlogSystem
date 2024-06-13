using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Core.DTOs.Blog
{
    public class CreateBlogAdminDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Article { get; set; }
        public int AuthorId { get; set; }
        public List<string> FilePath { get; set; } = new List<string>();

    }
}
