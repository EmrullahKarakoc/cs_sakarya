using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Web_Programlama_Dersi_Proje_Ödevi.Controllers
{
    public class LanguageController : Controller
    {

        public ActionResult Sec(string LanguageAbbrevation)
        {
            if(LanguageAbbrevation != null)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(LanguageAbbrevation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LanguageAbbrevation);
            }
            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = LanguageAbbrevation;
            Response.Cookies.Add(cookie);
            return RedirectToAction("Index","Home");
        }

        
    }
}