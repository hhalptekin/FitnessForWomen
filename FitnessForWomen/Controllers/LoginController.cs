using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FitnessForWomen.Models;
namespace FitnessForWomen.Controllers
{

    public class LoginController : Controller
    {
        

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
    }
}