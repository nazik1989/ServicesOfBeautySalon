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
                    { ID = st.ID,
                    Name =st.Name,
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
    }
}