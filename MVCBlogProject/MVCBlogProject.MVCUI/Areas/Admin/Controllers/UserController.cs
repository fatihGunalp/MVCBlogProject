using MVCBlogProject.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogProject.MVCUI.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        //todo: UserService oluşturulduktan sonra aşağıdaki actionların işlemleri tamamlanacak.
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User model)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Guid Id)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {
            return RedirectToAction("Index");
        }
    }
}