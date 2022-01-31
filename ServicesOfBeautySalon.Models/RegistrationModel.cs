using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesOfBeautySalon.Models
{
    public class RegistrationModel
    {
        public long ID { get; set; }
        public long RegisterUserID { get; set; }
        public long BeautySalonServiceID { get; set; }
        public System.DateTime Day { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }

        //public virtual BeautySalonServiceModel BeautySalonService { get; set; }
        //public virtual UserModel User { get; set; }
    }
}
