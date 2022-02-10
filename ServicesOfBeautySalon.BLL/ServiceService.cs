using ServicesOfBeautySalon.DAL;
using ServicesOfBeautySalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesOfBeautySalon.BLL
{
    public class ServiceService
    {
        public List<ServiceModel> services { get; set; }

        ServiceRepository serviceRepository = new ServiceRepository();

        public List<ServiceModel> GetServices()
        {
            services = serviceRepository.GetServices().Select(s => new ServiceModel {
                ID = s.ID,
                Name = s.Name,
                ServiceTypeID = s.ServiceTypeID,
                Price = s.Price
            }).ToList();

            return services;
        }

        public List<ServiceModel> SearchServicesByName(String name) 
        {
            services = serviceRepository.SearchServicesByName(name).Select(s => new ServiceModel
            { 
            ID = s.ID,
            Name = s.Name,
            ServiceTypeID = s.ServiceTypeID,
            Price = s.Price
            }).ToList();

            return services;
        }
        
    }
}
