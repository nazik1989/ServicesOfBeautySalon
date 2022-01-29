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

            return masters.Select(u => new UserModel {
                ID = u.ID,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Mail
            }).ToList();
        }
    }
}
