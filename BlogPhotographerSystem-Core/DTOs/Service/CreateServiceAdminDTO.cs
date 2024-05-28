using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Core.DTOs.Service
{
    public class CreateServiceAdminDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public bool IsHaveDiscount { get; set; }
        public float DisacountAmount { get; set; }
        public string DiscountType { get; set; }
        public int CategoryID { get; set; }
    }
}
