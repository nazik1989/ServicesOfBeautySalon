using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesOfBeautySalon.Models
{
    public class BeautySalonModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public System.TimeSpan OpenTime { get; set; }
        public System.TimeSpan CloseTime { get; set; }
        public string ImageURL { get; set; }
        public Nullable<int> CountOfSerivces { get; set; }
        public Nullable<int> CountOfMasters { get; set; }
        public long AdminUserID { get; set; }   
    }
}