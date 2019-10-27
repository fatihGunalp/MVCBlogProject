using MVCBlogProject.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.MODEL.Entities
{
    public class Comment : CoreEntity
    {
        public string Header { get; set; }
        public string Text { get; set; }
        public string Owner { get; set; }


        public Article Article { get; set; }
        public User User { get; set; }
        

    }
}
