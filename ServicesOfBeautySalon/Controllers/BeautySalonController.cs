using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServicesOfBeautySalon.DAL;

namespace ServicesOfBeautySalon.Controllers
{
    public class BeautySalonController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            return View();
        }

    }
}