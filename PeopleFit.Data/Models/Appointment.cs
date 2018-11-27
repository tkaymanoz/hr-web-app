using System;
using System.Collections.Generic;

namespace PeopleFit.Data.Models
{
    public class Appointment
    {
        public int ID {get; set;}
        public int EmployeeID { get; set; }
        public int PositionID { get; set; }
        public DateTime AppointedOn { get; set; }
        public DateTime? ReassignedOn { get; set; }

        public Employee Employee {get; set;}
        public Position Position { get; set; }
        
    }
}