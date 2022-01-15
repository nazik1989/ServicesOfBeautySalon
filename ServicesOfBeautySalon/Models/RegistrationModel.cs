using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesOfBeautySalon.Models
{
    public class RegistrationModel
    {
        public long ID { get; set; }
        public long UserID  { get; set; }
        public long BeautySalonServiceID { get; set; }
        public DateTime Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
          
    }
}