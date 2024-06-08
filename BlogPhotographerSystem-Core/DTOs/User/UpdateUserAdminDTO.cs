using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Core.DTOs.User
{
    public class UpdateUserAdminDTO
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? ImagePath { get; set; }
        public string? Phone { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
