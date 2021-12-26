using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesOfBeautySalon.Models
{
    public class ServiceTypeModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public int? CountOfServices { get; set; }
    }
}