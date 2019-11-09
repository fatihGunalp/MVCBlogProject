using MVCBlogProject.CORE.Map;
using MVCBlogProject.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.MAP.Maps
{
    public class TodoMap : CoreMap<Todo>
    {
        public TodoMap()
        {
            ToTable("Todo");
            Property(x => x.TaskContent).IsRequired();
        }
    }
}
