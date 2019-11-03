using MVCBlogProject.CORE.Entity;
using MVCBlogProject.CORE.Service;
using MVCBlogProject.DAL.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.SERVICE.Base
{
    public class BaseService<T> : ICoreService<T> where T: CoreEntity
    {

        // TODO : Model katmanındaki model düzeldiğinde verilen isme göre burayı düzelteceğiz.
        private static BlogContext _db;

        #region Singleton Pattern
        public static BlogContext db
        {
            get
            {
                if (_db == null)
                {
                    _db = new BlogContext();
                }
                return _db;
            }
        }

        #endregion

       public void Add(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }
       public void Add(List<T> item)
        {
            db.Set<T>().AddRange(item);
            db.SaveChanges();
        }

        public void Remove(T item)
        {
            item.Status = MVCBlogProject.CORE.Entity.Enum.Status.Deleted;
            Update(item);
            //Update içerisinde Save ettiği için tekrardan yazmadık.
        }
        public T GetById(Guid id)
        {
            return db.Set<T>().Find(id);
        }
        public void Update(T item)
        {
            // TODO: Find ile yaptığımız işlemi GetById ile yapacağız.Core katmanında ekli olmadığı için Find ile yaptık.
            T updated = db.Set<T>().Find(item.ID);
            DbEntityEntry entry = db.Entry(updated);
            entry.CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public T GetByDefault(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).FirstOrDefault();
        }

        //public int Save()
        //{
        //    if (db.SaveChanges() > 0)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}
    }
}
