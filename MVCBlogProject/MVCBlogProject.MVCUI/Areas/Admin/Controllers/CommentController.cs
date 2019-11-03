using MVCBlogProject.MODEL.Entities;
using MVCBlogProject.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogProject.MVCUI.Areas.Admin.Controllers
{
    public class CommentController : Controller
    {
        // GET: Admin/Comment
        CommentService cs = new CommentService();
        public ActionResult Index()
        {
            return View(cs.GetAll());
        }

        public ActionResult Update(Guid Id)
        {
            return View(cs.GetById(Id));
        }

        [HttpPost]
        public ActionResult Update(Comment model)
        {
            if (ModelState.IsValid)
            {
                cs.Add(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public ActionResult Delete(Guid Id)
        {
            cs.Remove(cs.GetById(Id));
            return RedirectToAction("Index");
        }
    }
}