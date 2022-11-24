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
    [Authorize]
    public class EventsController : Controller
    {
        private BookReadingEventEntities db = new BookReadingEventEntities();

        // GET: Events

        [AllowAnonymous]
        public ActionResult Index()
        {

            return View();
        }

        [AllowAnonymous]
        //For Upcoming Events
        public ActionResult Upcoming_Events()
        {
            var ul = db.Events.Where(x => x.StartDate >= System.DateTime.Now).ToList();
            return View(ul);
        }


        [AllowAnonymous]
        //For Past EVents
        public ActionResult Past_Events()
        {
            var pl = db.Events.Where(x => x.StartDate < System.DateTime.Now).ToList();
            return View(pl);
        }
        // GET: Events/Details/5
        [Authorize(Roles = "danishpasha@gmail.com")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        
        // GET: Events/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventID,Title,StartDate,StartTime,Location,Duration,Description,OtherDetails,InviteCount,UserID,isPublic,UserFullName")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(@event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(@event);
        }

        // GET: Events/Edit/5
        [Authorize(Roles = "danishpasha@gmail.com")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "danishpasha@gmail.com")]
        public ActionResult Edit([Bind(Include = "EventID,Title,StartDate,StartTime,Location,Duration,Description,OtherDetails,InviteCount,UserID,isPublic,UserFullName")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@event);
        }

        // GET: Events/Delete/5
        [Authorize(Roles = "danishpasha@gmail.com")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Events/Delete/5
        [Authorize(Roles = "danishpasha@gmail.com")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event @event = db.Events.Find(id);
            db.Events.Remove(@event);
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
