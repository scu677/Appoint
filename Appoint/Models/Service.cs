﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Appoint.Models
{
    public class Service
    
    {
        public int ServiceID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public string Price { get; set; }
        [DataType(DataType.Duration)]
        public string Duration { get; set; }
        [ForeignKey("Partner")]
        public int PartnerFK { get; set; }
    }
}
