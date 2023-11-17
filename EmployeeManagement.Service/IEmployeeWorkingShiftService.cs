using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Service
{
    public interface IEmployeeWorkingShiftService
    {
        EmployeeWorkingShift GetEmployeeWorkingShiftId(int id);
        List<EmployeeWorkingShift> GetAll();
        void CreateEmployeeWorkingShift(EmployeeWorkingShift employeeWorkingShift);
        void UpdateEmployeeWorkingShift( EmployeeWorkingShift employeeWorkingShift);
        void DeleteEmployeeWorkingShift(int id);
    }
}
