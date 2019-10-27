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
            Property(i => i.Adress).IsOptional();
            Property(i => i.BirthDate).IsOptional();
            Property(i => i.Name).IsRequired();
        }
    }
}
