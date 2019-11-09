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
    public class TagController : Controller
    {
        // GET: Admin/Tag
        TagService db = new TagService();
        public ActionResult Index()
        {
            return View(db.GetAll().ToList());
        }

        public ActionResult TagInsert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TagInsert(Tag tag)
        {
            tag.ID = Guid.NewGuid();
            db.Add(tag);

            return RedirectToAction("Index");
        }
        public ActionResult TagUpdate(Guid id)
        {
            return View(db.GetById(id));
        }

        [HttpPost]
        public ActionResult TagUpdate(Tag model)
        {
            if (ModelState.IsValid)
            {
                db.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
     
        public ActionResult Delete(Guid id)
        {
            db.Remove(db.GetById(id));

            return RedirectToAction("Index");
        }

    }
}