using MVCBlogProject.DAL.Model.Context;
using MVCBlogProject.MODEL.Entities;
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
    public class CategoryController : Controller
    {
 
        // GET: Admin/Category
        CategoryService db = new CategoryService();
        
        public ActionResult Index()
        {
            //Giriş yapan kullanıcı adını göstermek için eklendi.
            var userDetail = Session["login"] as User;
            TempData["User"] = userDetail.Name + " " + userDetail.Surname;

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

        //Todo: Anıl Category listeleme sayfasında bir kategori silindiğinde onay ikonuna basılırsa tekrar created olarak güncellesin.
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