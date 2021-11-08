using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1000Kitap.Controllers
{
    public class HakkındaController : Controller
    {
        // GET: Hakkında

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult kullanim_sartlari()
        {
            return View();
        }

        public ActionResult gizlilik_politikası()
        {
            return View();
        }
        public ActionResult topluluk_kuralları()
        {
            return View();
        }

        public ActionResult reklam_verin()
        {
            return View();
        }
        public ActionResult iletisim()
        {
            return View();
        }
        public ActionResult dizinler()
        {
            return View();
        }

    }
}