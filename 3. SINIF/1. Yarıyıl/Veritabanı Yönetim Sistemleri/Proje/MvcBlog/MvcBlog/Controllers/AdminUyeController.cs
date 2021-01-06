using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcBlog.Models;

namespace MvcBlog.Controllers
{
    public class AdminUyeController : Controller
    {
        private mvcblogDB db = new mvcblogDB();

        // GET: AdminUye
        public ActionResult Index()
        {
            var uyes = db.Uyes.Include(u => u.Yetki);
            return View(uyes.OrderByDescending(u=>u.Uyeid).ToList());
        }

        // GET: AdminUye/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uye uye = db.Uyes.Find(id);
            if (uye == null)
            {
                return HttpNotFound();
            }
            return View(uye);
        }

        // GET: AdminUye/Create
        public ActionResult Create()
        {
            ViewBag.Yetkiid = new SelectList(db.Yetkis, "Yetkiid", "Yetki1");
            return View();
        }

        // POST: AdminUye/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Uyeid,KullaniciAdi,Email,Sifre,AdSoyad,Yetkiid")] Uye uye,string rozetler)
        {
            if (ModelState.IsValid)
            {
                if (rozetler != null)
                {
                    string[] etiketdizi = rozetler.Split(',');
                    foreach (var i in etiketdizi)
                    {
                        var yenirozet = new Rozet { Rozetadi = i };
                        db.Rozets.Add(yenirozet);
                        uye.Rozets.Add(yenirozet);
                    }
                }
                db.Uyes.Add(uye);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Yetkiid = new SelectList(db.Yetkis, "Yetkiid", "Yetki1", uye.Yetkiid);
            return View(uye);
        }

        // GET: AdminUye/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uye uye = db.Uyes.Find(id);
            if (uye == null)
            {
                return HttpNotFound();
            }
            ViewBag.Yetkiid = new SelectList(db.Yetkis, "Yetkiid", "Yetki1", uye.Yetkiid);
            return View(uye);
        }

        // POST: AdminUye/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Uyeid,KullaniciAdi,Email,Sifre,AdSoyad,Yetkiid")] Uye uye)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uye).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Yetkiid = new SelectList(db.Yetkis, "Yetkiid", "Yetki1", uye.Yetkiid);
            return View(uye);
        }

        // GET: AdminUye/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uye uye = db.Uyes.Find(id);
            if (uye == null)
            {
                return HttpNotFound();
            }
            return View(uye);
        }

        // POST: AdminUye/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Uye uye = db.Uyes.Find(id);
            //Remove(uye);
            try
            {
                db.Database.ExecuteSqlCommand("delete from Uye where Uyeid=@Ara", new SqlParameter("@Ara", id));

               // db.SaveChanges();

            }
            catch
            {
                //Response.Write("<script lang='JavaScript'>alert('Bi Deli Mühendis');</script>");
                return RedirectToAction("Index");
            }
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
