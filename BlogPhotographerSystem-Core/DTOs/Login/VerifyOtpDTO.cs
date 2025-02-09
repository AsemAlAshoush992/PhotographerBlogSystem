using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Login
{
    public class VerifyOtpDTO
    {
        public string Email { get; set; }
        public string OtpCode { get; set; }
    }
}
