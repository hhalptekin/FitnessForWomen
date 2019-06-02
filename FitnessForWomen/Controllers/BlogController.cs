using FitnessForWomen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessForWomen.Controllers
{
    public class BlogController : Controller
    {
        FitnessForWomenEntitiesLast db = new FitnessForWomenEntitiesLast();
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListPartialtoList()
        {
            var blogList = db.Blog.ToList();
            return View(blogList);
        }

    }
}