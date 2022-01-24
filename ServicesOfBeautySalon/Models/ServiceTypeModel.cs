using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServicesOfBeautySalon.Models
{
    public class ServiceTypeModel
    {
        public long ID { get; set; }

        [MinLength(2, ErrorMessage= "The name length must be more than 1 letter.")]
        [Required (ErrorMessage = "The name is required.")]
        public string Name { get; set; }


        public string ImageURL { get; set; }
        public int? CountOfServices { get; set; }
        public long BeautySalonID { get; set; }
        public virtual ICollection<BeautySalonModel> BeautySalons { get; set; }
    }
}