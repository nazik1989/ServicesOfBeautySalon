using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesOfBeautySalon.Models
{
    public class UserModel
    {
        public UserModel()
        {
            //this.BeautySalons = new List<BeautySalonModel>();
            //this.BeautySalonServices = new List<BeautySalonServiceModel>();
            //this.Registrations = new List<RegistrationModel>();
        }

        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string ImageURL { get; set; }
        public long RoleID { get; set; }

        // User Password and userame small than 20 simbols
        public string UserName { get; set; }
        public string Password { get; set; }

        
        //public virtual ICollection<BeautySalonModel> BeautySalons { get; set; }
        //public virtual ICollection<BeautySalonServiceModel> BeautySalonServices { get; set; }
        //public virtual ICollection<RegistrationModel> Registrations { get; set; }
        //public virtual RoleModel Role { get; set; }


    }
}
