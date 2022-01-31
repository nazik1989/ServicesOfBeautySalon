using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesOfBeautySalon.Models
{
    public class ServiceModel
    {
        public ServiceModel()
        {
            //this.BeautySalonServices = new List<BeautySalonServiceModel>();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public long ServiceTypeID { get; set; }
        public Nullable<int> Price { get; set; }

        
        //public virtual ICollection<BeautySalonServiceModel> BeautySalonServices { get; set; }
        //public virtual ServiceTypeModel ServiceType { get; set; }
    }
}
