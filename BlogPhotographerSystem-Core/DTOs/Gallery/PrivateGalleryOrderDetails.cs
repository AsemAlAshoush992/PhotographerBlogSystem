using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Gallery
{
    public class PrivateGalleryOrderDetails
    {
        public int ID { get; set; }
        public int? OrderID { get; set; }
        public List<string> Images { get; set; } = new List<string>();
    }
}
