using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.Models.Shared
{
    public class MainEntity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
