using PeopleFit.Data.Models;

namespace PeopleFit.Services.AggregateModels
{
    public class LeaveDaysTaken
    {
        public LeaveType LeaveType { get; set; }
        public decimal NumberOfDays { get; set; }
    }
    public class LeaveDaysTakenByEmployee :LeaveDaysTaken
    {
        public int EmployeeID { get; set; }
    }
}
