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
    public class UserController : Controller
    {
        //todo: UserService oluşturulduktan sonra aşağıdaki actionların işlemleri tamamlanacak.
        UserService db = new UserService();
        ArticleService dbArt = new ArticleService();
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

        public ActionResult Edit(Guid id)
        {



            //User newUser = new User();

            //var articles = dbArt.Update

            //newUser.ID = user.ID;
            //newUser.Email = user.Email;
            //newUser.Name = user.Name;
            //newUser.Surname = user.Surname;
            //newUser.Username = user.Username;
            //newUser.Password = user.Password;
            //newUser.ConfirmPassword = user.ConfirmPassword;
            //newUser.BirthDate = user.BirthDate;
            //newUser.CreatedDate = user.CreatedDate;
            //newUser.ImagePath = user.ImagePath;
            //newUser.PhoneNumber = user.PhoneNumber;
            //newUser.Role = user.Role;
            //newUser.Status = user.Status;
            //newUser.IsActive = user.IsActive;
            //newUser.Adress = user.Adress;
            //newUser.


            return View(db.GetById(id));
     
        }

        [HttpPost]
        public ActionResult Edit(User user,HttpPostedFileBase picture)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var activationCodeUser = db.GetById(user.ID);
                    if (picture != null)
                    {
                        string pictureName = System.IO.Path.GetFileName(picture.FileName);
                        string pictureAdress = Server.MapPath("~/Uploads/" + pictureName);

                        picture.SaveAs(pictureAdress);

                        //var resim = Request.Form["ImagePath"];
                        user.ImagePath = pictureAdress;



                    }

                    db.Update(activationCodeUser);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ViewBag.Error = e.Message;
                    return View(user);
                }
            }
            else
            {
                return View();
            }
            

        }


        public ActionResult Delete(Guid ID)
        {


            var deleted = db.GetById(ID);

            return View(deleted);

        }

        [HttpPost]
        public PartialViewResult Delete(User user)
        {

            try
            {
                db.Remove(user);
                return PartialView();
            }
            catch (Exception e)
            {

                ViewBag.Error = e.Message;
                return PartialView();
            }
            

        }
    }
}