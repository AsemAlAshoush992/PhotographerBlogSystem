using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Problem
{
    public class CreateProblemDTO
    {
        public string Title { get; set; }
        public string Purpose { get; set; }
        public string Description { get; set; }
        public int? UserID { get; set; }
        public int? OrderId { get; set; }
    }
}
