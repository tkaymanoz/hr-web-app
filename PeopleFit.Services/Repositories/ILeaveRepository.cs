using System;
using System.Collections.Generic;
using PeopleFit.Data.Models;
using PeopleFit.Services.AggregateModels;

namespace PeopleFit.Services.Repositories
{
    //Note to Self : This repository is incomplete
    public interface ILeaveRepository : IRepository<LeaveDay>
    {
        void ApproveLeave(int leaveDayID);
        void ApproveLeaveRange( IEnumerable<LeaveDay> leaveDays);
        void CalculateLeaveBalance(int employeeID);
        void AccrueLeave(int employeeID);
        IEnumerable<LeaveDaysTakenByEmployee> GetSumOfEmployeeLeaveTaken(string employeeID, DateTime from, DateTime to);

        LeaveDaysTaken GetSumOfWorkforceLeaveTaken(DateTime from, DateTime to);

    }
}