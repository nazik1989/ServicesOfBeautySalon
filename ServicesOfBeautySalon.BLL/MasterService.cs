using ServicesOfBeautySalon.DAL;
using ServicesOfBeautySalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesOfBeautySalon.BLL
{
    public class MasterService
    {
        public static List<UserModel> getMasters()
        {

            var masters = MasterRepository.getMasters();

        //public long RoleID { get; set; }

            return masters.Select(u => new UserModel {
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
        }
    }
}
