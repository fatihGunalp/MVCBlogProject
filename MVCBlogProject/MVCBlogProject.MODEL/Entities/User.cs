using MVCBlogProject.CORE.Entity;
using MVCBlogProject.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.MODEL.Entities
{
    public class User : CoreEntity
    {
        public User()
        {
            IsActive = false;

        }
        [Required(ErrorMessage = "Lütfen isim girin"), Display(Name = "Ad")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Soyad")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Şifre")]
        public string Password { get; set; }
        [NotMapped, Compare("Password", ErrorMessage = "Bu alan zorunludur."), Display(Name = "Şifre Tekrar")]
        public string ConfirmPassword { get; set; }
        [Required, EmailAddress(ErrorMessage = "Bu alan zorunludur."), Display(Name = "E-Posta")]
        public string Email { get; set; }
        [Display(Name = "Adres")]
        public string Adress { get; set; }
        [Display(Name = "Telefon")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Profil Resmi")]
        public string ImagePath { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime? BirthDate { get; set; }
        [Display(Name = "Yetki")]
        public Roles? Role { get; set; }
        public Guid ActivationCode { get; set; }
        public bool IsActive { get; set; }

  

        public virtual List<Article> Articles { get; set; }
        public virtual Roles Roles { get; set; }
        public virtual List<Comment> MyProperty { get; set; }





    }
}
