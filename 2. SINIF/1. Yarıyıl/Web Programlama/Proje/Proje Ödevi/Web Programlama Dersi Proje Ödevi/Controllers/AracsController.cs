using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_Programlama_Dersi_Proje_Ödevi.Models;

namespace Web_Programlama_Dersi_Proje_Ödevi.Controllers
{
    public class AracsController : Controller
    {
        private SauCarEntities6 db = new SauCarEntities6();

        // GET: Aracs
        public ActionResult Index()
        {
            return View(db.Arac.ToList());
        }
        public ActionResult Araclar()
        {
            return View(db.Arac.ToList());
        }
        // GET: Aracs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arac arac = db.Arac.Find(id);
            if (arac == null)
            {
                return HttpNotFound();
            }
            return View(arac);
        }

        // GET: Aracs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aracs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AracId,AracModel,AracFiyat,AracTuru")] Arac arac)
        {
            if (ModelState.IsValid)
            {
                db.Arac.Add(arac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(arac);
        }

        // GET: Aracs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arac arac = db.Arac.Find(id);
            if (arac == null)
            {
                return HttpNotFound();
            }
            return View(arac);
        }

        // POST: Aracs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AracId,AracModel,AracFiyat,AracTuru")] Arac arac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(arac);
        }

        // GET: Aracs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arac arac = db.Arac.Find(id);
            if (arac == null)
            {
                return HttpNotFound();
            }
            return View(arac);
        }

        // POST: Aracs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Arac arac = db.Arac.Find(id);
            db.Arac.Remove(arac);
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
