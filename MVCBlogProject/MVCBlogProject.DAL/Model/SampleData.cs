using MVCBlogProject.DAL.Model.Context;
using MVCBlogProject.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVCBlogProject.DAL.Model
{
    public class SampleData:CreateDatabaseIfNotExists<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            #region Kullanıcı
            User user = new User();
            user.Name = "John";
            user.Surname = "Doe";
            user.Email = "john@doe.com";
            user.Adress = "Kadıköy";
            user.BirthDate = new DateTime(1990, 01, 01);
            user.IsActive = true;
            user.Password = "123";
            user.Status = CORE.Entity.Enum.Status.Created;
            user.Username = "JohnDoe";

            context.Users.Add(user);
            #endregion

            #region Kategori
            List<Category> categories = new List<Category>()
            {
                new Category
                {
                    CategoryName="Teknoloji",
                    Status=CORE.Entity.Enum.Status.Created
                },
                new Category
                {
                    CategoryName="Haber",
                    Status=CORE.Entity.Enum.Status.Created
                },
                new Category
                {
                    CategoryName="Spor",
                    Status=CORE.Entity.Enum.Status.Created
                },
            }; 
            
            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            #endregion

            #region Makale
            List<Article> articles = new List<Article>()
            {
                new Article
                {
                    Header="Lorem ipsum",
                    Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus augue a elementum condimentum. Integer eget libero vel ligula egestas varius. Donec blandit enim nec viverra auctor. Sed rhoncus magna eu lorem eleifend, eget lobortis urna eleifend. Nulla vitae quam facilisis enim varius varius. Sed dictum elit tortor, a vehicula elit tempus vitae. Fusce maximus accumsan turpis a vulputate. Interdum et malesuada fames ac ante ipsum primis in faucibus. Sed tempus lacinia odio, elementum condimentum nibh tincidunt non. Mauris eu elit feugiat, venenatis tellus pulvinar, dignissim mauris. Nunc et pretium enim. Nulla ut gravida arcu. Donec lacinia augue ligula, vitae fermentum diam malesuada et. Suspendisse vitae posuere sapien. Nunc diam lacus, lobortis id hendrerit ut, consectetur id neque. Mauris imperdiet nibh est, eu pulvinar turpis elementum et. Proin sed magna molestie, feugiat velit sit amet, vestibulum dui. Proin at faucibus diam. Sed consequat, ante varius porttitor scelerisque, ipsum neque fermentum metus, egestas efficitur est purus et felis. Nunc quis massa varius, semper mi quis, posuere nunc. Vivamus sapien mauris, varius sit amet semper euismod, ornare et ex. Phasellus mollis tortor nisl, non hendrerit ante auctor eu. Morbi pulvinar elit sit amet lorem rhoncus, consequat tristique nisi pharetra.",
                    CreatedDate=DateTime.Now,
                    Description="Pellentesque lobortis quis sem eget cursus. Suspendisse potenti. Fusce scelerisque lobortis ornare. Sed aliquam est erat, ac sollicitudin diam laoreet quis. Praesent accumsan velit dui. ",
                    Status=CORE.Entity.Enum.Status.Created,

                },
                new Article
                {
                    Header="Lorem ipsum",
                    Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus augue a elementum condimentum. Integer eget libero vel ligula egestas varius. Donec blandit enim nec viverra auctor. Sed rhoncus magna eu lorem eleifend, eget lobortis urna eleifend. Nulla vitae quam facilisis enim varius varius. Sed dictum elit tortor, a vehicula elit tempus vitae. Fusce maximus accumsan turpis a vulputate. Interdum et malesuada fames ac ante ipsum primis in faucibus. Sed tempus lacinia odio, elementum condimentum nibh tincidunt non. Mauris eu elit feugiat, venenatis tellus pulvinar, dignissim mauris. Nunc et pretium enim. Nulla ut gravida arcu. Donec lacinia augue ligula, vitae fermentum diam malesuada et. Suspendisse vitae posuere sapien. Nunc diam lacus, lobortis id hendrerit ut, consectetur id neque. Mauris imperdiet nibh est, eu pulvinar turpis elementum et. Proin sed magna molestie, feugiat velit sit amet, vestibulum dui. Proin at faucibus diam. Sed consequat, ante varius porttitor scelerisque, ipsum neque fermentum metus, egestas efficitur est purus et felis. Nunc quis massa varius, semper mi quis, posuere nunc. Vivamus sapien mauris, varius sit amet semper euismod, ornare et ex. Phasellus mollis tortor nisl, non hendrerit ante auctor eu. Morbi pulvinar elit sit amet lorem rhoncus, consequat tristique nisi pharetra.",
                    CreatedDate=DateTime.Now,
                    Description="Pellentesque lobortis quis sem eget cursus. Suspendisse potenti. Fusce scelerisque lobortis ornare. Sed aliquam est erat, ac sollicitudin diam laoreet quis. Praesent accumsan velit dui. ",
                    Status=CORE.Entity.Enum.Status.Created,

                },
                new Article
                {
                    Header="Lorem ipsum",
                    Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus augue a elementum condimentum. Integer eget libero vel ligula egestas varius. Donec blandit enim nec viverra auctor. Sed rhoncus magna eu lorem eleifend, eget lobortis urna eleifend. Nulla vitae quam facilisis enim varius varius. Sed dictum elit tortor, a vehicula elit tempus vitae. Fusce maximus accumsan turpis a vulputate. Interdum et malesuada fames ac ante ipsum primis in faucibus. Sed tempus lacinia odio, elementum condimentum nibh tincidunt non. Mauris eu elit feugiat, venenatis tellus pulvinar, dignissim mauris. Nunc et pretium enim. Nulla ut gravida arcu. Donec lacinia augue ligula, vitae fermentum diam malesuada et. Suspendisse vitae posuere sapien. Nunc diam lacus, lobortis id hendrerit ut, consectetur id neque. Mauris imperdiet nibh est, eu pulvinar turpis elementum et. Proin sed magna molestie, feugiat velit sit amet, vestibulum dui. Proin at faucibus diam. Sed consequat, ante varius porttitor scelerisque, ipsum neque fermentum metus, egestas efficitur est purus et felis. Nunc quis massa varius, semper mi quis, posuere nunc. Vivamus sapien mauris, varius sit amet semper euismod, ornare et ex. Phasellus mollis tortor nisl, non hendrerit ante auctor eu. Morbi pulvinar elit sit amet lorem rhoncus, consequat tristique nisi pharetra.",
                    CreatedDate=DateTime.Now,
                    Description="Pellentesque lobortis quis sem eget cursus. Suspendisse potenti. Fusce scelerisque lobortis ornare. Sed aliquam est erat, ac sollicitudin diam laoreet quis. Praesent accumsan velit dui. ",
                    Status=CORE.Entity.Enum.Status.Created,

                }
            };

            foreach (var item in articles)
            {
                context.Articles.Add(item);
            }
            #endregion

            context.SaveChanges();
            
            base.Seed(context);

        }
    }
}
