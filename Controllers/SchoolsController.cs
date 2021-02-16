using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SteadyRain.DataAccess;
using SteadyRain.Models;

namespace SteadyRain.Controllers
{
    public class SchoolsController : Controller
    {
        private Schools db = new Schools();

        // GET: Schools
        public ActionResult Index()
        {
            return View(db.SchoolModels.ToList());
        }

        // GET: Schools/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolModel schoolModel = db.SchoolModels.Find(id);
            if (schoolModel == null)
            {
                return HttpNotFound();
            }
            return View(schoolModel);
        }

        // GET: Schools/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Schools/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SchoolId,SchoolName,Address1,Address2,City,State,ZipCode")] SchoolModel schoolModel)
        {
            if (ModelState.IsValid)
            {
                db.SchoolModels.Add(schoolModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(schoolModel);
        }

        // GET: Schools/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolModel schoolModel = db.SchoolModels.Find(id);
            if (schoolModel == null)
            {
                return HttpNotFound();
            }
            return View(schoolModel);
        }

        // POST: Schools/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SchoolId,SchoolName,Address1,Address2,City,State,ZipCode")] SchoolModel schoolModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schoolModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(schoolModel);
        }

        // GET: Schools/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolModel schoolModel = db.SchoolModels.Find(id);
            if (schoolModel == null)
            {
                return HttpNotFound();
            }
            return View(schoolModel);
        }

        // POST: Schools/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SchoolModel schoolModel = db.SchoolModels.Find(id);
            db.SchoolModels.Remove(schoolModel);
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
