using MVCBlogProject.CORE.Entity;
using MVCBlogProject.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.MODEL.Entities
{
    public class User : CoreEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string ImagePath { get; set; }
        public DateTime? BirthDate { get; set; }
        public Roles? Role { get; set; }

        public List<Article> Articles { get; set; }
        public Roles Roles { get; set; }
        public List<Comment> Comments { get; set; }
      


    }
}
