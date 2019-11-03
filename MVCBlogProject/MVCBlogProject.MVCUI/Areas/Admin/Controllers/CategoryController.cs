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

      
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category model)
        {
            model.ID = Guid.NewGuid();
            db.Add(model);
            return RedirectToAction("Index");
        }

       
        public ActionResult Delete(Guid id)
        {
            db.Remove(db.GetById(id));
          
            return RedirectToAction("Index");
        }

        public ActionResult Update(Guid id)
        {
            return View(db.GetById(id));
        }
        [HttpPost]
        public ActionResult Update(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
          
    }
}