
using ServicesOfBeautySalon.BLL;
using ServicesOfBeautySalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServicesOfBeautySalon.Controllers
{
    public class UserController : Controller
    {

        UserService userService = new UserService();
        
        [HttpGet]
        public ActionResult Index()
        {
            List<UserModel> model = new List<UserModel>();
            model = userService.GetUsers();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public ActionResult Create(UserModel model)
        {
            if (ModelState.IsValid)
            {
                userService.CreateUser(model);
                return RedirectToAction("Index");
            }

            return View(model);

        }

        [HttpGet]
        public ActionResult UserAccount(long id)
        {
            UserModel user;
            //using (var context = new BeautySalonServiceDBConection())
            //{
            //    user = context.Users.FirstOrDefault(
            //        st => st.ID == id);
            //}
            return View(new UserModel
            {
                ID = id,
                RoleID = 3,
                FirstName = "Hard coded firstName for Account",
                LastName = "Hard coded lastName for Account"

            }); ;
        }

        [HttpGet]
        public ActionResult Delete(long id)
        {
            //using (var context = new BeautySalonServiceDBConection())
            //{
            //    user = context.Users.FirstOrDefault(
            //         st => st.ID == id);
            //}
            return View(new UserModel
            {
                ID = id,
                FirstName = "Hard coded firstName",
                LastName = "Hard coded lastName"
            });
        }


        //[HttpPost]
        //public ActionResult Delete(UserModel model)
        //{
        //    using (var context = new BeautySalonServiceDBConection())
        //    {
        //        var user = context.Users.FirstOrDefault(u => u.ID == model.ID);
        //        context.Users.Remove(user);
        //        context.SaveChanges();
        //    }
        //    return RedirectToAction("Index");
        //}

        [HttpGet]
        public ActionResult Edit(long id)
        {
            UserModel model = new UserModel();
            //using (var context = new BeautySalonServiceDBConection())
            //{
            //    var user = context.Users.FirstOrDefault(s => s.ID == id);
            //    model = new UserModel
            //    {
            //        ID = user.ID,
            //        FirstName = user.FirstName,
            //        LastName = user.LastName,
            //        ImageURL = user.ImageURL,
            //        Phone = user.Phone,
            //        Mail = user.Mail,
            //        UserName = user.UserName,
            //        Password = user.Password

            //    };
            //}
            return View(model);
        }

        //[HttpPost]
        //public ActionResult Edit(User model)
        //{
        //    using (var context = new BeautySalonServiceDBConection())
        //    {
        //        var user = context.Users.FirstOrDefault(st => st.ID == model.ID);
        //        user.FirstName = model.FirstName;
        //        user.LastName = user.LastName;
        //        user.ImageURL = user.ImageURL;
        //        user.Phone = user.Phone;
        //        user.Mail = user.Mail;
        //        user.UserName = user.UserName;
        //        user.Password = user.Password;

        //        context.Entry(user).State = System.Data.Entity.EntityState.Modified;
        //        context.SaveChanges();
        //    }

        //        return RedirectToAction("Index");
        //}
    }
}