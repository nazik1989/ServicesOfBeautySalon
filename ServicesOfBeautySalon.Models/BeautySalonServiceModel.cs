using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesOfBeautySalon.Models
{
    public class BeautySalonServiceModel
    {
        public BeautySalonServiceModel()
        {
            //this.Registrations = new List<RegistrationModel>();
        }

        public long ID { get; set; }
        public long BeautySalonID { get; set; }
        public long ServiceID { get; set; }
        public long MasterUserID { get; set; }
        public Nullable<int> Discount { get; set; }

        //public virtual BeautySalonModel BeautySalon { get; set; }
        //public virtual ServiceModel Service { get; set; }
        //public virtual UserModel User { get; set; }
        //public virtual ICollection<RegistrationModel> Registrations { get; set; }
    }
}
