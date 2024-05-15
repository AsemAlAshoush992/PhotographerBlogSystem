using BlogPhotographerSystem_Core.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Core.Models.Entity
{
    public class Order : MainEntity
    {
        public DateTime OrderDate { get; set; }
        public string Title { get; set; }
        public string? Note { get; set; }
        public Status Status { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int? UserID { get; set; }
        public int? ServiceID { get; set; }
    }
}
