using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.CORE.Entity
{
    public interface IEntity<T>
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        T ID { get; set; }
    }
}
