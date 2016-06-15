using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JMLoc15.Models;

namespace JMLoc15.Controllers
{
    public class UserLinesController : Controller
    {
        private JMLoc15Context db = new JMLoc15Context();

        // GET: UserLines
        public ActionResult Index()
        {
            return View(db.UserLines.ToList());
        }

        // GET: UserLines/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserLines userLines = db.UserLines.Find(id);
            if (userLines == null)
            {
                return HttpNotFound();
            }
            return View(userLines);
        }

        // GET: UserLines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserLines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] UserLines userLines)
        {
            if (ModelState.IsValid)
            {
                db.UserLines.Add(userLines);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userLines);
        }

        // GET: UserLines/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserLines userLines = db.UserLines.Find(id);
            if (userLines == null)
            {
                return HttpNotFound();
            }
            return View(userLines);
        }

        // POST: UserLines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] UserLines userLines)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userLines).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userLines);
        }

        // GET: UserLines/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserLines userLines = db.UserLines.Find(id);
            if (userLines == null)
            {
                return HttpNotFound();
            }
            return View(userLines);
        }

        // POST: UserLines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            UserLines userLines = db.UserLines.Find(id);
            db.UserLines.Remove(userLines);
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
