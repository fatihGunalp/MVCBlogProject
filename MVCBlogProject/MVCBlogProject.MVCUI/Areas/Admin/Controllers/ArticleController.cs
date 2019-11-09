using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCBlogProject.DAL.Model.Context;
using MVCBlogProject.MODEL.Entities;
using MVCBlogProject.MVCUI.Filter;

namespace MVCBlogProject.MVCUI.Areas.Admin.Controllers
{
    //[AuthFilter]
    public class ArticleController : Controller
    {
        private BlogContext db = new BlogContext();

        // GET: Admin/Articles
        public ActionResult Index()
        {
            return View(db.Articles.ToList());
        }

       
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        public ActionResult Create()
        {
            var users = db.Users.ToList();
            ViewBag.OwnerList = new SelectList(users, "ID", "Username");
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Header,Description,Content,Owner,Status")] Article article)
        {
            var articleOwner = db.Users.FirstOrDefault(i => i.ID == article.Owner.ID);
            var users = db.Users.ToList();
            ViewBag.OwnerList = new SelectList(users, "ID", "Username");

                article.ID = Guid.NewGuid();
                article.Owner = articleOwner;

            if (ModelState.IsValid)
            {
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(article);
        }

        
        public ActionResult Edit(Guid? id)
        {
            var users = db.Users.ToList();
            ViewBag.OwnerList = new SelectList(users, "ID", "Username");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Header,Description,Content,Owner,Status")] Article article)
        {
            var users = db.Users.ToList();
            ViewBag.OwnerList = new SelectList(users, "ID", "Username");
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(article);
        }

        
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
