using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.User
{
    public class UpdateUserDTO
    {
        public string? FirstName   { get; set; }
        public string? LastName    { get; set; }
        public string? Password    { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? ImagePath   { get; set; }
        public string? Phone        { get; set; }
    }
}
