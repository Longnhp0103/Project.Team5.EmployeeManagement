using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Service
{
    public interface IEmployeeService
    {
        void CreateEmployee(Employee employee);
        List<Employee> GetAllEmployee();
        Employee GetEmployeeById(int id);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        Employee Authentication(string email, string password);

        void AddToTeam(int memberId, int teamId);
        void CreateEmployeeWorkingService(EmployeeWorkingShift employeeWorkingShift);
        void AttendenceEmployee(Attendence attendence);
    }
}
