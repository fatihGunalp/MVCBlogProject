using MVCBlogProject.MODEL.Entities;
using MVCBlogProject.MVCUI.Areas.Admin.Models;
using MVCBlogProject.MVCUI.Filter;
using MVCBlogProject.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogProject.MVCUI.Areas.Admin.Controllers
{
    [AuthFilter]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        TodoService tododb = new TodoService();
        UserService userdb = new UserService();
        TagService tagdb = new TagService();
        ArticleService articledb = new ArticleService();
        CommentService csdb = new CommentService();
        public ActionResult Index()
        {
            HomeVM home = new HomeVM();

            home.Todos = (tododb.GetActive().Where(x => x.UserId == ((User)Session["login"]).ID && x.IsComplete == false).ToList());

            home.UserCount = userdb.GetActive().Count();

            home.TagCount = tagdb.GetActive().Count();

            home.Articles = articledb.GetActive();

            home.Comments = csdb.GetActive();

            return View(home);
        }

    }
}