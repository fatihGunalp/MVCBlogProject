using MVCBlogProject.CORE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.MODEL.Entities
{
    public class Todo : CoreEntity
    {
        [Required(ErrorMessage = "Görev detayı girmelisiniz.")]
        public string TaskContent { get; set; }
        public bool IsComplete { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}
