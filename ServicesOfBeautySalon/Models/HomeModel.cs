using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicesOfBeautySalon.Models;

namespace ServicesOfBeautySalon.Models
{
    public class HomeModel
    {
        public List<AdvertisementModel> Advertisements{ get; set; }
        public List<ServiceTypeModel> ServiceTypes{ get; set; }
}