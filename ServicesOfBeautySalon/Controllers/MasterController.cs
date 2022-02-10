using ServicesOfBeautySalon.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServicesOfBeautySalon.Controllers
{
    public class MasterController : Controller
    {
        // GET: Master
        public ActionResult Index()
        {
            var masters = MasterService.GetMasters();
            return View(masters);
        }

        public ActionResult GetSpecialMaster(long id)
        {
            var master = MasterService.GetSpecialMaster(id);
            return View("GetSpecialMaster", master);
        }
    }

}