using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServicesOfBeautySalon.Models
{
    public class UserModel
    {
        public long ID { get; set; }

        [MinLength(2, ErrorMessage = "The firstname must be more than 1 letter.")]
        [Required (ErrorMessage = "The firstname is required.")]
        public string FirstName { get; set; }

        [MinLength(2, ErrorMessage = "The firstname must be more than 1 letter.")]
        [Required (ErrorMessage = "The lastname is required.")]
        public string LastName { get; set; }

        [RegularExpression(@"(([+374]{4}|[0]{1}))?([1-9]{2})(\d{6})", ErrorMessage = "Please write the correct phone number.")]
        public string Phone { get; set; }

        [RegularExpression(@"/^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$/", ErrorMessage = "Please write the correct mail")]
        public string Mail { get; set; }

        public string ImageURL { get; set; }
        public long RoleID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}