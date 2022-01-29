
using ServicesOfBeautySalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServicesOfBeautySalon.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        [HttpGet]
        public ActionResult Index()
        {
            //List<ServiceModel> model;

            //using (var context = new BeautySalonServiceDBConection())
            //{
            //    var services = context.Services.ToList();
            //    model = services.Select(s => new ServiceModel
            //    {
            //        ID = s.ID,
            //        Name = s.Name,
            //        ServiceTypeID = s.ServiceTypeID,
            //        Price = s.Price
            //    }).ToList();
            //}

            //return View(model);
            return View();
        }

        [HttpGet]
        public ActionResult CountOfSevicesActionResult()
        {
            int count;

            count = 1000;
            return Json(count, JsonRequestBehavior.AllowGet);
        }
    }
}