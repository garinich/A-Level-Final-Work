﻿using System;
using System.Collections.Generic;
using DataAccessLayer;

namespace Blog.Models
{
    public class PostViewModel
    {
        public PostViewModel()
        {
            Comments = new List<CommentViewModel>();
        }

        public int Id { get; set; }
        public DateTime PublishDate { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public string Discription { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsShowComment { get; set; }
        public int UsersReadCount { get; set; }

        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
        public ICollection<CommentViewModel> Comments { get; set; }
    }
}
