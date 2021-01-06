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
    public class SepetsController : Controller
    {
        private SauCarEntities6 db = new SauCarEntities6();

        // GET: Sepets
        public ActionResult Index()
        {
            if (Session["IsAdmin"] != null)
            {
                var sepet = db.Sepet.Include(s => s.Arac).Include(s => s.User);
                return View(sepet.ToList());
            }
            else
            {
                return RedirectToAction("Profil", "Users", new { id = Session["UserId"] });
            }

        }

        // GET: Sepets/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Sepet sepet = db.Sepet.Find(id);
            if (sepet == null)
            {
                return HttpNotFound();
            }
            return View(sepet);
        }

        // GET: Sepets/Create
        public ActionResult Create()
        {
            ViewBag.SepetAracId = new SelectList(db.Arac, "AracId", "AracModel");
            ViewBag.SepetUserID = new SelectList(db.User, "UserId", "UserName");
            return View();
        }

        // POST: Sepets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SepetUserID,SepetAracId,SepetAlimTarihi,SepetTeslimTarihi,SepetID")] Sepet sepet)
        {
            if (ModelState.IsValid)
            {
                db.Sepet.Add(sepet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SepetAracId = new SelectList(db.Arac, "AracId", "AracModel", sepet.SepetAracId);
            ViewBag.SepetUserID = new SelectList(db.User, "UserId", "UserName", sepet.SepetUserID);
            return View(sepet);
        }

        // GET: Sepets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sepet sepet = db.Sepet.Find(id);
            if (sepet == null)
            {
                return HttpNotFound();
            }
            ViewBag.SepetAracId = new SelectList(db.Arac, "AracId", "AracModel", sepet.SepetAracId);
            ViewBag.SepetUserID = new SelectList(db.User, "UserId", "UserName", sepet.SepetUserID);
            return View(sepet);
        }

        // POST: Sepets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SepetUserID,SepetAracId,SepetAlimTarihi,SepetTeslimTarihi,SepetID")] Sepet sepet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sepet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SepetAracId = new SelectList(db.Arac, "AracId", "AracModel", sepet.SepetAracId);
            ViewBag.SepetUserID = new SelectList(db.User, "UserId", "UserName", sepet.SepetUserID);
            return View(sepet);
        }

        // GET: Sepets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sepet sepet = db.Sepet.Find(id);
            if (sepet == null)
            {
                return HttpNotFound();
            }
            return View(sepet);
        }

        // POST: Sepets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sepet sepet = db.Sepet.Find(id);
            db.Sepet.Remove(sepet);
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
