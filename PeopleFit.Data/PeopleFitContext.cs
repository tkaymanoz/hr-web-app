using PeopleFit.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace PeopleFit.Data
{
    public class PeopleFitContext : DbContext
    {
        public PeopleFitContext(DbContextOptions<PeopleFitContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees {get; set;}
        public DbSet<Person> Persons {get; set;}
        public DbSet<Address> Addresses {get; set;}
        public DbSet<PersonAddress> PersonAddresses { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<PersonEmail> PersonEmails { get; set; }
        public DbSet<PersonPhone> PersonPhones { get; set; }
        public DbSet<Position> Positions {get; set;}
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Course> Courses {get; set;}
        public DbSet<CourseSession> CourseSessions { get; set; }
        public DbSet<CourseBooking> CourseBookings { get; set; }
        public DbSet<LeaveDay> LeaveDays { get; set; }
        public DbSet<LeaveAccrual> LeaveAccruals { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Person>().ToTable("Person");
        //     modelBuilder.Entity<Employee>().ToTable("Employee");
        //     modelBuilder.Entity<Position>().ToTable("Position");
        //     modelBuilder.Entity<Appointment>().ToTable("Appointment");
        //     modelBuilder.Entity<Course>().ToTable("Course");
        //     modelBuilder.Entity<CourseSession>().ToTable("CourseSession");
        //     modelBuilder.Entity<CourseBooking>().ToTable("CourseBooking");
        //     modelBuilder.Entity<LeaveDay>().ToTable("LeaveDay");
        //     modelBuilder.Entity<LeaveAccrual>().ToTable("LeaveAccrual");
        //     //modelBuilder.Entity<Student>().ToTable("Student");
        // }
    }
}