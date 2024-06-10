using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Gallery
{
    public class SendPrivateGalleryDTO
    {
        public string Path { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public int OrderID { get; set; }
    }
}
