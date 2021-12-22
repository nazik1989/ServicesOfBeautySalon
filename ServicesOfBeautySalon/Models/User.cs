using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesOfBeautySalon.Models
{
    public class User
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string ImageURL { get; set; }
        public long RoleID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}