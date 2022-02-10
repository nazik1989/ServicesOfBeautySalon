using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesOfBeautySalon.Models
{
   public class ServiceTypeModel
    {
        public ServiceTypeModel()
        {
            this.Services = new List<ServiceModel>();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public Nullable<int> CountOfServices { get; set; }


        public virtual List<ServiceModel> Services { get; set; }
    }
}
