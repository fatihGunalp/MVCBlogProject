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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Comment model)
        {
            if (ModelState.IsValid)
            {
                model.ID = Guid.NewGuid();
                cs.Add(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public ActionResult Edit()
        {
            return View();
        }


    }
}