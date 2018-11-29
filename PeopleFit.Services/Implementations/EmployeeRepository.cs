using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using PeopleFit.Data.Models;
using PeopleFit.Services.Repositories;
using PeopleFit.Data;
using System;

namespace PeopleFit.Services.Implementations
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository 
    {
        private int PersonID(int employeeID)
        {
            return GetPersonalDetails(employeeID).ID;
        }
        public PeopleFitContext PeopleFitContext 
        {
             get{ return _context as PeopleFitContext;}
        }
        public EmployeeRepository(PeopleFitContext context) : base(context){}

        public IEnumerable<Address> GetAddresses(int employeeID)
        {
            //var personID = GetPersonalDetails(employeeID).ID;
             
            var addresses = PeopleFitContext.Addresses
                .Include(a =>a.Country)
                .Where(a =>a.PersonAddresses.Any(
                    pa => pa.PersonID == PersonID(employeeID)
                ));
            return addresses;
        }

        public IEnumerable<Appointment> GetAppointments(int employeeID)
        {
            var appointments = PeopleFitContext.Appointments
                .Include(a =>a.Position)
                .Where(a => a.Employee.ID == employeeID);
            
            return appointments;
            //return appointments.ToList();
        }

        public IEnumerable<CourseBooking> GetCourseBookings(int employeeID)
        {
            var now = DateTime.Now;
            var courseBookings = PeopleFitContext.CourseBookings
                .Include(cb => cb.CourseSession.Course)
                .Include(cb => cb.CourseSession)
                .Where(cb =>cb.EmployeeID == employeeID
                    && cb.CourseSession.TakenOn >= now);
            return courseBookings;
        }

        public IEnumerable<Course> GetCoursesAttended(int employeeID)
        {
            var attendedCourseBookings = GetCourseBookings(employeeID)
                .Where(cb => cb.Attended==true);

            var coursesAttended = PeopleFitContext.Courses
                .Include(
                    c => c.CourseSessions.Any(
                        cs => cs.CourseBookings.Any(
                            cbs => (cbs.Attended == true && cbs.EmployeeID == employeeID)
                    )));

            return null;
        }

        public Employee GetCurrentManager(int employeeID)
        {
            //var now = DateTime.Now;
            var manager = dbSet
                .Where(e => e.Subordinates
                    .OrderByDescending(s => s.Since).Any
                    (
                        s =>s.SubordinateID ==employeeID
                    )
                ).FirstOrDefault()
                ;
            return manager;
        }

        public string GetCurrentPositionTitle(int employeeID)
        {
            var position = PeopleFitContext.Positions
                .Where(p => p.Appointments
                    .OrderByDescending(a =>a.AppointedOn)
                    .Any(
                        a => a.EmployeeID ==employeeID
                ))
                .FirstOrDefault();
            
            if (position != null)
            {
                return position.Description;
            }
            return null;
        }

        public IEnumerable<Email> GetEmails(int employeeID)
        {
            throw new System.NotImplementedException();
        }

        public string GetFullName(int employeeID)
        {
            return GetPersonalDetails(employeeID).FullName;
        }

        public Person GetPersonalDetails(int employeeID)
        {
            var person = PeopleFitContext.Persons
                .FirstOrDefault(p => p.ID ==employeeID);
            return person;
        }

        public IEnumerable<Phone> GetPhoneNumbers(int employeeID)
        {
            //var personID = GetPersonalDetails(employeeID).ID;

            var phoneNumbers = PeopleFitContext.Phones
                .Where(ph => ph.PersonPhones.Any
                (
                    pa => pa.PersonID==PersonID(employeeID)
                ));
            
            return phoneNumbers;

        }        
    }
}