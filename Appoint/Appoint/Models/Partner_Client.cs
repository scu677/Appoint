using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appoint.Models
{
    public class Partner_Client
    {
        public int Partner_ClientID { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string BizName { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string BizDescription { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public string OpeningHours { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }

        public byte[] File { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        public string FileName { get; set; }
        [Required]
        public string Postcode { get; set; }
        [Required]
        public string Province { get; set; }
    }
}
