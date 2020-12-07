using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webders1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bu ödev MBLP223 - Web Ugulama Geliştirme vize ödevidir. Bu ödevin içeriğinde liste, bu listeyi güncelleme ve listeden veri silme işlemleri bulunmaktadır. " +
                "Ayrıyeten  hakkında ve kişi bilgileri kısmı oluşturulup bu yerlere gerekli bilgiler girilmiştir.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}