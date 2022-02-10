using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesOfBeautySalon.Models
{
   public class RoleModel
    {
        public RoleModel()
        {
            this.Users = new List<UserModel>();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public string Permission { get; set; }


        public virtual List<UserModel> Users { get; set; }
    }
}
