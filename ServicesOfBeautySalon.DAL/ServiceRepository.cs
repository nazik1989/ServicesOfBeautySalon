using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesOfBeautySalon.DAL
{
    public class ServiceRepository
    {
        public List<Service> services = new List<Service>();
        public List<Service> GetServices() {
            using (var context = new BeautySalonServiceDBEntities()) 
            {
                services = context.Services.Select(s => s).ToList();
            }
            return services;
        }

        public List<Service> SearchServicesByName(string name)
        {
            using (var context = new BeautySalonServiceDBEntities())
            {
                services = context.Services.Select(s => s).Where(s => s.Name.Contains(name)).ToList();
            }
            return services;
        }


    }
}
