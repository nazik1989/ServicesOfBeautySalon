using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServicesOfBeautySalon.DAL;
using ServicesOfBeautySalon.Models;

namespace ServicesOfBeautySalon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();

            using (var context = new BeautySalonServiceDBConection())
            {
                //var advertisments = context.Advertisements.Include(ad => ad.BeautySalon).ToList();
                var advertisments = context.Advertisements.ToList();
                List<AdvertisementModel> listOfAdvertisement = advertisments.Select(adv => new AdvertisementModel
                {
                    ID = adv.ID,
                    Name = adv.Name,
                    Description = adv.Description,
                    BeautySalonID = adv.BeautySalonID }).ToList();

                var serviceTypes = context.ServiceTypes.ToList();
                List<ServiceTypeModel> listOfServiceTypes = serviceTypes.Select(st => new ServiceTypeModel
                {
                    ID = st.ID,
                    Name = st.Name,
                    ImageURL = st.ImageURL,
                    CountOfServices = (int)st.CountOfServices
                }).ToList();

                model.Advertisements = listOfAdvertisement;
                model.ServiceTypes = listOfServiceTypes;

            }
                return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult GetCountForHomePage()
        {
            IDictionary< string, int> counts = new Dictionary<string, int>();

            using (var context = new BeautySalonServiceDBConection())
            {
                counts.Add("BeautySalonsCount", context.BeautySalons.Count());
                counts.Add("ServicesCount", context.Services.Count());
                counts.Add("MastersCount", context.Users.Where(u => u.RoleID == 3).Count());
                counts.Add("ClientCount", context.Users.Where(u => u.RoleID == 4).Count());
                
            }
                return Json(counts, JsonRequestBehavior.AllowGet);
        }
    }
}