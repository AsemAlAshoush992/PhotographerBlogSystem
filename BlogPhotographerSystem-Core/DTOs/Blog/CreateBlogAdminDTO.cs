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
        public bool IsApproved { get; set; }
        public string AuthorName { get; set; }
        public List<string> FilePath { get; set; }
        public List<string> FileName { get; set; }
        public List<string> FileType { get; set; }
    }
}
