using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyHealthRecords.Models;

namespace MyHealthRecords.Controllers
{
    public class SystemAdministratorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SystemAdministrators
        public ActionResult Index()
        {
            return View(db.SystemAdministrators.ToList());
        }

        // GET: SystemAdministrators/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemAdministrator systemAdministrator = db.SystemAdministrators.Find(id);
            if (systemAdministrator == null)
            {
                return HttpNotFound();
            }
            return View(systemAdministrator);
        }

        // GET: SystemAdministrators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SystemAdministrators/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Surname")] SystemAdministrator systemAdministrator)
        {
            if (ModelState.IsValid)
            {
                db.SystemAdministrators.Add(systemAdministrator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(systemAdministrator);
        }

        // GET: SystemAdministrators/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemAdministrator systemAdministrator = db.SystemAdministrators.Find(id);
            if (systemAdministrator == null)
            {
                return HttpNotFound();
            }
            return View(systemAdministrator);
        }

        // POST: SystemAdministrators/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Surname")] SystemAdministrator systemAdministrator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(systemAdministrator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(systemAdministrator);
        }

        // GET: SystemAdministrators/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemAdministrator systemAdministrator = db.SystemAdministrators.Find(id);
            if (systemAdministrator == null)
            {
                return HttpNotFound();
            }
            return View(systemAdministrator);
        }

        // POST: SystemAdministrators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SystemAdministrator systemAdministrator = db.SystemAdministrators.Find(id);
            db.SystemAdministrators.Remove(systemAdministrator);
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
