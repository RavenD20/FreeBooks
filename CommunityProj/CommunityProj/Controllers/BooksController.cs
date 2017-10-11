using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CommunityProj.Models;
using Postal;

using System.Net.Mail;

namespace CommunityProj.Controllers
{
    public class BooksController : Controller
    {
         private ApplicationDbContext db = new ApplicationDbContext();
       

        // GET: 
        public ActionResult Index(string searchby, string searchString)
        {

          

            if (searchby == "Author")
            {
                return View(db.Books.Where(x => x.Author.StartsWith(searchString) || searchString == null).ToList());
            }
            if (searchby == "ISBN")
            {

                return View(db.Books.Where(x => x.ISBN.StartsWith(searchString) || searchString == null).ToList());

            }

            else
            {
                return View(db.Books.Where(x => x.Title.StartsWith(searchString) || searchString == null).ToList());

            }
            
        }



        // GET: Books/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

 

       //
       // public ActionResult Ask()
       // {
          
       //     return View("RequestBook");
       // }

        public ActionResult ReserveBooks(int id)
        {
            ViewBag.Id = id;
            return View();
        }


        public ActionResult ReserveInstruct()
        {
            ViewBag.Message = "Instructions on what to do";
            return View();
        }

       

        public ActionResult Checkout()
        {
            return View();
        }


        //public ActionResult Request()
        //{
        //    return View();
        //}



        //[HttpPost]
        //public ActionResult Request(NewCommentEmail Model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Books.Add(Email);
        //        db.SaveChanges();

        //        var email = new NewCommentEmail
        //        {
        //            To = "Fleetsd@yahoo.com",
        //            UserName = Model.UserName,
        //            Comment = Model.To
        //        };
        //        email.Send();
        //    }

        //    return RedirectToAction("Index");
        //}







        //public ActionResult RequestBook()
        //{

        //    return View();
        //}



        // POST: Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 



        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Ask([Bind(Include = "ReserveID,ReserveTitle,ReserveAuthor,ReserveISBN")]ReserveBook ReserveBook)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.ReserveBooks.Add(ReserveBook);
        //        db.SaveChanges();
        //        return RedirectToAction("ReserveBooks");
        //    }

        //    return View(ReserveBook);
        //}


        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Author,ISBN")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Thanks");
            }

            return View(book);
        }



        public ActionResult Thanks()
        {
            ViewBag.Message = "Thank you for your donation";

            return View();
        }


        // GET: Books/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Author,ISBN")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: Books/Delete/5
        public ActionResult Reserve(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Reserve")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

       
       







    }



}
