using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GroupProjectTaffyStore.Models;

namespace GroupProjectTaffyStore.Controllers
{
    public class TaffiesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Taffies
        public ActionResult Index()
        {
            IQueryable<Taffy> taffy = db.Taffies.Include(a => a.ID);
            return View(taffy.ToList());
        }

        // GET: Taffies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Taffy taffy = db.Taffies.Find(id);
            if (taffy == null)
            {
                return HttpNotFound();
            }
            return View(taffy);
        }

        // GET: Taffies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Taffies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Flavor,Size,Stock,Price,Manufacturer")] Taffy taffy)
        {
            if (ModelState.IsValid)
            {
                db.Taffies.Add(taffy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taffy);
        }

        // GET: Taffies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Taffy taffy = db.Taffies.Find(id);
            if (taffy == null)
            {
                return HttpNotFound();
            }
            return View(taffy);
        }

        // POST: Taffies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Flavor,Size,Stock,Price,Manufacturer")] Taffy taffy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taffy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taffy);
        }

        // GET: Taffies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Taffy taffy = db.Taffies.Find(id);
            if (taffy == null)
            {
                return HttpNotFound();
            }
            return View(taffy);
        }

        // POST: Taffies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Taffy taffy = db.Taffies.Find(id);
            db.Taffies.Remove(taffy);
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
