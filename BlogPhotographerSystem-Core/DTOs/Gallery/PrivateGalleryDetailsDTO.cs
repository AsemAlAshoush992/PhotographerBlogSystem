using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Core.DTOs.Gallery
{
    public class PrivateGalleryDetailsDTO
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public bool IsPrivate { get; set; }
        public int? OrderID { get; set; }
        public bool IsDeleted { get; set; }
    }
}
