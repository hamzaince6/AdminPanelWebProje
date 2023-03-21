using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminPanelWebProje.Models.Class;

namespace AdminPanelWebProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Anasayfa.ToList();

            return View(deger);
        }
    }
}