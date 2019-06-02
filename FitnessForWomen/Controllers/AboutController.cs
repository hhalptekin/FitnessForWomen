using FitnessForWomen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessForWomen.Controllers
{

  
    public class AboutController : Controller
    {
        FitnessForWomenEntitiesLast db = new FitnessForWomenEntitiesLast();
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Egitmenlerimiz()
        {
            var egitmenler = db.Egitmenler.ToList();

            return View(egitmenler);
        }
    }
}