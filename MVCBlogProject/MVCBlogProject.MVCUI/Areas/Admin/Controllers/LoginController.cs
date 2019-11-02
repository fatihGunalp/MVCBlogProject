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
    //todo: Service düzenlenecek
    public class LoginController : Controller
    {
        UserService us = new UserService();

        BlogContext db = new BlogContext();

        // GET: Admin/Login
        public ActionResult Index()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Index(User model)
        {
            try
            {
                var users = db.Users.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);

                if (users == null)
                {
                    TempData["error"] = "Böyle bir kullanıcı bulunamadı";
                    return RedirectToAction("Index", "Error");
                }
                else
                {
                    Session["login"] = users;
                    return RedirectToAction("Products", "Home");
                }
            }
            catch (Exception ex)
            {

                ViewBag.Error = ex.Message;
            }

            return View();
        }

    }
}