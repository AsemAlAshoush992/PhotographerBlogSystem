using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Blog
{
    public class BlogsDetailsDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Article { get; set; }
        public DateTime BlogDate { get; set; }
        public bool IsApproved { get; set; }
        public int AuthorID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
