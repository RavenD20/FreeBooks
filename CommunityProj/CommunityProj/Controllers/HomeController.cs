using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;

namespace CommunityProj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A library for the Community. By the Community.";

            return View();
        }





        public ActionResult Contact()
        {
            ViewBag.Message = "How to reach us.";

            return View();
        }

     




    }






}