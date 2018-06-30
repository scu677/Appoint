/*
 *  Copyright (c) 2018 Stanley Uche Godfrey
 * All rights reserved.
 * Can only be modified by members of the appoint team
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Appoint.Models
{
    public class Schedule
    {  /*
     * The Schedule object and its properties
     */
        public int ScheduleID { get; set; }
        [ForeignKey("Partner")]
        public int PartnerFK { get; set; }
        public string ServiceName { get; set; }
        [DataType(DataType.DateTime)]
        public int StartTime { get; set; }
        [DataType(DataType.DateTime)]
        public int EndTime { get; set; }
        [DataType(DataType.Duration)]
        public int ScheduleDuration { get; set; }
        public bool Status { get; set; }
    }
}

