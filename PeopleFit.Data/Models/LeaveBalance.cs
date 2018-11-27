using System;
using System.Collections.Generic;

namespace PeopleFit.Data.Models
{
    public enum LeaveType
    {
        Annual,Sick,Study,Maternity,Special
    }

    public class LeaveBalance
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int Annual { get; set; }
        public int Sick { get; set; }
        public int Study { get; set; }
        public int Maternity { get; set; }
        public int Special { get; set; }
        public DateTime LastModified { get; set; }

        public Employee Employee { get; set; }
    }
}