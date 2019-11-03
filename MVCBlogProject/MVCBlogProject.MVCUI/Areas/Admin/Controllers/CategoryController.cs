using MVCBlogProject.DAL.Model.Context;
using MVCBlogProject.MODEL.Entities;
using MVCBlogProject.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogProject.MVCUI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Admin/Category
        CategoryService db = new CategoryService();
        public ActionResult Index()
        {
            return View(db.GetAll().ToList());
        }


        public ActionResult CategoryInsert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryInsert(Category category)
        {
            db.Add(category);
          
            return RedirectToAction("Index");
        }

        public ActionResult CategoryUpdate(Guid id)
        {
            return View(db.GetById(id));
        }
    }
}