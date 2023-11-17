using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Service
{
    public interface IScheduleService
    {
        Schedule GetScheduleId (int scheduleId);
    }
}
