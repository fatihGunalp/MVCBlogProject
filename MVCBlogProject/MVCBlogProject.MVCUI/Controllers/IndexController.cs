using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogProject.MVCUI.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Homepage()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Category()
        {
            return View();
        }
        
        public ActionResult QuizeArticle()
        {
            return View();
        }
        public ActionResult SinglePost()
        {
            return View();
        }
    }
}