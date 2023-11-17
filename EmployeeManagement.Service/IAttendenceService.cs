using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Service
{
    public interface IAttendenceService
    {
        Attendence GetAttendenceId(int id);
        void updateAttdence (Attendence attendance);
    }
}
