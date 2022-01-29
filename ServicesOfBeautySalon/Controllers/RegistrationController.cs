
using ServicesOfBeautySalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServicesOfBeautySalon.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Service
        [HttpGet]
        public ActionResult Index()
        {
            //List<RegistrationModel> model;

            //using (var context = new BeautySalonServiceDBConection())

            //{
            //    var registrations = context.Registrations;
            //    model = registrations.Select
            //        (r => new RegistrationModel
            //        {
            //            ID = r.ID,
            //            StartTime = r.StartTime,
            //            EndTime = r.EndTime,

            //        })
            //        .ToList();
            //}

            //return View(model);
            return View();
        }

        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View(new RegistrationModel());
        //}

        //[HttpPost]
        //public ActionResult Create(RegistrationModel model)
        //{
        //    using (var context = new BeautySalonServiceDBConection())
        //    {
        //        string getId = DateTime.Now.ToString().Replace(".", "").Replace(":", "").Replace(" ", "");
        //        var countOfServices = context.ServiceTypes.Count() + 1;
        //        context.Registrations.Add(new Registration
        //        {
        //            ID = Convert.ToInt64(getId), //Convert.ToInt32(DateTime.Now.ToString().Replace(".", "")),
        //            StartTime = model.StartTime,
        //            EndTime = model.EndTime
        //        });

        //        context.SaveChanges();

        //    }
        //    return RedirectToAction("Index");
        //}

    }
}