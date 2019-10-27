using MVCBlogProject.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.CORE.Map
{
    public class CoreMap<T>:EntityTypeConfiguration<T> where T: CoreEntity
    {
        public CoreMap()
        {
            Property(x => x.CreatedDate).HasColumnName("CreatedDate");
        }
    }
}
