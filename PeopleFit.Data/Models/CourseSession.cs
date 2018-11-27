using System;
using System.Collections.Generic;

namespace PeopleFit.Data.Models
{
    public enum SessionState
    {
        Confirmed,Tentative,Cancelled,Postponed
    }
    public class CourseSession
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int CourseID { get; set; }
        public int ClassSize { get; set; }
        public DateTime TakenOn { get; set; }
        public SessionState SessionState { get; set; }

        public Employee Employee { get; set; }
        public Course Course { get; set; }

        public ICollection<CourseBooking> CourseBookings { get; set; }




    }
}