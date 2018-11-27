using System;
using System.Collections.Generic;

namespace PeopleFit.Data.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string ImageUrl {get; set;}
        public RoleSize MinimumRoleSize {get; set;}
        
        public ICollection<CourseSession> CourseSessions {get; set;}

    }
}