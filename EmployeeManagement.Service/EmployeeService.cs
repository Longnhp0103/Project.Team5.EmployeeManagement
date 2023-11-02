using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;

namespace EmployeeManagement.Service
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository repository;
        public EmployeeService(IEmployeeRepository repository)
        {
            this.repository = repository;
        }
        public void CreateEmployee(Employee employee)
        {
            repository.Insert(employee);
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = repository.GetById(id);
            if (employee != null)
            {
                repository.Delete(employee.Id);
            }
        }

        public List<Employee> GetAllEmployee()
        {
            return (List<Employee>)repository.GetAll();
        }

        public Employee GetEmployeeById(int id)
        {
            return repository.GetById(id);
        }

        public void UpdateEmployee(Employee employee)
        {
            repository.Update(employee);
        }
    }
}