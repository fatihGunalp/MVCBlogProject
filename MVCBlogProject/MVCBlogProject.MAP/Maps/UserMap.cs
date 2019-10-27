using MVCBlogProject.CORE.Map;
using MVCBlogProject.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.MAP.Maps
{
    public class UserMap : CoreMap<User>
    {
        public UserMap()
        {
            ToTable("dbo.Users");
            Property(i => i.Adress).IsOptional().HasColumnName("Adres");
            Property(i => i.PhoneNumber).IsOptional().HasColumnName("Telefon");
            Property(i => i.BirthDate).IsOptional().HasColumnName("Doğum Günü");
            Property(i => i.Name).IsRequired().HasMaxLength(30).HasColumnName("İsim");
            Property(i => i.Surname).IsRequired().HasMaxLength(40).HasColumnName("Soyisim");
            Property(i => i.Username).IsRequired().HasMaxLength(30).HasColumnName("Kullanıcı Adı");
            Property(i => i.Email).IsRequired().HasColumnName("Mail Adresi");
            Property(i => i.Password).IsRequired().HasColumnName("Şifre");
            Ignore(x => x.ConfirmPassword);
        }
        
    }
}
