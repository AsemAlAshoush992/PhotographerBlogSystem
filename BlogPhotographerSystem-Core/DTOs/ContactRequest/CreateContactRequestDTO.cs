using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.ContactRequest
{
    public class CreateContactRequestDTO
    {
        public string ClientName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public float Budget { get; set; }
        public int UserID { get; set; }
    }
}
