using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuirkyBookRental.Models;
using QuirkyBookRental.Utility;

namespace QuirkyBookRental.Controllers
{
    [Authorize(Roles = SD.AdminUserRole)]
    public class GenreController : Controller
    {
        // GET: Genre

        private ApplicationDbContext db;

        public GenreController()
        {
            db = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View(db.Genres.ToList());
        }

        //Get Action
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                db.Genres.Add(genre);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Genre genre = db.Genres.Find(id);
            if (genre == null)
            {
                return HttpNotFound();
            }
            return View(genre);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Genre genre = db.Genres.Find(id);
            if (genre == null)
            {
                return HttpNotFound();
            }
            return View(genre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Genre genre)
        {
            if (ModelState.IsValid)
            {
                //var GenreInDb = db.Genres.FirstOrDefault(g => g.Id.Equals(genre.Id));
                //GenreInDb.Name = genre.Name;
                db.Entry(genre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Genre genre = db.Genres.Find(id);
            if (genre == null)
            {
                return HttpNotFound();
            }
            return View(genre);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                Genre genre = db.Genres.Find(id);
                db.Genres.Remove(genre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}