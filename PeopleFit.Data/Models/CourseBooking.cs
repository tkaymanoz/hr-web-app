using System;
using System.Collections.Generic;

namespace PeopleFit.Data.Models
{
    public enum BookingState
    {
        Confirmed,Pending,Rejected
    }
    public class CourseBooking
    {
        public int ID { get; set; }
        public int? CourseSessionID { get; set; }
        public int EmployeeID { get; set; }     
        public BookingState BookingState { get; set; }
        public bool Attended { get; set; }
        
        public CourseSession CourseSession {get; set;}
        public Employee Employee { get; set; }

    }
}