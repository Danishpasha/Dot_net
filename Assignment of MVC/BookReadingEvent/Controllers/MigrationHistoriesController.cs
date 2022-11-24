using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookReadingEvent.Models;

namespace BookReadingEvent.Controllers
{
    public class MigrationHistoriesController : Controller
    {
        private BookReadingEventEntities db = new BookReadingEventEntities();

        // GET: MigrationHistories
        public ActionResult Index()
        {
            return View(db.MigrationHistories.ToList());
        }

        // GET: MigrationHistories/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MigrationHistory migrationHistory = db.MigrationHistories.Find(id);
            if (migrationHistory == null)
            {
                return HttpNotFound();
            }
            return View(migrationHistory);
        }

        // GET: MigrationHistories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MigrationHistories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MigrationId,ContextKey,Model,ProductVersion")] MigrationHistory migrationHistory)
        {
            if (ModelState.IsValid)
            {
                db.MigrationHistories.Add(migrationHistory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(migrationHistory);
        }

        // GET: MigrationHistories/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MigrationHistory migrationHistory = db.MigrationHistories.Find(id);
            if (migrationHistory == null)
            {
                return HttpNotFound();
            }
            return View(migrationHistory);
        }

        // POST: MigrationHistories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MigrationId,ContextKey,Model,ProductVersion")] MigrationHistory migrationHistory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(migrationHistory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(migrationHistory);
        }

        // GET: MigrationHistories/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MigrationHistory migrationHistory = db.MigrationHistories.Find(id);
            if (migrationHistory == null)
            {
                return HttpNotFound();
            }
            return View(migrationHistory);
        }

        // POST: MigrationHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MigrationHistory migrationHistory = db.MigrationHistories.Find(id);
            db.MigrationHistories.Remove(migrationHistory);
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
