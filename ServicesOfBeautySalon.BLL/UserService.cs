using ServicesOfBeautySalon.DAL;
using ServicesOfBeautySalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesOfBeautySalon.BLL
{
    public class UserService
    {
        public List<UserModel> users { get; set; }

        UserRepository userRepository = new UserRepository();
        public List<UserModel> getUsers() 
        {
            users = userRepository.getUsers().Select(u => new UserModel
            {
                ID = u.ID,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Phone = u.Phone,
                Mail = u.Mail,
                ImageURL = u.ImageURL,
                RoleID = u.RoleID,
                UserName = u.UserName,
                Password = u.Password

            }).ToList();

            return users;
        }

        public UserModel createUser(UserModel model)
        { 
            
            userRepository.createUser(new User
            {
                ID = model.ID,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Phone = model.Phone,
                Mail = model.Mail,
                ImageURL = model.ImageURL,
                RoleID = model.RoleID,
                UserName = model.UserName,
                Password = model.Password
            });

            return model;
        }
    }
}
