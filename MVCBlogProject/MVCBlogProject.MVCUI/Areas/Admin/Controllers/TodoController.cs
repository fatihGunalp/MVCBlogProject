using MVCBlogProject.MVCUI.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogProject.MVCUI.Areas.Admin.Controllers
{
    [AuthFilter]
    public class TodoController : Controller
    {
        // GET: Admin/Todo
        public ActionResult Index()
        {
            return View();
        }
    }
}