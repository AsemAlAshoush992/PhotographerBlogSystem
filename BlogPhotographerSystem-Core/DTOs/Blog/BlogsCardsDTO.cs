﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.DTOs.Blog
{
    public class BlogsCardsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime BlogDate { get; set; }
        public string AuthorName { get; set; }
        public string ImagePath { get; set; }
        public int CommentCount { get; set; }
    }
}
