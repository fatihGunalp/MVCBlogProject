using MVCBlogProject.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBlogProject.MVCUI.Areas.Admin.Models
{
    public class HomeVM
    {
        public List<Todo> Todos { get; set; }

        public int UserCount { get; set; }

        public int? TagCount { get; set; }

        public List<Article> Articles { get; set; }

        public List<Comment> Comments { get; set; }


    }
}