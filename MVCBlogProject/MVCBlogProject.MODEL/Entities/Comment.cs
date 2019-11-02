using MVCBlogProject.CORE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.MODEL.Entities
{
    public class Comment : CoreEntity
    {
        [Display(Name = "Başlık")]
        public string Header { get; set; }
        [Display(Name = "Yazı")]
        public string Text { get; set; }
        [Display(Name = "Yazar")]
        public string Owner { get; set; }


        public virtual Article Article { get; set; }
        public virtual User User { get; set; }
        

    }
}
