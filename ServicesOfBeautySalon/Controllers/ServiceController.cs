
using ServicesOfBeautySalon.BLL;
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
        ServiceService serviceService = new ServiceService();
        public List<ServiceModel> services { get; set; }

       
        [HttpGet]
        public ActionResult Index()
        {
            services = serviceService.GetServices();

            return View(services);
        }

        [HttpPost]
        public ActionResult SearchServicesByName(SearchModel model)
        {
           var searchedServices = serviceService.SearchServicesByName(model.Name);
           return View("Index", searchedServices);
        }

        [HttpGet]
        public ActionResult IndexForSpecificMaster(long id)
        {
            List<ServiceModel> model = new List<ServiceModel>() {
                new ServiceModel
                { ID = id,
                Name = "Hardcoded special Master service",
                ServiceTypeID = 1234,
                Price = 5000 }
            };

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

           return View("Index", model);
        
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