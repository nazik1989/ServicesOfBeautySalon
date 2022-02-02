using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesOfBeautySalon.DAL
{
    public class UserRepository
    {
        public List<User> users { get; set; }
        public User user { get; set; }

        public List<User> getUsers()
        {
            using (var context = new BeautySalonServiceDBEntities()) 
            {
                users = context.Users.Select(u => u).ToList();
            }
            return users;
        }
        public User createUser(User model) {
            User user;
            using (var context = new BeautySalonServiceDBEntities())
            {
                string createId = DateTime.Now.ToString().Replace(".", "").Replace(":", "").Replace(" ", "");
                user = context.Users.Add(new User {
                    ID = Convert.ToInt64(createId), //Convert.ToInt32(DateTime.Now.ToString().Replace(".", "")),
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Phone = model.Phone,
                    Mail = model.Mail,
                    ImageURL = model.ImageURL,
                    RoleID = 4,
                    UserName = model.UserName,
                    Password = model.Password
                });
                context.SaveChanges();
            }
            return user;
        }


    }
}
