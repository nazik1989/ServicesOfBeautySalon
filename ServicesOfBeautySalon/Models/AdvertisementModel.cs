using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesOfBeautySalon.Models
{
    public class AdvertisementModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long BeautySalonID { get; set; }

        public virtual BeautySalonModel BeautySalon { get; set; }

    }
}