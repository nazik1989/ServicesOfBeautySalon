using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesOfBeautySalon.Models
{
    public class BeautySalonServiceModel
    {
        public long ID { get; set; }
        public long BeautySalonID { get; set; }
        public long MasterUserID { get; set; }
        public long ServiceID { get; set; }
        public long Discount { get; set; }
    }
}