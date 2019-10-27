using MVCBlogProject.CORE.Entity;
using MVCBlogProject.CORE.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.SERVICE.Base
{
    public class BaseService<T> : ICoreService<T> where T: CoreEntity
    {

        // TODO : Model katmanındaki model düzeldiğinde verilen isme göre burayı düzelteceğiz.
        private static ProjectContext _db;

        #region Singleton Pattern
        public static ProjectContext db
        {
            get
            {
                if (_db == null)
                {
                    _db = new ProjectContext();
                }
                return _db;
            }
        }

        #endregion

       public void Add(T item)
        {
            db.Set<T>.Add(item);
            db.SaveChanges();
        }
       public void Add(List<T> item)
        {
            db.Set<T>.AddRange(item);
            db.SaveChanges();
        }

        public void Remove(T item)
        {
            item.Status = MVCBlogProject.CORE.Entity.Enum.Status.Deleted;
            Update(item);
            //Update içerisinde Save ettiği için tekrardan yazmadık.
        }

        public void Update(T item)
        {
            // TODO: Find ile yaptığımız işlemi GetById ile yapacağız.Core katmanında ekli olmadığı için Find ile yaptık.
            T updated = db.Set<T>.Find(item.ID);
            DbEntityEntry entry = db.Entry(updated);
            entry.CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }
    }
}
