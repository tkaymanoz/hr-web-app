using System;
using System.Collections.Generic;

namespace PeopleFit.Data.Models
{
    public enum AccrualType
    {
        Initial,Annual,Monthly
    }
    public class LeaveAccrual
    {
        public int ID { get; set; }
        public  int EmployeeID { get; set; }
        public decimal Number { get; set; }
        public LeaveType LeaveType { get; set; }
        public AccrualType AccrualType { get; set; }
        public DateTime AccruedOn { get; set; }

        public Employee Employee { get; set; }
    }
}