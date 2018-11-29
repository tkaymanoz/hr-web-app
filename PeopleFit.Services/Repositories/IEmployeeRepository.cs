using System.Collections.Generic;
using PeopleFit.Data.Models;

namespace PeopleFit.Services.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Person GetPersonalDetails(int employeeID);
        string GetFullName(int employeeID);
        string GetCurrentPositionTitle(int employeeID);
        Employee GetCurrentManager(int employeeID);
        IEnumerable<Phone> GetPhoneNumbers(int employeeID);
        IEnumerable<Address> GetAddresses(int employeeID);
        IEnumerable<Email> GetEmails (int employeeID);
        IEnumerable<Appointment> GetAppointments(int employeeID);
        IEnumerable<Course> GetCoursesAttended(int employeeID);
        IEnumerable<CourseBooking> GetCourseBookings(int employeeID);
    }
}