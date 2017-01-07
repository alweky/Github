using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMovie.DAL;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class RazarsController : Controller
    {
        private MovieContext db = new MovieContext();

        // GET: Razars
        public ActionResult Index()
        {
            return View(db.Razars.ToList());
        }

        public ActionResult Intro()
        {
            return View();
        }

        // GET: Razars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Razar razar = db.Razars.Find(id);
            if (razar == null)
            {
                return HttpNotFound();
            }
            return View(razar);
        }

        // GET: Razars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Razars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID")] Razar razar)
        {
            if (ModelState.IsValid)
            {
                db.Razars.Add(razar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(razar);
        }

        // GET: Razars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Razar razar = db.Razars.Find(id);
            if (razar == null)
            {
                return HttpNotFound();
            }
            return View(razar);
        }

        // POST: Razars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID")] Razar razar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(razar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(razar);
        }

        // GET: Razars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Razar razar = db.Razars.Find(id);
            if (razar == null)
            {
                return HttpNotFound();
            }
            return View(razar);
        }

        // POST: Razars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Razar razar = db.Razars.Find(id);
            db.Razars.Remove(razar);
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
