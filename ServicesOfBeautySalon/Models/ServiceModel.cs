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
    }
}