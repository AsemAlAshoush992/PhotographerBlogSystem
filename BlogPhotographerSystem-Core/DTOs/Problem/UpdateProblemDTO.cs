using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Problem
{
    public class UpdateProblemDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Purpose { get; set; }
        public string? Description { get; set; }
        public int? UserID { get; set; }
        public int? OrderID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
