﻿using MVCBlogProject.MVCUI.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogProject.MVCUI.Areas.Admin.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Admin/Article
        [AuthFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}