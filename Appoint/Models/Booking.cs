/*
 *  Copyright (c) 2018 Stanley Uche Godfrey
 * All rights reserved
 * Can only be modified by member of the Appoint team.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Appoint.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        [ForeignKey("User")]
        public int UserFK { get; set; }
        [ForeignKey("Partner")]
        public int PartnerFK { get; set; }
        [ForeignKey("Service")]
        public int ServiceFK { get; set; }
        [DataType(DataType.DateTime)]
        public int StartTime { get; set; }
        [DataType(DataType.DateTime)]
        public int EndTime { get; set; }
        [DataType(DataType.Duration)]
        public int TimeBook { get; set; }
    }
}
