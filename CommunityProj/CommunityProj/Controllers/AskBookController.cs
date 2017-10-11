using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CommunityProj.Models;

namespace CommunityProj.Controllers
{
    public class AskBookController: Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        [HttpGet]
        public ActionResult AskBook(string FirstName , string TitleName)
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AskBook([Bind(Include = "ID,FirstName,TitleName")] AskBook AskBook)
        {     

            
            return View("RequestBook", AskBook);
        }

        public ActionResult RequestBook([Bind(Include = "ID,FirstName,TitleName")]AskBook Askbook)
        {
            return View(Askbook);
           
        }





    }



}
