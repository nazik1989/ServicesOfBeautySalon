using ServicesOfBeautySalon.DAL;
using ServicesOfBeautySalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServicesOfBeautySalon.Controllers
{
    public class ServiceTypeController : Controller
    {
        // GET: ServiceType
        [HttpGet]
        public ActionResult Index()
        {
            List<ServiceTypeModel> model;

            using (var context = new BeautySalonServiceDBConection())

            {
                var serviceTypes = context.ServiceTypes.ToList();
                model = serviceTypes.Select
                    (st => new ServiceTypeModel
                    {   ID = st.ID,
                        Name = st.Name,
                        ImageURL = st.ImageURL,
                        CountOfServices = (int)st.CountOfServices
                    })
                    .ToList();
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new ServiceTypeModel());
        }

        [HttpPost]
        public ActionResult Create(ServiceTypeModel model)
        {
            using (var context = new BeautySalonServiceDBConection())
            {
                string getId = DateTime.Now.ToString().Replace(".", "").Replace(":", "").Replace(" ", "");
                var countOfServices = context.ServiceTypes.Count();
                context.ServiceTypes.Add(new ServiceType
                {
                    ID = Convert.ToInt64(getId), //Convert.ToInt32(DateTime.Now.ToString().Replace(".", "")),
                    Name = model.Name,
                    ImageURL = model.ImageURL,
                    CountOfServices = countOfServices
                });

                context.SaveChanges();

            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(long id)
        {
            ServiceType serviceType;
            using (var context = new BeautySalonServiceDBConection())
            {
               serviceType = context.ServiceTypes.FirstOrDefault(
                    st => st.ID == id);
            }
                return View(new ServiceTypeModel { ID = serviceType.ID,
                                                   Name = serviceType.Name,
                                                   ImageURL = serviceType.ImageURL,
                                                   CountOfServices = serviceType.CountOfServices
                });
        }


        [HttpPost]
        public ActionResult Delete(ServiceTypeModel model)
        {
            using (var context = new BeautySalonServiceDBConection())
            {
                var serviceType = context.ServiceTypes.FirstOrDefault(st => st.ID == model.ID);
                context.ServiceTypes.Remove(serviceType);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}