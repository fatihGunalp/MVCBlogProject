using MVCBlogProject.MODEL.Entities;
using MVCBlogProject.SERVICE.Base;

namespace MVCBlogProject.SERVICE.Option
{
    public class UserService : BaseService<User>
    {
        public bool CheckUser(string _userName, string _password)
        {
            return Any(x => x.Username == _userName && x.Password == _password && x.IsActive == true);
        }
    }
}
