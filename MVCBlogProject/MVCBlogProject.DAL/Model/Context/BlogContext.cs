using MVCBlogProject.MAP.Maps;
using MVCBlogProject.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogProject.DAL.Model.Context
{
    public class BlogContext:DbContext
    {
        public BlogContext()
        {
            Database.Connection.ConnectionString = "server=.;database=MCVBlog;uid=sa;pwd=123";
            Database.SetInitializer<BlogContext>(new DropCreateDatabaseIfModelChanges<BlogContext>());
            Database.SetInitializer<BlogContext>(new SampleData());
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new TodoMap());

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Todo> Todos { get; set; }


    }

}
