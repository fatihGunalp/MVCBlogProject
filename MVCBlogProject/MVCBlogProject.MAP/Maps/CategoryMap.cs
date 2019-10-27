using MVCBlogProject.CORE.Map;
using MVCBlogProject.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.MAP.Maps
{
    public class CategoryMap:CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");
            Property(i => i.CategoryName).IsRequired();
           
        }
    }
}
