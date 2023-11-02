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

    }
}
