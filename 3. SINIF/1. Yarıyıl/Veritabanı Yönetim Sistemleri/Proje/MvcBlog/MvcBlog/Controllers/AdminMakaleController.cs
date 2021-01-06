using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBlog.Models;
using System.Web.Helpers;
using System.IO;
using PagedList;
using PagedList.Mvc;
using System.Data.SqlClient;

namespace MvcBlog.Controllers
{
    public class AdminMakaleController : Controller
    {
        mvcblogDB db = new mvcblogDB();
        // GET: AdminMakale
        public ActionResult Index(int Page=1)
        {
            var makales = db.Makales.SqlQuery("Select * from Makale").ToPagedList(Page, 10);
                //OrderByDescending(m=>m.Makaleid).ToPagedList(Page,10);
            return View(makales);
        }

        // GET: AdminMakale/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminMakale/Create
        public ActionResult Create()
        {
            ViewBag.Kategoriid = new SelectList(db.Kategoris, "Kategoriid", "KategoriAdi");
            return View();
        }

        // POST: AdminMakale/Create
        [HttpPost]
        public ActionResult Create(Makale makale,string etiketler,HttpPostedFileBase Foto )
        {
            //Model kısmında çalışacak komutlar
            if (ModelState.IsValid)
            {
                if (Foto != null)
                {
                    WebImage img = new WebImage(Foto.InputStream);
                    FileInfo fotoinfo = new FileInfo(Foto.FileName);

                    string newfoto = Guid.NewGuid().ToString() + fotoinfo.Extension;
                    img.Resize(800, 350);
                    img.Save("~/Uploads/MakaleFoto/" + newfoto);
                    makale.Foto = "/Uploads/MakaleFoto/" + newfoto;
                    
                }
                if (etiketler != null)
                {
                    string[] etiketdizi = etiketler.Split(',');
                    foreach (var i in etiketdizi)
                    {
                        var yenietiket = new Etiket { EtiketAdi = i };
                        db.Etikets.Add(yenietiket);
                        makale.Etikets.Add(yenietiket);
                    }
                }
                makale.Uyeid = Convert.ToInt32(Session["uyeid"]);
                makale.Okuma = 1;
                db.Makales.Add(makale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
                
                
                return View(makale);
            
        }

        // GET: AdminMakale/Edit/5
        public ActionResult Edit(int id)
        {
            var makale = db.Makales.Where(m => m.Makaleid == id).SingleOrDefault();
            if (makale == null)
            {
                return HttpNotFound();
            }
            ViewBag.Kategoriid = new SelectList(db.Kategoris, "Kategoriid", "KategoriAdi", makale.Kategoriid);
            return View(makale);
        }

        // POST: AdminMakale/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, HttpPostedFileBase Foto,Makale makale)
        {
            try
            {
                // Makales te değişkilik yapılacak
                var makales = db.Makales.Where(m => m.Makaleid == id).SingleOrDefault();
                if (Foto != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(makales.Foto))) 
                    {
                        System.IO.File.Delete(Server.MapPath(makales.Foto));
                    }
                    WebImage img = new WebImage(Foto.InputStream);
                    FileInfo fotoinfo = new FileInfo(Foto.FileName);

                    string newfoto = Guid.NewGuid().ToString() + fotoinfo.Extension;
                    img.Resize(800, 350);
                    img.Save("~/Uploads/MakaleFoto/" + newfoto);
                    makales.Foto = "/Uploads/MakaleFoto/" + newfoto;
                    makales.Baslik = makale.Baslik;
                    makales.Icerik = makale.Icerik;
                    makales.Kategoriid = makale.Kategoriid;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                ViewBag.Kategoriid = new SelectList(db.Kategoris, "Kategoriid", "KategoriAdi", makale.Kategoriid);
                return View(makale);
            }
        }

        // GET: AdminMakale/Delete/5
        public ActionResult Delete(int id)
        {

            var makale = db.Makales.Where(m => m.Makaleid == id).SingleOrDefault();
            if (makale == null)
            {
                return HttpNotFound();
            }
            return View(makale);
        }

        // POST: AdminMakale/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, FormCollection collection)
        {
            try
            {
                // Etiket yorum foto makale her şeyi silmemiz lazım
                var makales = db.Makales.Where(m => m.Makaleid == id).SingleOrDefault();
                if (makales == null)
                {
                    return HttpNotFound();
                }
                if (System.IO.File.Exists(Server.MapPath(makales.Foto))) 
                {
                    System.IO.File.Delete(Server.MapPath(makales.Foto));
                }
                foreach(var i in makales.Yorums.ToList())
                {
                    db.Yorums.Remove(i);
                }
                foreach(var i in makales.Etikets.ToList())
                {
                    db.Etikets.Remove(i);
                }
                db.Database.ExecuteSqlCommand("delete from Makale where Makaleid=@Ara", new SqlParameter("@Ara", id));
                    //Makales.Remove(makales);
                db.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
