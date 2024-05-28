using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Login
{
    public class CreateLoginDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserID { get; set; }
    }
}
