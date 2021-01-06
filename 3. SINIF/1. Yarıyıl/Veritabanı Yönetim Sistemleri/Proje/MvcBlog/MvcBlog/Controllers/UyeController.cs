using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBlog.Models;
using System.Web.Helpers;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace MvcBlog.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        mvcblogDB db = new mvcblogDB();


        public ActionResult Index(int id)
        {
            var uye = db.Uyes.Where(u => u.Uyeid == id).SingleOrDefault();
            if (Convert.ToInt32(Session["uyeid"])!=uye.Uyeid)//Güvenlik için yapıldı.Başka üyeye erişilmesin diye
            {
                return HttpNotFound();
            }
            return View(uye);
        }
        public ActionResult Login()
        {



            return View();
        }
        [HttpPost]
        public ActionResult Login(Uye uye)
        {
            var login = db.Uyes.Where(u => u.KullaniciAdi == uye.KullaniciAdi).SingleOrDefault();
            if (login == null)
            {
                ViewBag.Hata = "Giris yapilamadi!";
                return View();
            }
            if (login.KullaniciAdi==uye.KullaniciAdi && login.Sifre == uye.Sifre)
            {
                Session["uyeid"] = login.Uyeid;
                Session["kullaniciadi"] = login.KullaniciAdi;
                Session["yetkiid"] = login.Yetkiid;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Hata = "Giris yapilamadi!";
                return View();
            }
                
        }
        public ActionResult Logout()
        {
            Session["uyeid"] = null;
            Session.Abandon();//sonlandırmak için sessionları
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Create()
        {
            ViewBag.IlceId = new SelectList(db.Ilces, "Id", "Ilceadi");
            ViewBag.SehirId = new SelectList(db.Sehirs, "Id", "Sehiradi");
            ViewBag.UlkeId = new SelectList(db.Ulkes, "Id", "Ulkeadi");
            ViewBag.Yetkiid = new SelectList(db.Yetkis, "Yetkiid", "Yetki1");
            return View();
        }

        [HttpPost]

        public ActionResult Create(Uye uye , HttpPostedFileBase Foto)
        {

            if (ModelState.IsValid)
            {
                if (Foto != null)
                {
                    WebImage img = new WebImage(Foto.InputStream);
                    FileInfo fotoinfo = new FileInfo(Foto.FileName);

                    string newfoto = Guid.NewGuid().ToString() + fotoinfo.Extension;
                    img.Resize(150, 150);
                    img.Save("~/Uploads/UyeFoto/" + newfoto);
                    uye.Foto = "/Uploads/UyeFoto/" + newfoto;
                    uye.Yetkiid = 2;
                    db.Database.ExecuteSqlCommand("SP_UYECREATE '"+uye.KullaniciAdi+"','"+uye.Sifre+"','"+uye.AdSoyad + "','" +uye.Foto + "',"+ uye.Yetkiid.ToString() + "," +uye.UlkeId.ToString() + "," + uye.SehirId.ToString()+ "," + uye.IlceId.ToString());

                    //db.Uyes.Add(uye);
                    db.SaveChanges();
                    Session["uyeid"] = db.Uyes.SqlQuery("Select * from Uye where KullaniciAdi=@Kullaniciadi", new SqlParameter("@Kullaniciadi", uye.KullaniciAdi)).SingleOrDefault().Uyeid; 
                    Session["kullaniciadi"] = uye.KullaniciAdi;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Fotoğraf", "Fotoğraf Seçiniz");
                }


            }

            ViewBag.IlceId = new SelectList(db.Ilces, "Id", "Ilceadi", uye.IlceId);
            ViewBag.SehirId = new SelectList(db.Sehirs, "Id", "Sehiradi", uye.SehirId);
            ViewBag.UlkeId = new SelectList(db.Ulkes, "Id", "Ulkeadi", uye.UlkeId);
            ViewBag.Yetkiid = new SelectList(db.Yetkis, "Yetkiid", "Yetki1", uye.Yetkiid);
            return View(uye);
        }

        public ActionResult Edit(int id)
        {
            var uye = db.Uyes.SqlQuery("Select * from Uye where Uyeid=@uyeid", new SqlParameter("@uyeid", id)).SingleOrDefault();
                //Where(u => u.Uyeid == id).SingleOrDefault();
            if (Convert.ToInt32(Session["uyeid"])!=uye.Uyeid)
            {
                return HttpNotFound();
            }
            return View(uye);
        }
        [HttpPost]
        public ActionResult Edit(Uye uye,int id,HttpPostedFileBase Foto)
        {
            if (ModelState.IsValid)
            {
                var uyes = db.Uyes.SqlQuery("Select * from Uye where Uyeid=@uyeid", new SqlParameter("@uyeid", id)).SingleOrDefault();

                //Where(u => u.Uyeid == id).SingleOrDefault();
                if (Foto!=null)
                {
                    if (System.IO.File.Exists(Server.MapPath(uye.Foto)))
                    {
                        System.IO.File.Delete(Server.MapPath(uyes.Foto));
                    }
                    WebImage img = new WebImage(Foto.InputStream);
                    FileInfo fotoinfo = new FileInfo(Foto.FileName);

                    string newfoto = Guid.NewGuid().ToString() + fotoinfo.Extension;
                    img.Resize(150, 150);
                    img.Save("~/Uploads/UyeFoto/" + newfoto);
                    uyes.Foto = "/Uploads/UyeFoto/" + newfoto;
                    }
                    uyes.AdSoyad = uye.AdSoyad;
                    uyes.KullaniciAdi = uye.KullaniciAdi;
                    uyes.Sifre = uye.Sifre;
                    //uyes.emailAdress = uye.emailAdress;
                    try
                    {
                    db.SaveChanges();
                    }
                    catch
                    {
                    ViewBag.Hata = "Kullanici adini degistiremezsiniz!";
                    return View();
                    }
                    db.SaveChanges();
                    Session["kullaniciadi"] = uye.KullaniciAdi;
                    return RedirectToAction("Index", "Home", new { id = uyes.Uyeid });
                
            }
            return View();
        }

        public ActionResult UyeProfil(int id)
        {
            var uye = db.Uyes.SqlQuery("Select * from Uye where Uyeid=@uyeid", new SqlParameter("@uyeid", id)).SingleOrDefault();

            return View(uye);
        }
    }
}