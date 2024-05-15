using BlogPhotographerSystem_Core.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.Models.Entity
{
    public class Category: MainEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
