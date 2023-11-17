using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;

namespace EmployeeManagement.Service
{
    public class EmployeeWorkingShiftService : IEmployeeWorkingShiftService
    {
        IEmployeeWorkingShiftRepository repository;
        public EmployeeWorkingShiftService(IEmployeeWorkingShiftRepository repository)
        {
            this.repository = repository;
        }

        public void CreateEmployeeWorkingShift(EmployeeWorkingShift employeeWorkingShift)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeeWorkingShift(int id)
        {
            throw new NotImplementedException();
        }

        public EmployeeWorkingShift GetEmployeeWorkingShiftId(int id)
        {
            EmployeeWorkingShift employeeWorkingShiftId = repository.GetById(id);
            return employeeWorkingShiftId;
        }

        public void UpdateEmployeeWorkingShift(EmployeeWorkingShift employeeWorkingShift)
        {
            throw new NotImplementedException();
        }
    }
}
