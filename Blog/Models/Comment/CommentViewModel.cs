﻿using System;
using DataAccessLayer;

namespace Blog.Models
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public DateTime PublishDate { get; set; }
        public string Body { get; set; }
        public bool IsBlocked { get; set; }

        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
        public int PostId { get; set; }
        public PostViewModel Post { get; set; }
    }
}
