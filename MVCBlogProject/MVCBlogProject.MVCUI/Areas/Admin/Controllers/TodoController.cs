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
    public class TodoController : Controller
    {
        TodoService db = new TodoService();
        public ActionResult Index()
        {
            return View(db.GetActive().Where(x => x.UserId == ((User)Session["login"]).ID && x.IsComplete == false).ToList());
        }

        [HttpPost]
        public ActionResult Create(Todo model)
        {
            model.ID = Guid.NewGuid();
            model.UserId = ((User)Session["login"]).ID;
            model.IsComplete = false;
            db.Add(model);

            return RedirectToAction("Index");
        }

        public ActionResult Complete(Guid Id)
        {
            Todo todo = db.GetById(Id);
            todo.IsComplete = true;
            todo.EndDate = DateTime.Now;

            db.Update(todo);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid Id)
        {
            Todo todo = db.GetById(Id);
            db.Remove(todo);
            return RedirectToAction("Index");
        }

        public PartialViewResult Edit(Guid Id)
        {
            return PartialView("Partials/_PartialEditTask", db.GetById(Id));
        }

        [HttpPost]
        public ActionResult Edit(Todo model)
        {
            db.Update(model);

            return RedirectToAction("Index");
        }

        public ActionResult CompleteTask()
        {
            return View(db.GetActive().Where(x => x.UserId == ((User)Session["login"]).ID && x.IsComplete == true).ToList());
        }

        public ActionResult Continue(Guid Id)
        {
            Todo todo = db.GetById(Id);
            todo.IsComplete = false;
            todo.EndDate = null;

            db.Update(todo);

            return RedirectToAction("Index");
        }
    }
}