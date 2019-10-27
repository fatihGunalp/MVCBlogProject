using MVCBlogProject.CORE.Map;
using MVCBlogProject.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.MAP.Maps
{
    public class ArticleMap:CoreMap<Article>
    {
        public ArticleMap()
        {
            ToTable("dbo.Articles");
            Property(i => i.Header).IsRequired();
            Property(i => i.Description).IsRequired();
            Property(i => i.Content).IsRequired();
        }
    }
}
