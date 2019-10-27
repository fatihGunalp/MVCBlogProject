using MVCBlogProject.CORE.Map;
using MVCBlogProject.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.MAP.Maps
{
    public class TagMap:CoreMap<Tag>
    {
        public TagMap()
        {
            ToTable("dbo.Tags");
            Property(i => i.Text).IsRequired();
        }
    }
}
