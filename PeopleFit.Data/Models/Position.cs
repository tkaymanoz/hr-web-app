using System;
using System.Collections.Generic;

namespace PeopleFit.Data.Models
{
    public enum RoleSize
    {
        I,J,K,L,M,N,O,P,R,S,T,U
    }

    public enum StaffCategory
    {
        Staff,Sales,Specialist,Management
    }
    public class Position
    {
        public int ID {get; set;}
        public string Title { get; set; }
        public int ThemeOfWork { get; set; }
        public RoleSize RoleSize { get; set; }
        public StaffCategory StaffCategory { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }
        public DateTime TimeStamp { get; set; }
        
        public ICollection<Appointment> Appointments {get; set;}


    }
}