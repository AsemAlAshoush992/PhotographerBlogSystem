using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Core.DTOs.Order
{
    public class CreateOrderClientDTO
    {
        public string PaymentMethod { get; set; }
        public int UserID { get; set; }
        public string ServiceName { get; set; }
    }
}
