using BlogPhotographerSystem_Core.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Core.Models.Entity
{
    public class BlogAttachement: MainEntity
    {
        public string Path { get; set; }
        public string FileName { get; set; }
        public FileType FileType { get; set; }
        public int? BlogID { get; set; }
    }
}
