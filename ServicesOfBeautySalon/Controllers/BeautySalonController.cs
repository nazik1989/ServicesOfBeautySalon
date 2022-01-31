using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServicesOfBeautySalon.Controllers
{
    public class BeautySalonController : Controller
    {
        // GET: Service
        // in Beautysalon-Service table, every salon should ask its cost, change baza, service musn't have price,
        //The price column should be in Beautysalon-Service table.
        public ActionResult Index()
        {
            return View();
        }

    }
}