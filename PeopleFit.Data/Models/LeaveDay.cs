using System;
using System.Collections.Generic;

namespace PeopleFit.Data.Models
{
    public class LeaveDay
    {
        public int ID { get; set; }

        public int EmployeeID { get; set; }
        public LeaveType LeaveType { get; set; }
        public bool? Approved { get; set; }
        public DateTime TakenOn { get; set; }
        public bool HalfDay { get; set; }

        public Employee Employee { get; set; }


    }
}