using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleFit.Data.Models
{
    public enum Contract
    {
        Permanent, FixedTerm, Temporary,Internship
    }
    public class Employee
    {
        public int ID { get; set; }
        public string EmployeeNo { get; set; }
        public Contract Contract { get; set; }
        public DateTime StartDate{get; set;}
        public DateTime? EndDate{get; set;}
        public int PersonID {get; set;}

        public Person Person{get; set;}
        public LeaveBalance LeaveBalance { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<LeaveDay> LeaveDays {get; set;}
        public ICollection<CourseBooking> CourseBookings { get; set; }
        public ICollection<LeaveAccrual> LeaveAccruals {get; set;}
        [InverseProperty("Leader")]
        public ICollection<Manager> Leaders{get; set;}
        [ForeignKey("Subordinate")]
        public ICollection<Manager> Subordinates{get; set;}
    }
}