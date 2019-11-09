using MVCBlogProject.SERVICE.Option;
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
        public PartialViewResult Menu()
        {
            CategoryService ctg = new CategoryService();
          var menu=  ViewBag.Menu = ctg.GetAll();
            return PartialView("_HeaderPartial",menu);
        }
        public ActionResult Homepage()
        {
            CategoryService ctg = new CategoryService();
            ViewBag.Menu = ctg.GetAll();
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