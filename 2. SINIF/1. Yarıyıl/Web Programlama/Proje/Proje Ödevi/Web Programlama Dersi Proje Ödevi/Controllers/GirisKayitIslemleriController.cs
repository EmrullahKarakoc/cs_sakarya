using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Programlama_Dersi_Proje_Ödevi.Models;

namespace Web_Programlama_Dersi_Proje_Ödevi.Controllers
{
    public class GirisKayitIslemleriController : Controller
    {
        private object UserModel;


        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kontrol(Web_Programlama_Dersi_Proje_Ödevi.Models.User Kullanici)
        {
            using (SauCarEntities6 db = new SauCarEntities6())
            {
                
                var UserDetay = db.User.Where(x => x.UserName == Kullanici.UserName && x.UserPassword == Kullanici.UserPassword).FirstOrDefault();

                if (UserDetay == null)
                {
                    return View("Giris", Kullanici);
                }
                else
                {
                    if (UserDetay.UserPassword == Kullanici.UserPassword)
                    {
                        Session["UserId"] = UserDetay.UserId;
                        Session["UserName"] = UserDetay.UserName;
                        Session["IsAdmin"] = UserDetay.IsAdmin;

                        return RedirectToAction("Index", "Home");
                    }
                    else
                        return View("Giris", Kullanici);

                }
            }
        }

        [HttpGet]
        public ActionResult Kayit()
        {
            User user1 = new User();
            return View();
        }
        [HttpPost]
        public ActionResult Kayit(User Kullanici,string Sifretekrari)
        {
            if(Kullanici.UserPassword == Sifretekrari)
            {
                using (SauCarEntities6 dbModel = new SauCarEntities6())
                {
                    dbModel.User.Add(Kullanici);
                    dbModel.SaveChanges();
                }
                ModelState.Clear();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Kayit", "GirisKayitIslemleri");
        }


        public ActionResult Cikis()
        {
            int UserId = (int)Session["UserId"];
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

    }
}