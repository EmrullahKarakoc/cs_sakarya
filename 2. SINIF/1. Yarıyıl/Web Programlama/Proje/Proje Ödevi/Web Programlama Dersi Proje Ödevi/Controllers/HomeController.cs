using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Programlama_Dersi_Proje_Ödevi.Models;

namespace Web_Programlama_Dersi_Proje_Ödevi.Controllers
{
    public class HomeController : Controller
    {
        private SauCarEntities6 db = new SauCarEntities6();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }

    }
}