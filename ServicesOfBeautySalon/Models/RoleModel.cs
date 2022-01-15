using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesOfBeautySalon.Models
{
    public class RoleModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Permission { get; set; }
    }
}