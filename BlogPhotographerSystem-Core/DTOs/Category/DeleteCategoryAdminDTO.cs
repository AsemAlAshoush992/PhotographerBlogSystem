using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Category
{
    public class DeleteCategoryAdminDTO
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
