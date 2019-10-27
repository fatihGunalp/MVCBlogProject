using MVCBlogProject.CORE.Map;
using MVCBlogProject.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.MAP.Maps
{
    public class CommentMap:CoreMap<Comment>
    {
        public CommentMap()
        {
            ToTable("dbo.Comments");
            Property(i => i.Header).IsRequired();
            Property(i => i.Text).IsRequired();
        }
    }
}
