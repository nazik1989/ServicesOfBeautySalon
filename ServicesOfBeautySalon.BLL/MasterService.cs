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
        public static List<UserModel> GetMasters()
        {

            var masters = MasterRepository.GetMasters();

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

        public static UserModel GetSpecialMaster(long id)
        {
            UserModel masterModel = new UserModel();
            var master = MasterRepository.GetSpecialMaster(id);
            if (master is null)
            {
                return null;
            }
            masterModel.ID = master.ID;
            masterModel.FirstName = master.FirstName;
            masterModel.LastName = master.LastName;
            masterModel.Phone = master.Phone;
            masterModel.Mail = master.Mail;
            masterModel.ImageURL = master.ImageURL;
            masterModel.RoleID = master.RoleID;
            masterModel.UserName = master.UserName;
            masterModel.Password = master.Password;

           
            //List<BeautySalonServiceModel> beautySalonServiceModels = new List<BeautySalonServiceModel>();
            //foreach (var item in MasterRepository.GetSpecialMaster(id).Select(m => m.BeautySalonServices))
            //{
            //    beautySalonServiceModels.Add(new BeautySalonServiceModel
            //    {
            //MasterUserID = m.BeautySalonServices
            //    });
            //}
            return masterModel;
            
        }
    }
}
