using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Order
{
    public class UpdateOrderAdminDTO
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
        public int UserID { get; set; }
        public int ServiceID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
