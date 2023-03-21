using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PotholeDetectorApp.Models;

namespace PotholeDetectorApp.Controllers
{
    public class PotholesController : Controller
    {
        private PotholeDetectorDbContext db = new PotholeDetectorDbContext();

        // GET: Potholes
        public ActionResult Index()
        {
            return View(db.Potholes.ToList());
        }

        // GET: Potholes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pothole pothole = db.Potholes.Find(id);
            if (pothole == null)
            {
                return HttpNotFound();
            }
            return View(pothole);
        }

        // GET: Potholes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Potholes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Latitude,Longitude,Location,Img,Note")] Pothole pothole)
        {
            if (ModelState.IsValid)
            {
                db.Potholes.Add(pothole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pothole);
        }

        // GET: Potholes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pothole pothole = db.Potholes.Find(id);
            if (pothole == null)
            {
                return HttpNotFound();
            }
            return View(pothole);
        }

        // POST: Potholes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Latitude,Longitude,Location,Img,Note")] Pothole pothole)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pothole).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pothole);
        }

        // GET: Potholes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pothole pothole = db.Potholes.Find(id);
            if (pothole == null)
            {
                return HttpNotFound();
            }
            return View(pothole);
        }

        // POST: Potholes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pothole pothole = db.Potholes.Find(id);
            db.Potholes.Remove(pothole);
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
