using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appoint.Models
{
    public class User_Client
    {
        public int User_ClientID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
       
        public string Password { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Street { get; set; }
       
        public string City { get; set; }

        [DataType(DataType.PostalCode)]
        public string Postcode { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
