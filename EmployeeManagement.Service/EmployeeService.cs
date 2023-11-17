using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;

namespace EmployeeManagement.Service
{
    public class EmployeeService : IEmployeeService
    {

        IEmployeeRepository repository;
        IEmployeeWorkingShiftRepository workingShiftRepository;
        IAttendenceRepository attendenceRepository;
        public EmployeeService(IEmployeeRepository repository, IEmployeeWorkingShiftRepository workingShiftRepository, IAttendenceRepository attendenceRepository)
        {
            this.repository = repository;
            this.workingShiftRepository = workingShiftRepository;
            this.attendenceRepository = attendenceRepository;
        }
        public void CreateEmployee(Employee employee)
        {
            repository.Insert(employee);
            Employee e = repository.GetEmployeeById(employee.Id);
            e.Team.MemberNumber++;
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

        public Employee Authentication(string email, string password)
        {
            return repository.Authentication(email, password);
        }

        public void UpdateEmployee(Employee employee)
        {
            repository.Update(employee);
        }

        public void AddToTeam(int memberId, int teamId)
        {
            Employee employee = repository.GetEmployeeById(memberId);
            if (employee != null && employee.Team.MemberNumber < 5)
            {
                employee.TeamId = teamId;
            }
        }

        public void CreateEmployeeWorkingService(EmployeeWorkingShift employeeWorkingShift)
        {
            workingShiftRepository.Insert(employeeWorkingShift);
        }

        public void AttendenceEmployee(Attendence attendence)
        {
            attendenceRepository.Insert(attendence);
        }
    }

}