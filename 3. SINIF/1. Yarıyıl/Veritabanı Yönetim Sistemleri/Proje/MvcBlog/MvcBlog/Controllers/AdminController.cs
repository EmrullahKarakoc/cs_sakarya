using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBlog.Models;

namespace MvcBlog.Controllers
{
    public class AdminController : Controller
    {
        mvcblogDB db = new mvcblogDB();//veri tabanına erişim
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.MakaleSayisi = db.Makales.Count();//makale sayisi
            ViewBag.YorumSayisi = db.Yorums.Count();//yorum sayisi
            ViewBag.KategoriSayisi = db.Kategoris.Count();
            ViewBag.UyeSayisi = db.Uyes.Count();
            return View();
        }
    }
}