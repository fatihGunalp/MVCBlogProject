using MVCBlogProject.MODEL.Entities;
using MVCBlogProject.SERVICE.Option;
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
        UserService db = new UserService();
        public ActionResult Index()
        {
            return View(db.GetAll());
        }

        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(User model, HttpPostedFileBase picture)
        {
            try
            {

                if (picture != null)
                {
                    string pictureName = System.IO.Path.GetFileName(picture.FileName);
                    string pictureAdress = Server.MapPath("~/Uploads/" + pictureName);

                    picture.SaveAs(pictureAdress);

                    //var resim = Request.Form["ImagePath"];
                    model.ImagePath = pictureAdress;



                }

                model.ID = Guid.NewGuid();
                if (ModelState.IsValid)
                {
                    db.Add(model);
                    return RedirectToAction("Index");
                }

               
                return View(model);
            }
            catch (Exception e)
            {

                ViewBag.Error = e.InnerException;
                return View(model);
            }
           
        }

        public ActionResult Edit(Guid ID)
        {
            //service de getByid eklenmesi bekleniyor.
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Guid Id,HttpPostedFileBase picture)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {
            return RedirectToAction("Index");
        }
    }
}