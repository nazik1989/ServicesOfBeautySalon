using ServicesOfBeautySalon.DAL;
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
        // GET: ServiceType
        [HttpGet]
        public ActionResult Index()
        {
            List<UserModel> model;

            using (var context = new BeautySalonServiceDBConection())

            {
                var users = context.Users.ToList();
                model = users.Select
                    (u => new UserModel
                    {   ID = u.ID,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        ImageURL = u.ImageURL,
                        Phone = u.Phone,
                        Mail = u.Mail,
                        UserName = u.UserName,
                        Password = u.Password
                    })
                    .ToList();
            }

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
            using (var context = new BeautySalonServiceDBConection())
            {
                string getId = DateTime.Now.ToString().Replace(".", "").Replace(":", "").Replace(" ", "");
                context.Users.Add(new User
                {
                    ID = Convert.ToInt64(getId), //Convert.ToInt32(DateTime.Now.ToString().Replace(".", "")),
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Phone = model.Phone,
                    Mail = model.Mail,
                    ImageURL = model.ImageURL,

                    RoleID = 4,
                    UserName = model.UserName,
                    Password = model.Password
                })  ;

                context.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult OneUser(long id)
        {
            User user;
            using (var context = new BeautySalonServiceDBConection())
            {
                user = context.Users.FirstOrDefault(
                    st => st.ID == id);
            }
            return View(new UserModel {
                ID = user.ID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ImageURL = user.ImageURL,
                Phone = user.Phone,
                Mail = user.Mail,
                UserName = user.UserName,
                Password = user.Password
            });
        }

        [HttpGet]
        public ActionResult Delete(long id)
        {
            User user;
            using (var context = new BeautySalonServiceDBConection())
            {
               user = context.Users.FirstOrDefault(
                    st => st.ID == id);
            }
                return View(new UserModel { 
                    ID = user.ID,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    ImageURL = user.ImageURL,
                    Phone = user.Phone,
                    Mail = user.Mail,
                    UserName = user.UserName,
                    Password = user.Password
                });
        }


        [HttpPost]
        public ActionResult Delete(UserModel model)
        {
            using (var context = new BeautySalonServiceDBConection())
            {
                var user = context.Users.FirstOrDefault(u => u.ID == model.ID);
                context.Users.Remove(user);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            UserModel model;
            using (var context = new BeautySalonServiceDBConection())
            {
                var user = context.Users.FirstOrDefault(s => s.ID == id);
                model = new UserModel
                {
                    ID = user.ID,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    ImageURL = user.ImageURL,
                    Phone = user.Phone,
                    Mail = user.Mail,
                    UserName = user.UserName,
                    Password = user.Password

                };
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(User model)
        {
            using (var context = new BeautySalonServiceDBConection())
            {
                var user = context.Users.FirstOrDefault(st => st.ID == model.ID);
                user.FirstName = model.FirstName;
                user.LastName = user.LastName;
                user.ImageURL = user.ImageURL;
                user.Phone = user.Phone;
                user.Mail = user.Mail;
                user.UserName = user.UserName;
                user.Password = user.Password;

                context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

                return RedirectToAction("Index");
        }
    }
}