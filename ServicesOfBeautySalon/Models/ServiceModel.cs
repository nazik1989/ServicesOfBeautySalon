using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesOfBeautySalon.Models
{
    public class ServiceModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long ServiceTypeID { get; set; }
        
        public int? Price { get; set; }
        public IEnumerable<BeautySalonModel> BeautySalons { get; set; }
        public string Master { get; set; }
        public int? Discount { get; set; }

        virtual public ServiceTypeModel ServiceType { get; set; }
    }
}